using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.GM;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Encoders;
using Org.BouncyCastle.X509;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Utilities
{
    /// <summary>
    /// SM2 算法工具类。
    /// <para>此实现遵循国家标准 GM/T 0009-2012 的有关规定。</para>
    /// </summary>
    public static class SM2Utility
    {
        private static readonly X9ECParameters SM2_ECX9_PARAMS = GMNamedCurves.GetByName("SM2P256v1");
        private static readonly ECDomainParameters SM2_DOMAIN_PARAMS = new ECDomainParameters(SM2_ECX9_PARAMS.Curve, SM2_ECX9_PARAMS.G, SM2_ECX9_PARAMS.N);
        private static readonly byte[] SM2_DEFAULT_UID = new byte[] { 0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x37, 0x38, 0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x37, 0x38 };
        private const int SM2_C1_LENGTH = 65;
        private const int SM2_C3_LENGTH = 32;
        private const int SM2_RS_LENGTH = 32;

        private static byte[] ConvertPrivateKeyPkcs8PemToByteArray(string privateKey)
        {
            privateKey = privateKey
                .Replace("-----BEGIN PRIVATE KEY-----", string.Empty)
                .Replace("-----END PRIVATE KEY-----", string.Empty);
            privateKey = Regex.Replace(privateKey, "\\s+", string.Empty);
            return Convert.FromBase64String(privateKey);
        }

        private static byte[] ConvertPublicKeyPkcs8PemToByteArray(string publicKey)
        {
            publicKey = publicKey
                .Replace("-----BEGIN PUBLIC KEY-----", string.Empty)
                .Replace("-----END PUBLIC KEY-----", string.Empty);
            publicKey = Regex.Replace(publicKey, "\\s+", string.Empty);
            return Convert.FromBase64String(publicKey);
        }

        private static X509Certificate ConvertCertificatePemToX509(string certificate)
        {
            using (TextReader sreader = new StringReader(certificate))
            {
                PemReader pemReader = new PemReader(sreader);
                return (X509Certificate)pemReader.ReadObject();
            }
        }

        private static ECPrivateKeyParameters ParsePrivateKeyPemToPrivateKeyParameters(string privateKey)
        {
            byte[] privateKeyBytes = ConvertPrivateKeyPkcs8PemToByteArray(privateKey);
            return ParsePrivateKeyPemToPrivateKeyParameters(privateKeyBytes);
        }

        private static ECPrivateKeyParameters ParsePrivateKeyPemToPrivateKeyParameters(byte[] privateKeyBytes)
        {
            return (ECPrivateKeyParameters)PrivateKeyFactory.CreateKey(privateKeyBytes);
        }

        private static ECPrivateKeyParameters ParseECPrivateKeyToPrivateKeyParameters(string ecPrivateKeyHex)
        {
            BigInteger ecPrivateKeyParamsD = new BigInteger(ecPrivateKeyHex, 16);
            return new ECPrivateKeyParameters(ecPrivateKeyParamsD, SM2_DOMAIN_PARAMS);
        }

        private static ECPublicKeyParameters ParsePublicKeyPemToPublicKeyParameters(byte[] publicKeyBytes)
        {
            return (ECPublicKeyParameters)PublicKeyFactory.CreateKey(publicKeyBytes);
        }

        private static ECPublicKeyParameters ParseECPublicKeyToPublicKeyParameters(string ecPublicKeyHex)
        {
            byte[] ecPublicKeyBytes = Hex.Decode(ecPublicKeyHex);

            const int KEY_BYTE_LENGTH = 64;

            bool unzipped = ecPublicKeyBytes.FirstOrDefault() == 0x04;
            if (unzipped && ecPublicKeyBytes.Length != KEY_BYTE_LENGTH + 1)
                throw new ArgumentException($"Invalid key byte length (expected: {KEY_BYTE_LENGTH}, actual: {ecPublicKeyBytes.Length - 1}).", nameof(ecPublicKeyBytes));
            if (!unzipped && ecPublicKeyBytes.Length != KEY_BYTE_LENGTH)
                throw new ArgumentException($"Invalid key byte length (expected: {KEY_BYTE_LENGTH}, actual: {ecPublicKeyBytes.Length}).", nameof(ecPublicKeyBytes));

            byte[] ecPublicKeyXBytes = new byte[KEY_BYTE_LENGTH / 2];
            byte[] ecPublicKeyYBytes = new byte[KEY_BYTE_LENGTH / 2];
            Buffer.BlockCopy(ecPublicKeyBytes, unzipped ? 1 : 0, ecPublicKeyXBytes, 0, ecPublicKeyXBytes.Length);
            Buffer.BlockCopy(ecPublicKeyBytes, ecPublicKeyXBytes.Length + (unzipped ? 1 : 0), ecPublicKeyYBytes, 0, ecPublicKeyYBytes.Length);

            BigInteger ecPublicKeyParamsX = new BigInteger(Hex.ToHexString(ecPublicKeyXBytes), 16);
            BigInteger ecPublicKeyParamsY = new BigInteger(Hex.ToHexString(ecPublicKeyYBytes), 16);
            return new ECPublicKeyParameters(SM2_ECX9_PARAMS.Curve.CreatePoint(ecPublicKeyParamsX, ecPublicKeyParamsY), SM2_DOMAIN_PARAMS);
        }

        private static byte[] ConvertC1C3C2ToC1C2C3(byte[] c1c3c2)
        {
            byte[] tmp = new byte[c1c3c2.Length];
            Buffer.BlockCopy(c1c3c2, 0, tmp, 0, SM2_C1_LENGTH);
            Buffer.BlockCopy(c1c3c2, SM2_C1_LENGTH + SM2_C3_LENGTH, tmp, SM2_C1_LENGTH, c1c3c2.Length - SM2_C1_LENGTH - SM2_C3_LENGTH);
            Buffer.BlockCopy(c1c3c2, SM2_C1_LENGTH, tmp, c1c3c2.Length - SM2_C3_LENGTH, SM2_C3_LENGTH);
            return tmp;
        }

        private static byte[] ConvertC1C2C3ToC1C3C2(byte[] c1c2c3)
        {
            byte[] tmp = new byte[c1c2c3.Length];
            Buffer.BlockCopy(c1c2c3, 0, tmp, 0, SM2_C1_LENGTH); //c1
            Buffer.BlockCopy(c1c2c3, c1c2c3.Length - SM2_C3_LENGTH, tmp, SM2_C1_LENGTH, SM2_C3_LENGTH);
            Buffer.BlockCopy(c1c2c3, SM2_C1_LENGTH, tmp, SM2_C1_LENGTH + SM2_C3_LENGTH, c1c2c3.Length - SM2_C1_LENGTH - SM2_C3_LENGTH);
            return tmp;
        }

        private static byte[] ConvertC1C3C2ToAsn1(byte[] c1c3c2)
        {
            byte[] c1 = Arrays.CopyOfRange(c1c3c2, 0, SM2_C1_LENGTH);
            byte[] c3 = Arrays.CopyOfRange(c1c3c2, SM2_C1_LENGTH, SM2_C1_LENGTH + SM2_C3_LENGTH);
            byte[] c2 = Arrays.CopyOfRange(c1c3c2, SM2_C1_LENGTH + SM2_C3_LENGTH, c1c3c2.Length);
            byte[] c1X = Arrays.CopyOfRange(c1, 1, 33);
            byte[] c1Y = Arrays.CopyOfRange(c1, 33, 65);

            BigInteger r = new BigInteger(1, c1X);
            BigInteger s = new BigInteger(1, c1Y);

            DerInteger x = new DerInteger(r);
            DerInteger y = new DerInteger(s);
            DerOctetString derDig = new DerOctetString(c3);
            DerOctetString derEnc = new DerOctetString(c2);

            Asn1EncodableVector vector = new Asn1EncodableVector();
            vector.Add(x);
            vector.Add(y);
            vector.Add(derDig);
            vector.Add(derEnc);

            DerSequence sequence = new DerSequence(vector);
            return sequence.GetEncoded("DER");
        }

        private static byte[] ConvertAsn1ToC1C3C2(byte[] asn1)
        {
            Asn1Sequence sequence = Asn1Sequence.GetInstance(asn1);

            BigInteger x = DerInteger.GetInstance(sequence[0]).Value;
            BigInteger y = DerInteger.GetInstance(sequence[1]).Value;

            byte[] c3 = Asn1OctetString.GetInstance(sequence[2]).GetOctets();
            byte[] c2 = Asn1OctetString.GetInstance(sequence[3]).GetOctets();
            ECPoint c1Point = SM2_ECX9_PARAMS.Curve.CreatePoint(x, y);
            byte[] c1 = c1Point.GetEncoded(false);

            return Arrays.ConcatenateAll(c1, c3, c2);
        }

        private static byte[] ConvertRsToAsn1(byte[] rs)
        {
            BigInteger r = new BigInteger(1, Arrays.CopyOfRange(rs, 0, SM2_RS_LENGTH));
            BigInteger s = new BigInteger(1, Arrays.CopyOfRange(rs, SM2_RS_LENGTH, SM2_RS_LENGTH * 2));

            Asn1EncodableVector vector = new Asn1EncodableVector();
            vector.Add(new DerInteger(r));
            vector.Add(new DerInteger(s));

            DerSequence sequence = new DerSequence(vector);
            return sequence.GetEncoded("DER");
        }

        private static byte[] ConvertAsn1ToRs(byte[] asn1)
        {
            Asn1Sequence sequence = Asn1Sequence.GetInstance(asn1);
            byte[] r = ConvertBigIntegerToFixedLengthByteArray(DerInteger.GetInstance(sequence[0]).Value);
            byte[] s = ConvertBigIntegerToFixedLengthByteArray(DerInteger.GetInstance(sequence[1]).Value);

            byte[] tmp = new byte[SM2_RS_LENGTH * 2];
            Buffer.BlockCopy(r, 0, tmp, 0, r.Length);
            Buffer.BlockCopy(s, 0, tmp, SM2_RS_LENGTH, s.Length);
            return tmp;
        }

        private static byte[] ConvertBigIntegerToFixedLengthByteArray(BigInteger bigInt)
        {
            // For SM2P256v1, N is 00fffffffeffffffffffffffffffffffff7203df6b21c6052b53bbf40939d54123,
            // R and S are the tmp of mod N, so they should be less than N and have length <= 32

            byte[] rs = bigInt.ToByteArray();
            if (rs.Length == SM2_RS_LENGTH)
            {
                return rs;
            }
            else if (rs.Length == SM2_RS_LENGTH + 1 && rs[0] == 0)
            {
                return Arrays.CopyOfRange(rs, 1, SM2_RS_LENGTH + 1);
            }
            else if (rs.Length < SM2_RS_LENGTH)
            {
                byte[] result = new byte[SM2_RS_LENGTH];
                Arrays.Fill(result, (byte)0);
                Buffer.BlockCopy(rs, 0, result, SM2_RS_LENGTH - rs.Length, rs.Length);
                return result;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        private static byte[] SignWithSM3(ECPrivateKeyParameters sm2PrivateKeyParams, byte[] uidBytes, byte[] msgBytes, bool asn1Encoding)
        {
            ISigner signer = SignerUtilities.GetSigner("SM3withSM2");
            signer.Init(true, new ParametersWithID(sm2PrivateKeyParams, uidBytes));
            signer.BlockUpdate(msgBytes, 0, msgBytes.Length);
            byte[] signBytes = signer.GenerateSignature();

            // BouncyCastle 库的签名结果默认 ASN.1 编码，如不需要需要手动转换
            if (!asn1Encoding)
            {
                signBytes = ConvertAsn1ToRs(signBytes);
            }

            return signBytes;
        }

        private static bool VerifyWithSM3(ECPublicKeyParameters sm2PublicKeyParams, byte[] uidBytes, byte[] msgBytes, byte[] signBytes, bool asn1Encoding)
        {
            ISigner signer = SignerUtilities.GetSigner("SM3withSM2");
            signer.Init(false, new ParametersWithID(sm2PublicKeyParams, uidBytes));
            signer.BlockUpdate(msgBytes, 0, msgBytes.Length);

            // BouncyCastle 库的签名结果默认 ASN.1 编码，如不需要需要手动转换
            if (!asn1Encoding)
            {
                signBytes = ConvertRsToAsn1(signBytes);
            }

            return signer.VerifySignature(signBytes);
        }

        private static byte[] Decrypt(ECPrivateKeyParameters sm2PrivateKeyParams, byte[] cipherBytes, bool asn1Encoding)
        {
            // BouncyCastle 库的加密结果默认非 ASN.1 编码，如有需要需要手动转换
            if (asn1Encoding)
            {
                cipherBytes = ConvertAsn1ToC1C3C2(cipherBytes);
            }

            // Java 版 BouncyCastle 库生成的密文，开头需补一个字节 0x04，才能在 .NET 版 BouncyCastle 库中解密
            if (cipherBytes.FirstOrDefault() != 0x04)
            {
                byte[] tmp = new byte[cipherBytes.Length + 1];
                Buffer.BlockCopy(cipherBytes, 0, tmp, 1, cipherBytes.Length);
                tmp[0] = 0x04;
                cipherBytes = tmp;
            }

            // BouncyCastle 库对 SM2 的加密结果为 C1|C2|C3，但国标要求为 C1|C3|C2
            // 此工具类仅支持国标（也是微信支付所要求的），所以先转换一次入参的密文数据
            cipherBytes = ConvertC1C3C2ToC1C2C3(cipherBytes);

            SM2Engine sm2Engine = new SM2Engine();
            sm2Engine.Init(false, sm2PrivateKeyParams);
            return sm2Engine.ProcessBlock(cipherBytes, 0, cipherBytes.Length);
        }

        private static byte[] Encrypt(ECPublicKeyParameters sm2PublicKeyParams, byte[] plainBytes, bool asn1Encoding)
        {
            SM2Engine sm2Engine = new SM2Engine();
            sm2Engine.Init(true, new ParametersWithRandom(sm2PublicKeyParams, new SecureRandom()));
            byte[] cipherBytes = sm2Engine.ProcessBlock(plainBytes, 0, plainBytes.Length);

            // BouncyCastle 库对 SM2 的加密结果为 C1|C2|C3，但国标 GM/T 0009-2012 要求为 C1|C3|C2
            // 此工具类仅支持国标（也是微信支付所要求的），所以先转换一次出参的密文数据
            cipherBytes = ConvertC1C2C3ToC1C3C2(cipherBytes);

            // BouncyCastle 库的加密结果默认非 ASN.1 编码，如有需要需要手动转换
            if (asn1Encoding)
            {
                cipherBytes = ConvertC1C3C2ToAsn1(cipherBytes);
            }

            // .NET 版 BouncyCastle 库生成的密文，开头需删一个字节 0x04，才能在 Java 版 BouncyCastle 库中解密
            if (cipherBytes.FirstOrDefault() == 0x04)
            {
                byte[] tmp = new byte[cipherBytes.Length - 1];
                Buffer.BlockCopy(cipherBytes, 1, tmp, 0, tmp.Length);
                cipherBytes = tmp;
            }

            return cipherBytes;
        }

        /// <summary>
        /// 使用私钥基于 SM3 算法生成签名。
        /// </summary>
        /// <param name="privateKeyBytes">PKCS#8 私钥字节数组。</param>
        /// <param name="uidBytes">用户标识符字节数组。</param>
        /// <param name="msgBytes">数据字节数组。</param>
        /// <param name="asn1Encoding">指示签名结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>签名字节数组。</returns>
        public static byte[] SignWithSM3(byte[] privateKeyBytes, byte[] uidBytes, byte[] msgBytes, bool asn1Encoding = true)
        {
            if (privateKeyBytes == null) throw new ArgumentNullException(nameof(privateKeyBytes));
            if (uidBytes == null) throw new ArgumentNullException(nameof(uidBytes));
            if (msgBytes == null) throw new ArgumentNullException(nameof(msgBytes));

            ECPrivateKeyParameters sm2PrivateKeyParams = ParsePrivateKeyPemToPrivateKeyParameters(privateKeyBytes);
            return SignWithSM3(sm2PrivateKeyParams, uidBytes, msgBytes, asn1Encoding);
        }

        /// <summary>
        /// 使用私钥基于 SM3 算法生成签名。
        /// </summary>
        /// <param name="privateKeyBytes">PKCS#8 私钥字节数组。</param>
        /// <param name="msgBytes">待签名的数据字节数组。</param>
        /// <param name="asn1Encoding">指示签名结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>签名字节数组。</returns>
        public static byte[] SignWithSM3(byte[] privateKeyBytes, byte[] msgBytes, bool asn1Encoding = true)
        {
            return SignWithSM3(
                privateKeyBytes: privateKeyBytes,
                uidBytes: SM2_DEFAULT_UID,
                msgBytes: msgBytes,
                asn1Encoding: asn1Encoding
            );
        }

        /// <summary>
        /// 使用私钥基于 SM3 算法生成签名。
        /// </summary>
        /// <param name="privateKey">PKCS#8 私钥（PEM 格式）。</param>
        /// <param name="message">待签名的文本数据。</param>
        /// <param name="asn1Encoding">指示签名结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>经 Base64 编码的签名。</returns>
        public static string SignWithSM3(string privateKey, string message, bool asn1Encoding = true)
        {
            if (privateKey == null) throw new ArgumentNullException(nameof(privateKey));
            if (message == null) throw new ArgumentNullException(nameof(message));

            byte[] signBytes = SignWithSM3(
                privateKeyBytes: ConvertPrivateKeyPkcs8PemToByteArray(privateKey),
                msgBytes: Encoding.UTF8.GetBytes(message),
                asn1Encoding: asn1Encoding
            );
            return Convert.ToBase64String(signBytes);
        }

        /// <summary>
        /// 使用 EC 十六进制私钥基于 SM3 算法生成签名。
        /// </summary>
        /// <param name="ecPrivateKeyBytes">EC 私钥字节数据。</param>
        /// <param name="uidBytes">用户标识符字节数组。</param>
        /// <param name="msgBytes">待签名的数据字节数组。</param>
        /// <param name="asn1Encoding">指示签名结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>签名字节数组。</returns>
        public static byte[] SignWithSM3ByECPrivateKey(byte[] ecPrivateKeyBytes, byte[] uidBytes, byte[] msgBytes, bool asn1Encoding = true)
        {
            if (ecPrivateKeyBytes == null) throw new ArgumentNullException(nameof(ecPrivateKeyBytes));
            if (uidBytes == null) throw new ArgumentNullException(nameof(uidBytes));
            if (msgBytes == null) throw new ArgumentNullException(nameof(msgBytes));

            return SignWithSM3ByECPrivateKey(
                ecPrivateKeyHex: Hex.ToHexString(ecPrivateKeyBytes),
                uidBytes: uidBytes,
                msgBytes: msgBytes,
                asn1Encoding: asn1Encoding
            );
        }

        /// <summary>
        /// 使用 EC 十六进制私钥基于 SM3 算法生成签名。
        /// </summary>
        /// <param name="ecPrivateKeyBytes">EC 私钥字节数据。</param>
        /// <param name="msgBytes">待签名的数据字节数组。</param>
        /// <param name="asn1Encoding">指示签名结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>签名字节数组。</returns>
        public static byte[] SignWithSM3ByECPrivateKey(byte[] ecPrivateKeyBytes, byte[] msgBytes, bool asn1Encoding = true)
        {
            return SignWithSM3ByECPrivateKey(
                ecPrivateKeyBytes: ecPrivateKeyBytes,
                uidBytes: SM2_DEFAULT_UID,
                msgBytes: msgBytes,
                asn1Encoding: asn1Encoding
            );
        }

        /// <summary>
        /// 使用 EC 十六进制私钥基于 SM3 算法生成签名。
        /// </summary>
        /// <param name="ecPrivateKeyHex">EC 私钥（十六进制格式）。</param>
        /// <param name="uidBytes">用户标识符字节数组。</param>
        /// <param name="msgBytes">待签名的数据字节数组。</param>
        /// <param name="asn1Encoding">指示签名结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>签名字节数组。</returns>
        public static byte[] SignWithSM3ByECPrivateKey(string ecPrivateKeyHex, byte[] uidBytes, byte[] msgBytes, bool asn1Encoding = true)
        {
            if (ecPrivateKeyHex == null) throw new ArgumentNullException(nameof(ecPrivateKeyHex));
            if (uidBytes == null) throw new ArgumentNullException(nameof(uidBytes));
            if (msgBytes == null) throw new ArgumentNullException(nameof(msgBytes));

            ECPrivateKeyParameters ecPrivateKeyParams = ParseECPrivateKeyToPrivateKeyParameters(ecPrivateKeyHex);
            return SignWithSM3(ecPrivateKeyParams, uidBytes, msgBytes, asn1Encoding);
        }

        /// <summary>
        /// 使用 EC 十六进制私钥基于 SM3 算法生成签名。
        /// </summary>
        /// <param name="ecPrivateKeyHex">EC 私钥（十六进制格式）。</param>
        /// <param name="msgBytes">待签名的数据字节数组。</param>
        /// <param name="asn1Encoding">指示签名结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>签名字节数组。</returns>
        public static byte[] SignWithSM3ByECPrivateKey(string ecPrivateKeyHex, byte[] msgBytes, bool asn1Encoding = true)
        {
            return SignWithSM3ByECPrivateKey(
                ecPrivateKeyHex: ecPrivateKeyHex,
                uidBytes: SM2_DEFAULT_UID,
                msgBytes: msgBytes,
                asn1Encoding: asn1Encoding
            );
        }

        /// <summary>
        /// 使用公钥基于 SM3 算法验证签名。
        /// </summary>
        /// <param name="publicKeyBytes">PKCS#8 公钥字节数据。</param>
        /// <param name="uidBytes">用户标识符字节数组。</param>
        /// <param name="msgBytes">待验证的数据字节数据。</param>
        /// <param name="signBytes">待验证的签名字节数据。</param>
        /// <param name="asn1Encoding">指示签名结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>验证结果。</returns>
        public static bool VerifyWithSM3(byte[] publicKeyBytes, byte[] uidBytes, byte[] msgBytes, byte[] signBytes, bool asn1Encoding = true)
        {
            if (publicKeyBytes == null) throw new ArgumentNullException(nameof(publicKeyBytes));
            if (uidBytes == null) throw new ArgumentNullException(nameof(uidBytes));
            if (msgBytes == null) throw new ArgumentNullException(nameof(msgBytes));
            if (signBytes == null) throw new ArgumentNullException(nameof(signBytes));

            ECPublicKeyParameters sm2PublicKeyParams = ParsePublicKeyPemToPublicKeyParameters(publicKeyBytes);
            return VerifyWithSM3(sm2PublicKeyParams, uidBytes, msgBytes, signBytes, asn1Encoding);
        }

        /// <summary>
        /// 使用公钥基于 SM3 算法验证签名。
        /// </summary>
        /// <param name="publicKeyBytes">PKCS#8 公钥字节数据。</param>
        /// <param name="msgBytes">待验证的数据字节数据。</param>
        /// <param name="signBytes">待验证的签名字节数据。</param>
        /// <param name="asn1Encoding">指示签名结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>验证结果。</returns>
        public static bool VerifyWithSM3(byte[] publicKeyBytes, byte[] msgBytes, byte[] signBytes, bool asn1Encoding = true)
        {
            return VerifyWithSM3(
                publicKeyBytes: publicKeyBytes,
                uidBytes: SM2_DEFAULT_UID,
                msgBytes: msgBytes,
                signBytes: signBytes,
                asn1Encoding: asn1Encoding
            );
        }

        /// <summary>
        /// 使用公钥基于 SM3 算法验证签名。
        /// </summary>
        /// <param name="publicKey">PKCS#8 公钥（PEM 格式）。</param>
        /// <param name="message">待验证的文本数据。</param>
        /// <param name="signature">经 Base64 编码的待验证的签名。</param>
        /// <param name="asn1Encoding">指示签名结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>验证结果。</returns>
        public static bool VerifyWithSM3(string publicKey, string message, string signature, bool asn1Encoding = true)
        {
            if (publicKey == null) throw new ArgumentNullException(nameof(publicKey));
            if (message == null) throw new ArgumentNullException(nameof(message));
            if (signature == null) throw new ArgumentNullException(nameof(signature));

            return VerifyWithSM3(
                publicKeyBytes: ConvertPublicKeyPkcs8PemToByteArray(publicKey),
                msgBytes: Encoding.UTF8.GetBytes(message),
                signBytes: Convert.FromBase64String(signature),
                asn1Encoding: asn1Encoding
            );
        }

        /// <summary>
        /// 使用证书基于 SM3 算法验证签名。
        /// </summary>
        /// <param name="certificate">证书（PEM 格式）。</param>
        /// <param name="message">待验证的文本数据。</param>
        /// <param name="signature">经 Base64 编码的待验证的签名。</param>
        /// <param name="asn1Encoding">指示签名结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>验证结果。</returns>
        public static bool VerifyWithSM3ByCertificate(string certificate, string message, string signature, bool asn1Encoding = true)
        {
            if (certificate == null) throw new ArgumentNullException(nameof(certificate));

            string publicKey = ExportPublicKeyFromCertificate(certificate);
            return VerifyWithSM3(
                publicKey: publicKey,
                message: message,
                signature: signature,
                asn1Encoding: asn1Encoding
            );
        }

        /// <summary>
        /// 使用 EC 十六进制公钥基于 SM3 算法生成签名。
        /// </summary>
        /// <param name="ecPublicKeyBytes">EC 公钥字节数据。</param>
        /// <param name="uidBytes">用户标识符字节数组。</param>
        /// <param name="msgBytes">待签名的数据字节数组。</param>
        /// <param name="signBytes">待验证的签名字节数据。</param>
        /// <param name="asn1Encoding">指示签名结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>签名字节数组。</returns>
        public static bool VerifyWithSM3ByECPublicKey(byte[] ecPublicKeyBytes, byte[] uidBytes, byte[] msgBytes, byte[] signBytes, bool asn1Encoding = true)
        {
            if (ecPublicKeyBytes == null) throw new ArgumentNullException(nameof(ecPublicKeyBytes));
            if (uidBytes == null) throw new ArgumentNullException(nameof(uidBytes));
            if (msgBytes == null) throw new ArgumentNullException(nameof(msgBytes));

            return VerifyWithSM3ByECPublicKey(
                ecPublicKeyHex: Hex.ToHexString(ecPublicKeyBytes),
                uidBytes: uidBytes,
                msgBytes: msgBytes,
                signBytes: signBytes,
                asn1Encoding: asn1Encoding
            );
        }

        /// <summary>
        /// 使用 EC 十六进制公钥基于 SM3 算法生成签名。
        /// </summary>
        /// <param name="ecPublicKeyBytes">EC 公钥字节数据。</param>
        /// <param name="msgBytes">待签名的数据字节数组。</param>
        /// <param name="signBytes">待验证的签名字节数据。</param>
        /// <param name="asn1Encoding">指示签名结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>签名字节数组。</returns>
        public static bool VerifyWithSM3ByECPublicKey(byte[] ecPublicKeyBytes, byte[] msgBytes, byte[] signBytes, bool asn1Encoding = true)
        {
            return VerifyWithSM3ByECPublicKey(
                ecPublicKeyBytes: ecPublicKeyBytes,
                uidBytes: SM2_DEFAULT_UID,
                msgBytes: msgBytes,
                signBytes: signBytes,
                asn1Encoding: asn1Encoding
            );
        }

        /// <summary>
        /// 使用 EC 十六进制公钥基于 SM3 算法生成签名。
        /// </summary>
        /// <param name="ecPublicKeyHex">EC 公钥（十六进制格式）。</param>
        /// <param name="uidBytes">用户标识符字节数组。</param>
        /// <param name="msgBytes">待签名的数据字节数组。</param>
        /// <param name="signBytes">待验证的签名字节数据。</param>
        /// <param name="asn1Encoding">指示签名结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>签名字节数组。</returns>
        public static bool VerifyWithSM3ByECPublicKey(string ecPublicKeyHex, byte[] uidBytes, byte[] msgBytes, byte[] signBytes, bool asn1Encoding = true)
        {
            if (ecPublicKeyHex == null) throw new ArgumentNullException(nameof(ecPublicKeyHex));
            if (uidBytes == null) throw new ArgumentNullException(nameof(uidBytes));
            if (msgBytes == null) throw new ArgumentNullException(nameof(msgBytes));

            ECPublicKeyParameters ecPublicKeyParams = ParseECPublicKeyToPublicKeyParameters(ecPublicKeyHex);
            return VerifyWithSM3(ecPublicKeyParams, uidBytes, msgBytes, signBytes, asn1Encoding);
        }

        /// <summary>
        /// 使用 EC 十六进制公钥基于 SM3 算法生成签名。
        /// </summary>
        /// <param name="ecPublicKeyHex">EC 公钥（十六进制格式）。</param>
        /// <param name="msgBytes">待签名的数据字节数组。</param>
        /// <param name="signBytes">待验证的签名字节数据。</param>
        /// <param name="asn1Encoding">指示签名结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>签名字节数组。</returns>
        public static bool VerifyWithSM3ByECPublicKey(string ecPublicKeyHex, byte[] msgBytes, byte[] signBytes, bool asn1Encoding = true)
        {
            return VerifyWithSM3ByECPublicKey(
                ecPublicKeyHex: ecPublicKeyHex,
                uidBytes: SM2_DEFAULT_UID,
                msgBytes: msgBytes,
                signBytes: signBytes,
                asn1Encoding: asn1Encoding
            );
        }

        /// <summary>
        /// 使用私钥解密数据。
        /// </summary>
        /// <param name="privateKeyBytes">PKCS#8 私钥字节数据。</param>
        /// <param name="cipherBytes">待解密的数据字节数据。</param>
        /// <param name="asn1Encoding">指示加密结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>解密后的数据字节数组。</returns>
        public static byte[] Decrypt(byte[] privateKeyBytes, byte[] cipherBytes, bool asn1Encoding = true)
        {
            if (privateKeyBytes == null) throw new ArgumentNullException(nameof(privateKeyBytes));
            if (cipherBytes == null) throw new ArgumentNullException(nameof(cipherBytes));

            ECPrivateKeyParameters sm2PrivateKeyParams = ParsePrivateKeyPemToPrivateKeyParameters(privateKeyBytes);
            return Decrypt(sm2PrivateKeyParams, cipherBytes, asn1Encoding);
        }

        /// <summary>
        /// 使用私钥解密数据。
        /// </summary>
        /// <param name="privateKey">PKCS#8 私钥（PEM 格式）。</param>
        /// <param name="cipherText">经 Base64 编码的待解密数据。</param>
        /// <param name="asn1Encoding">指示加密结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>解密后的文本数据。</returns>
        public static string Decrypt(string privateKey, string cipherText, bool asn1Encoding = true)
        {
            if (privateKey == null) throw new ArgumentNullException(nameof(privateKey));
            if (cipherText == null) throw new ArgumentNullException(nameof(cipherText));

            byte[] plainBytes = Decrypt(
                privateKeyBytes: ConvertPrivateKeyPkcs8PemToByteArray(privateKey),
                cipherBytes: Convert.FromBase64String(cipherText),
                asn1Encoding: asn1Encoding
            );
            return Encoding.UTF8.GetString(plainBytes);
        }

        /// <summary>
        /// 使用 EC 十六进制私钥解密数据。
        /// </summary>
        /// <param name="ecPrivateKeyBytes">EC 私钥字节数据。</param>
        /// <param name="cipherBytes">待解密的数据字节数据。</param>
        /// <param name="asn1Encoding">指示加密结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>解密后的数据字节数组。</returns>
        public static byte[] DecryptByECPrivateKey(byte[] ecPrivateKeyBytes, byte[] cipherBytes, bool asn1Encoding = true)
        {
            if (ecPrivateKeyBytes == null) throw new ArgumentNullException(nameof(ecPrivateKeyBytes));

            return DecryptByECPrivateKey(
                ecPrivateKeyHex: Hex.ToHexString(ecPrivateKeyBytes),
                cipherBytes: cipherBytes,
                asn1Encoding: asn1Encoding
            );
        }

        /// <summary>
        /// 使用 EC 十六进制私钥解密数据。
        /// </summary>
        /// <param name="ecPrivateKeyHex">EC 私钥（十六进制格式）。</param>
        /// <param name="cipherBytes">待解密的数据字节数据。</param>
        /// <param name="asn1Encoding">指示加密结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>解密后的文本数据。</returns>
        public static byte[] DecryptByECPrivateKey(string ecPrivateKeyHex, byte[] cipherBytes, bool asn1Encoding = true)
        {
            if (ecPrivateKeyHex == null) throw new ArgumentNullException(nameof(ecPrivateKeyHex));
            
            ECPrivateKeyParameters ecPrivateKeyParams = ParseECPrivateKeyToPrivateKeyParameters(ecPrivateKeyHex);
            return Decrypt(ecPrivateKeyParams, cipherBytes, asn1Encoding);
        }

        /// <summary>
        /// 使用公钥加密数据。
        /// </summary>
        /// <param name="publicKeyBytes">PKCS#8 公钥字节数据。</param>
        /// <param name="plainBytes">待加密的数据字节数据。</param>
        /// <param name="asn1Encoding">指示加密结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>加密后的数据字节数组。</returns>
        public static byte[] Encrypt(byte[] publicKeyBytes, byte[] plainBytes, bool asn1Encoding = true)
        {
            if (publicKeyBytes == null) throw new ArgumentNullException(nameof(publicKeyBytes));
            if (plainBytes == null) throw new ArgumentNullException(nameof(plainBytes));

            ECPublicKeyParameters sm2PublicKeyParams = ParsePublicKeyPemToPublicKeyParameters(publicKeyBytes);
            return Encrypt(sm2PublicKeyParams, plainBytes, asn1Encoding);
        }

        /// <summary>
        /// 使用公钥加密数据。
        /// </summary>
        /// <param name="publicKey">PKCS#8 公钥（PEM 格式）。</param>
        /// <param name="plainText">待加密的文本数据。</param>
        /// <param name="asn1Encoding">指示加密结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>经 Base64 编码的加密数据。</returns>
        public static string Encrypt(string publicKey, string plainText, bool asn1Encoding = true)
        {
            if (publicKey == null) throw new ArgumentNullException(nameof(publicKey));
            if (plainText == null) throw new ArgumentNullException(nameof(plainText));

            byte[] cipherBytes = Encrypt(
                publicKeyBytes: ConvertPublicKeyPkcs8PemToByteArray(publicKey),
                plainBytes: Encoding.UTF8.GetBytes(plainText),
                asn1Encoding: asn1Encoding
            );
            return Convert.ToBase64String(cipherBytes);
        }

        /// <summary>
        /// 使用证书加密数据。
        /// </summary>
        /// <param name="certificate">证书（PEM 格式）。</param>
        /// <param name="plainText">待加密的文本数据。</param>
        /// <param name="asn1Encoding">指示加密结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>经 Base64 编码的加密数据。</returns>
        public static string EncryptByCertificate(string certificate, string plainText, bool asn1Encoding = true)
        {
            if (certificate == null) throw new ArgumentNullException(nameof(certificate));

            return Encrypt(
                publicKey: ExportPublicKeyFromCertificate(certificate),
                plainText: plainText,
                asn1Encoding: asn1Encoding
            );
        }

        /// <summary>
        /// 使用 EC 十六进制公钥加密数据。
        /// </summary>
        /// <param name="ecPublicKeyBytes">EC 公钥字节数据。</param>
        /// <param name="plainBytes">待加密的数据字节数据。</param>
        /// <param name="asn1Encoding">指示加密结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>加密后的数据字节数组。</returns>
        public static byte[] EncryptByECPublicKey(byte[] ecPublicKeyBytes, byte[] plainBytes, bool asn1Encoding = true)
        {
            return EncryptByECPublicKey(
                ecPublicKeyHex: Hex.ToHexString(ecPublicKeyBytes),
                plainBytes: plainBytes,
                asn1Encoding: asn1Encoding
            );
        }

        /// <summary>
        /// 使用 EC 十六进制公钥加密数据。
        /// </summary>
        /// <param name="ecPublicKeyHex">EC 公钥（十六进制格式）。</param>
        /// <param name="plainBytes">待加密的数据字节数据。</param>
        /// <param name="asn1Encoding">指示加密结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>加密后的数据字节数组。</returns>
        public static byte[] EncryptByECPublicKey(string ecPublicKeyHex, byte[] plainBytes, bool asn1Encoding = true)
        {
            if (ecPublicKeyHex == null) throw new ArgumentNullException(nameof(ecPublicKeyHex));

            ECPublicKeyParameters ecPublicKeyParams = ParseECPublicKeyToPublicKeyParameters(ecPublicKeyHex);
            return Encrypt(ecPublicKeyParams, plainBytes, asn1Encoding);
        }

        /// <summary>
        /// <para>从 CRT/CER 证书中导出 PKCS#8 公钥。</para>
        /// <para>
        ///     即从 -----BEGIN CERTIFICATE----- ... -----END CERTIFICATE-----
        ///     转为 -----BEGIN PUBLIC KEY----- ..... -----END PUBLIC KEY-----
        /// </para>
        /// </summary>
        /// <param name="certificate">证书（PEM 格式）。</param>
        /// <returns>PKCS#8 公钥（PEM 格式）。</returns>
        public static string ExportPublicKeyFromCertificate(string certificate)
        {
            if (certificate == null) throw new ArgumentNullException(nameof(certificate));

            using (TextWriter swriter = new StringWriter())
            {
                X509Certificate x509cert = ConvertCertificatePemToX509(certificate);
                ECPublicKeyParameters exPublicKeyParams = (ECPublicKeyParameters)x509cert.GetPublicKey();
                PemWriter pemWriter = new PemWriter(swriter);
                pemWriter.WriteObject(exPublicKeyParams);
                pemWriter.Writer.Flush();
                return swriter.ToString()!;
            }
        }

        /// <summary>
        /// <para>从 CRT/CER 证书中导出证书序列号。</para>
        /// </summary>
        /// <param name="certificate">证书（PEM 格式）。</param>
        /// <returns>证书序列号。</returns>
        public static string ExportSerialNumberFromCertificate(string certificate)
        {
            if (certificate == null) throw new ArgumentNullException(nameof(certificate));

            X509Certificate x509cert = ConvertCertificatePemToX509(certificate);
            return x509cert.SerialNumber.ToString(16);
        }

        /// <summary>
        /// <para>从 CRT/CER 证书中导出证书颁发时间。</para>
        /// </summary>
        /// <param name="certificate">证书（PEM 格式）。</param>
        /// <returns>证书颁发时间。</returns>
        public static DateTimeOffset ExportEffectiveTimeFromCertificate(string certificate)
        {
            if (certificate == null) throw new ArgumentNullException(nameof(certificate));

            X509Certificate x509cert = ConvertCertificatePemToX509(certificate);
            return new DateTimeOffset(x509cert.NotBefore);
        }

        /// <summary>
        /// <para>从 CRT/CER 证书中导出证书过期时间。</para>
        /// </summary>
        /// <param name="certificate">证书（PEM 格式）。</param>
        /// <returns>证书过期时间。</returns>
        public static DateTimeOffset ExportExpireTimeFromCertificate(string certificate)
        {
            if (certificate == null) throw new ArgumentNullException(nameof(certificate));

            X509Certificate x509cert = ConvertCertificatePemToX509(certificate);
            return new DateTimeOffset(x509cert.NotAfter);
        }

        /// <summary>
        /// <para>从 CRT/CER 证书中导出 EC 的十六进制公钥。</para>
        /// <para>
        ///     即从 -----BEGIN CERTIFICATE----- ... -----END CERTIFICATE-----
        ///     转为 04+X|Y 结构的十六进制字符串。
        /// </para>
        /// </summary>
        /// <param name="certificate">证书（PEM 格式）。</param>
        /// <returns>EC 公钥（十六进制格式）。</returns>
        public static string ExportECPublicKeyFromCertificate(string certificate)
        {
            string publicKey = ExportPublicKeyFromCertificate(certificate);
            return ExportECPublicKeyFromPublicKey(publicKey);
        }

        /// <summary>
        /// <para>从 PKCS#8 公钥中导出 EC 的十六进制公钥。</para>
        /// <para>
        ///     即从 -----BEGIN PUBLIC KEY----- ... -----END PUBLIC KEY-----
        ///     转为 04+X|Y 结构的 130(128+2) 位的十六进制字符串。
        /// </para>
        /// </summary>
        /// <param name="publicKey">PKCS#8 公钥（PEM 格式）。</param>
        /// <returns>EC 公钥（十六进制格式）。</returns>
        public static string ExportECPublicKeyFromPublicKey(string publicKey)
        {
            byte[] publicKeyBytes = ConvertPublicKeyPkcs8PemToByteArray(publicKey);
            ECPublicKeyParameters sm2PublicKeyParams = ParsePublicKeyPemToPublicKeyParameters(publicKeyBytes);
            ECPoint ecPublicKeyPoint = sm2PublicKeyParams.Q;
            string ecPublicKeyX = ecPublicKeyPoint.XCoord.ToBigInteger().ToString(16);
            string ecPublicKeyY = ecPublicKeyPoint.YCoord.ToBigInteger().ToString(16);
            return string.Format("04{0}{1}", ecPublicKeyX, ecPublicKeyY);
        }

        /// <summary>
        /// <para>从 PKCS#8 私钥中导出 EC 的十六进制私钥。</para>
        /// <para>
        ///     即从 -----BEGIN PRIVATE KEY----- ... -----END PRIVATE KEY-----
        ///     转为 64 位的十六进制字符串。
        /// </para>
        /// </summary>
        /// <param name="privateKey">PKCS#8 私钥（PEM 格式）。</param>
        /// <returns>EC 私钥（十六进制格式）。</returns>
        public static string ExportECPrivateKeyFromPrivateKey(string privateKey)
        {
            ECPrivateKeyParameters sm2PrivateKeyParams = ParsePrivateKeyPemToPrivateKeyParameters(privateKey);
            return sm2PrivateKeyParams.D.ToString(16);
        }
    }
}
