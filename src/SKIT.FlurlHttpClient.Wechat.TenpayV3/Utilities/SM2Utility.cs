using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.GM;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Utilities
{
    using SKIT.FlurlHttpClient.Primitives;

    /// <summary>
    /// SM2 算法工具类。
    /// </summary>
    /// <remarks>
    /// 此实现遵循国家标准 GM/T 0009-2012 的有关规定。
    /// </remarks>
    public static class SM2Utility
    {
        private static readonly X9ECParameters SM2_ECX9_PARAMS = GMNamedCurves.GetByName("SM2P256v1");
        private static readonly ECDomainParameters SM2_DOMAIN_PARAMS = new ECDomainParameters(SM2_ECX9_PARAMS.Curve, SM2_ECX9_PARAMS.G, SM2_ECX9_PARAMS.N);
        private static readonly byte[] SM2_DEFAULT_UID = new byte[] { 0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x37, 0x38, 0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x37, 0x38 };
        private const int SM2_RS_SIZE = 32;

        private static ECPrivateKeyParameters ReadECPrivateKeyParams(byte[] ecPrivateKeyBytes)
        {
            BigInteger ecPrivateKeyParamsD = new BigInteger(1, ecPrivateKeyBytes);
            return new ECPrivateKeyParameters(ecPrivateKeyParamsD, SM2_DOMAIN_PARAMS);
        }

        private static ECPublicKeyParameters ReadECPublicKeyParams(byte[] ecPublicKeyBytes)
        {
            const int KEY_BYTE_SIZE = 64;
            const int COORDINATE_BYTE_SIZE = 32;

            bool unzipped = ecPublicKeyBytes[0] == 0x04;
            if (unzipped && ecPublicKeyBytes.Length != KEY_BYTE_SIZE + 1)
                throw new ArgumentException($"Invalid key byte size (expected: {KEY_BYTE_SIZE}, actual: {ecPublicKeyBytes.Length - 1}).", nameof(ecPublicKeyBytes));
            if (!unzipped && ecPublicKeyBytes.Length != KEY_BYTE_SIZE)
                throw new ArgumentException($"Invalid key byte size (expected: {KEY_BYTE_SIZE}, actual: {ecPublicKeyBytes.Length}).", nameof(ecPublicKeyBytes));

            int coordinateOffset = unzipped ? 1 : 0;
            BigInteger ecPublicKeyParamsX = new BigInteger(1, ecPublicKeyBytes, coordinateOffset, COORDINATE_BYTE_SIZE);
            BigInteger ecPublicKeyParamsY = new BigInteger(1, ecPublicKeyBytes, coordinateOffset + COORDINATE_BYTE_SIZE, COORDINATE_BYTE_SIZE);
            return new ECPublicKeyParameters(SM2_ECX9_PARAMS.Curve.CreatePoint(ecPublicKeyParamsX, ecPublicKeyParamsY), SM2_DOMAIN_PARAMS);
        }

        private static byte[] ConvertC1C3C2ToAsn1(byte[] c1c3c2)
        {
            const int SM2_COORDINATE_SIZE = 32;
            const int SM2_C1_X_OFFSET = 1;
            const int SM2_C1_Y_OFFSET = SM2_C1_X_OFFSET + SM2_COORDINATE_SIZE;
            const int SM2_C1_SIZE = SM2_C1_X_OFFSET + (2 * SM2_COORDINATE_SIZE);
            const int SM2_C3_SIZE = SM2_COORDINATE_SIZE;

            byte[] c3 = Arrays.CopyOfRange(c1c3c2, SM2_C1_SIZE, SM2_C1_SIZE + SM2_C3_SIZE);
            byte[] c2 = Arrays.CopyOfRange(c1c3c2, SM2_C1_SIZE + SM2_C3_SIZE, c1c3c2.Length);

            BigInteger r = new BigInteger(1, c1c3c2, SM2_C1_X_OFFSET, SM2_COORDINATE_SIZE);
            BigInteger s = new BigInteger(1, c1c3c2, SM2_C1_Y_OFFSET, SM2_COORDINATE_SIZE);

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
            BigInteger r;
            BigInteger s;
            if (rs.Length >= SM2_RS_SIZE * 2)
            {
                r = new BigInteger(1, rs, 0, SM2_RS_SIZE);
                s = new BigInteger(1, rs, SM2_RS_SIZE, SM2_RS_SIZE);
            }
            else
            {
                r = new BigInteger(1, Arrays.CopyOfRange(rs, 0, SM2_RS_SIZE));
                s = new BigInteger(1, Arrays.CopyOfRange(rs, SM2_RS_SIZE, SM2_RS_SIZE * 2));
            }

            Asn1EncodableVector vector = new Asn1EncodableVector();
            vector.Add(new DerInteger(r));
            vector.Add(new DerInteger(s));

            DerSequence sequence = new DerSequence(vector);
            return sequence.GetEncoded("DER");
        }

        private static byte[] ConvertAsn1ToRs(byte[] asn1)
        {
            Asn1Sequence sequence = Asn1Sequence.GetInstance(asn1);
            byte[] rs = new byte[SM2_RS_SIZE * 2];
            CopyBigIntegerToFixedLengthByteArray(DerInteger.GetInstance(sequence[0]).Value, rs, 0);
            CopyBigIntegerToFixedLengthByteArray(DerInteger.GetInstance(sequence[1]).Value, rs, SM2_RS_SIZE);
            return rs;
        }

        private static void CopyBigIntegerToFixedLengthByteArray(BigInteger bigInt, byte[] destinationBytes, int destinationOffset)
        {
            // For SM2P256v1, N is 00fffffffeffffffffffffffffffffffff7203df6b21c6052b53bbf40939d54123,
            // R and S are the tmp of mod N, so they should be less than N and have length <= 32

            byte[] bigIntBytes = bigInt.ToByteArray();
            int sourceOffset = bigIntBytes.Length == SM2_RS_SIZE + 1 && bigIntBytes[0] == 0 ? 1 : 0;
            int sourceLength = bigIntBytes.Length - sourceOffset;
            if (sourceLength > SM2_RS_SIZE)
                throw new ArgumentException();

            Buffer.BlockCopy(
                bigIntBytes,
                sourceOffset,
                destinationBytes,
                destinationOffset + SM2_RS_SIZE - sourceLength,
                sourceLength
            );
        }

        private static byte[] SignWithSM3(ECPrivateKeyParameters sm2PrivateKeyParams, byte[] uidBytes, byte[] messageBytes, bool asn1Encoding)
        {
            ISigner signer = SignerUtilities.GetSigner("SM3withSM2");
            signer.Init(true, new ParametersWithID(sm2PrivateKeyParams, uidBytes));
            signer.BlockUpdate(messageBytes, 0, messageBytes.Length);
            byte[] signBytes = signer.GenerateSignature();

            // BouncyCastle 库的签名结果默认 ASN.1 编码，如不需要需要手动转换
            if (!asn1Encoding)
            {
                signBytes = ConvertAsn1ToRs(signBytes);
            }

            return signBytes;
        }

        private static bool VerifyWithSM3(ECPublicKeyParameters sm2PublicKeyParams, byte[] uidBytes, byte[] messageBytes, byte[] signBytes, bool asn1Encoding)
        {
            ISigner signer = SignerUtilities.GetSigner("SM3withSM2");
            signer.Init(false, new ParametersWithID(sm2PublicKeyParams, uidBytes));
            signer.BlockUpdate(messageBytes, 0, messageBytes.Length);

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
            if (cipherBytes[0] != 0x04)
            {
                byte[] tmp = new byte[cipherBytes.Length + 1];
                Buffer.BlockCopy(cipherBytes, 0, tmp, 1, cipherBytes.Length);
                tmp[0] = 0x04;
                cipherBytes = tmp;
            }

            SM2Engine sm2Engine = new SM2Engine(SM2Engine.Mode.C1C3C2);
            sm2Engine.Init(false, sm2PrivateKeyParams);
            return sm2Engine.ProcessBlock(cipherBytes, 0, cipherBytes.Length);
        }

        private static byte[] Encrypt(ECPublicKeyParameters sm2PublicKeyParams, byte[] plainBytes, bool asn1Encoding)
        {
            SM2Engine sm2Engine = new SM2Engine(SM2Engine.Mode.C1C3C2);
            sm2Engine.Init(true, new ParametersWithRandom(sm2PublicKeyParams, new SecureRandom()));
            byte[] cipherBytes = sm2Engine.ProcessBlock(plainBytes, 0, plainBytes.Length);

            // BouncyCastle 库的加密结果默认非 ASN.1 编码，如有需要需要手动转换
            if (asn1Encoding)
            {
                cipherBytes = ConvertC1C3C2ToAsn1(cipherBytes);
            }

            // .NET 版 BouncyCastle 库生成的密文，开头需删一个字节 0x04，才能在 Java 版 BouncyCastle 库中解密
            if (cipherBytes[0] == 0x04)
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
        /// <param name="messageBytes">数据字节数组。</param>
        /// <param name="asn1Encoding">指示签名结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>签名字节数组。</returns>
        public static byte[] SignWithSM3(byte[] privateKeyBytes, byte[] uidBytes, byte[] messageBytes, bool asn1Encoding = true)
        {
            if (privateKeyBytes is null) throw new ArgumentNullException(nameof(privateKeyBytes));
            if (uidBytes is null) throw new ArgumentNullException(nameof(uidBytes));
            if (messageBytes is null) throw new ArgumentNullException(nameof(messageBytes));

            ECPrivateKeyParameters sm2PrivateKeyParams = (ECPrivateKeyParameters)PrivateKeyFactory.CreateKey(privateKeyBytes);
            return SignWithSM3(sm2PrivateKeyParams, uidBytes, messageBytes, asn1Encoding);
        }

        /// <summary>
        /// 使用私钥基于 SM3 算法生成签名。
        /// </summary>
        /// <param name="privateKeyBytes">PKCS#8 私钥字节数组。</param>
        /// <param name="messageBytes">待签名的数据字节数组。</param>
        /// <param name="asn1Encoding">指示签名结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>签名字节数组。</returns>
        public static byte[] SignWithSM3(byte[] privateKeyBytes, byte[] messageBytes, bool asn1Encoding = true)
        {
            return SignWithSM3(
                privateKeyBytes: privateKeyBytes,
                uidBytes: SM2_DEFAULT_UID,
                messageBytes: messageBytes,
                asn1Encoding: asn1Encoding
            );
        }

        /// <summary>
        /// 使用私钥基于 SM3 算法生成签名。
        /// </summary>
        /// <param name="privateKeyPem">PKCS#8 私钥。</param>
        /// <param name="messageData">待签名的数据。</param>
        /// <param name="asn1Encoding">指示签名结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>经过 Base64 编码的签名。</returns>
        public static EncodedString SignWithSM3(string privateKeyPem, string messageData, bool asn1Encoding = true)
        {
            if (privateKeyPem is null) throw new ArgumentNullException(nameof(privateKeyPem));
            if (messageData is null) throw new ArgumentNullException(nameof(messageData));

            byte[] signBytes = SignWithSM3(
                privateKeyBytes: Shared.Crypto.PemReader.ToBytes(privateKeyPem),
                messageBytes: EncodedString.FromLiteralString(messageData),
                asn1Encoding: asn1Encoding
            );
            return EncodedString.ToBase64String(signBytes);
        }

        /// <summary>
        /// 使用 EC 私钥基于 SM3 算法生成签名。
        /// </summary>
        /// <param name="ecPrivateKeyBytes">EC 私钥字节数组。</param>
        /// <param name="uidBytes">用户标识符字节数组。</param>
        /// <param name="messageBytes">待签名的数据字节数组。</param>
        /// <param name="asn1Encoding">指示签名结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>签名字节数组。</returns>
        public static byte[] SignWithSM3ByECPrivateKey(byte[] ecPrivateKeyBytes, byte[] uidBytes, byte[] messageBytes, bool asn1Encoding = true)
        {
            if (ecPrivateKeyBytes is null) throw new ArgumentNullException(nameof(ecPrivateKeyBytes));
            if (uidBytes is null) throw new ArgumentNullException(nameof(uidBytes));
            if (messageBytes is null) throw new ArgumentNullException(nameof(messageBytes));

            ECPrivateKeyParameters sm2PrivateKeyParams = ReadECPrivateKeyParams(ecPrivateKeyBytes);
            return SignWithSM3(sm2PrivateKeyParams, uidBytes, messageBytes, asn1Encoding);
        }

        /// <summary>
        /// 使用 EC 私钥基于 SM3 算法生成签名。
        /// </summary>
        /// <param name="ecPrivateKeyBytes">EC 私钥字节数组。</param>
        /// <param name="messageBytes">待签名的数据字节数组。</param>
        /// <param name="asn1Encoding">指示签名结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>签名字节数组。</returns>
        public static byte[] SignWithSM3ByECPrivateKey(byte[] ecPrivateKeyBytes, byte[] messageBytes, bool asn1Encoding = true)
        {
            return SignWithSM3ByECPrivateKey(
                ecPrivateKeyBytes: ecPrivateKeyBytes,
                uidBytes: SM2_DEFAULT_UID,
                messageBytes: messageBytes,
                asn1Encoding: asn1Encoding
            );
        }

        /// <summary>
        /// 使用 EC 私钥基于 SM3 算法生成签名。
        /// </summary>
        /// <param name="encodingECPrivateKey">经过编码后的（通常为十六进制）EC 私钥。</param>
        /// <param name="uidBytes">用户标识符字节数组。</param>
        /// <param name="messageBytes">待签名的数据字节数组。</param>
        /// <param name="asn1Encoding">指示签名结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>签名字节数组。</returns>
        public static byte[] SignWithSM3ByECPrivateKey(EncodedString encodingECPrivateKey, byte[] uidBytes, byte[] messageBytes, bool asn1Encoding = true)
        {
            if (encodingECPrivateKey.Value is null) throw new ArgumentNullException(nameof(encodingECPrivateKey));
            if (uidBytes is null) throw new ArgumentNullException(nameof(uidBytes));
            if (messageBytes is null) throw new ArgumentNullException(nameof(messageBytes));

            return SignWithSM3ByECPrivateKey(
                ecPrivateKeyBytes: EncodedString.FromString(encodingECPrivateKey, fallbackEncodingKind: EncodingKinds.Hex),
                uidBytes: uidBytes,
                messageBytes: messageBytes,
                asn1Encoding: asn1Encoding
            );
        }

        /// <summary>
        /// 使用 EC 私钥基于 SM3 算法生成签名。
        /// </summary>
        /// <param name="encodingECPrivateKey">经过编码后的（通常为十六进制）EC 私钥。</param>
        /// <param name="messageBytes">待签名的数据字节数组。</param>
        /// <param name="asn1Encoding">指示签名结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>签名字节数组。</returns>
        public static byte[] SignWithSM3ByECPrivateKey(EncodedString encodingECPrivateKey, byte[] messageBytes, bool asn1Encoding = true)
        {
            return SignWithSM3ByECPrivateKey(
                encodingECPrivateKey: encodingECPrivateKey,
                uidBytes: SM2_DEFAULT_UID,
                messageBytes: messageBytes,
                asn1Encoding: asn1Encoding
            );
        }

        /// <summary>
        /// 使用公钥基于 SM3 算法验证签名。
        /// </summary>
        /// <param name="publicKeyBytes">PKCS#8/SPKI 公钥字节数组。</param>
        /// <param name="uidBytes">用户标识符字节数组。</param>
        /// <param name="messageBytes">待验证的数据字节数组。</param>
        /// <param name="signBytes">签名字节数组。</param>
        /// <param name="asn1Encoding">指示签名结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>验证结果。</returns>
        public static bool VerifyWithSM3(byte[] publicKeyBytes, byte[] uidBytes, byte[] messageBytes, byte[] signBytes, bool asn1Encoding = true)
        {
            if (publicKeyBytes is null) throw new ArgumentNullException(nameof(publicKeyBytes));
            if (uidBytes is null) throw new ArgumentNullException(nameof(uidBytes));
            if (messageBytes is null) throw new ArgumentNullException(nameof(messageBytes));
            if (signBytes is null) throw new ArgumentNullException(nameof(signBytes));

            ECPublicKeyParameters sm2PublicKeyParams = (ECPublicKeyParameters)PublicKeyFactory.CreateKey(publicKeyBytes);
            return VerifyWithSM3(sm2PublicKeyParams, uidBytes, messageBytes, signBytes, asn1Encoding);
        }

        /// <summary>
        /// 使用公钥基于 SM3 算法验证签名。
        /// </summary>
        /// <param name="publicKeyBytes">PKCS#8/SPKI 公钥字节数组。</param>
        /// <param name="messageBytes">待验证的数据字节数组。</param>
        /// <param name="signBytes">签名字节数组。</param>
        /// <param name="asn1Encoding">指示签名结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>验证结果。</returns>
        public static bool VerifyWithSM3(byte[] publicKeyBytes, byte[] messageBytes, byte[] signBytes, bool asn1Encoding = true)
        {
            return VerifyWithSM3(
                publicKeyBytes: publicKeyBytes,
                uidBytes: SM2_DEFAULT_UID,
                messageBytes: messageBytes,
                signBytes: signBytes,
                asn1Encoding: asn1Encoding
            );
        }

        /// <summary>
        /// 使用公钥基于 SM3 算法验证签名。
        /// </summary>
        /// <param name="publicKeyPem">PKCS#8/SPKI 公钥。</param>
        /// <param name="messageData">待验证的数据。</param>
        /// <param name="encodingSignature">经过编码后的（通常为 Base64）签名。</param>
        /// <param name="asn1Encoding">指示签名结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>验证结果。</returns>
        public static bool VerifyWithSM3(string publicKeyPem, string messageData, EncodedString encodingSignature, bool asn1Encoding = true)
        {
            if (publicKeyPem is null) throw new ArgumentNullException(nameof(publicKeyPem));
            if (messageData is null) throw new ArgumentNullException(nameof(messageData));
            if (encodingSignature.Value is null) throw new ArgumentNullException(nameof(encodingSignature));

            return VerifyWithSM3(
                publicKeyBytes: Shared.Crypto.PemReader.ToBytes(publicKeyPem),
                messageBytes: EncodedString.FromLiteralString(messageData),
                signBytes: EncodedString.FromString(encodingSignature, fallbackEncodingKind: EncodingKinds.Base64),
                asn1Encoding: asn1Encoding
            );
        }

        /// <summary>
        /// 使用证书基于 SM3 算法验证签名。
        /// </summary>
        /// <param name="certificatePem">PEM 编码的证书。</param>
        /// <param name="messageData">待验证的数据。</param>
        /// <param name="encodingSignature">经过编码后的（通常为 Base64）签名。</param>
        /// <param name="asn1Encoding">指示签名结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>验证结果。</returns>
        public static bool VerifyWithSM3ByCertificate(string certificatePem, string messageData, EncodedString encodingSignature, bool asn1Encoding = true)
        {
            if (certificatePem is null) throw new ArgumentNullException(nameof(certificatePem));

            using var x509 = Shared.Crypto.X509Loader.Load(certificatePem);
            return VerifyWithSM3(
                publicKeyBytes: Shared.Crypto.X509Extensions.ExportSM2PublicKeyBytes(x509),
                messageBytes: EncodedString.FromLiteralString(messageData),
                signBytes: EncodedString.FromString(encodingSignature, fallbackEncodingKind: EncodingKinds.Base64),
                asn1Encoding: asn1Encoding
            );
        }

        /// <summary>
        /// 使用 EC 公钥基于 SM3 算法生成签名。
        /// </summary>
        /// <param name="ecPublicKeyBytes">EC 公钥字节数组。</param>
        /// <param name="uidBytes">用户标识符字节数组。</param>
        /// <param name="messageBytes">待验证的数据字节数组。</param>
        /// <param name="signBytes">签名字节数组。</param>
        /// <param name="asn1Encoding">指示签名结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>签名字节数组。</returns>
        public static bool VerifyWithSM3ByECPublicKey(byte[] ecPublicKeyBytes, byte[] uidBytes, byte[] messageBytes, byte[] signBytes, bool asn1Encoding = true)
        {
            if (ecPublicKeyBytes is null) throw new ArgumentNullException(nameof(ecPublicKeyBytes));
            if (uidBytes is null) throw new ArgumentNullException(nameof(uidBytes));
            if (messageBytes is null) throw new ArgumentNullException(nameof(messageBytes));

            ECPublicKeyParameters sm2PublicKeyParams = ReadECPublicKeyParams(ecPublicKeyBytes);
            return VerifyWithSM3(sm2PublicKeyParams, uidBytes, messageBytes, signBytes, asn1Encoding);
        }

        /// <summary>
        /// 使用 EC 公钥基于 SM3 算法生成签名。
        /// </summary>
        /// <param name="ecPublicKeyBytes">EC 公钥字节数组。</param>
        /// <param name="messageBytes">待验证的数据字节数组。</param>
        /// <param name="signBytes">签名字节数组。</param>
        /// <param name="asn1Encoding">指示签名结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>签名字节数组。</returns>
        public static bool VerifyWithSM3ByECPublicKey(byte[] ecPublicKeyBytes, byte[] messageBytes, byte[] signBytes, bool asn1Encoding = true)
        {
            return VerifyWithSM3ByECPublicKey(
                ecPublicKeyBytes: ecPublicKeyBytes,
                uidBytes: SM2_DEFAULT_UID,
                messageBytes: messageBytes,
                signBytes: signBytes,
                asn1Encoding: asn1Encoding
            );
        }

        /// <summary>
        /// 使用 EC 公钥基于 SM3 算法生成签名。
        /// </summary>
        /// <param name="encodingECPublicKey">经过编码后的（通常为十六进制）EC 公钥。</param>
        /// <param name="uidBytes">用户标识符字节数组。</param>
        /// <param name="messageBytes">待验证的数据字节数组。</param>
        /// <param name="signBytes">签名字节数组。</param>
        /// <param name="asn1Encoding">指示签名结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>签名字节数组。</returns>
        public static bool VerifyWithSM3ByECPublicKey(EncodedString encodingECPublicKey, byte[] uidBytes, byte[] messageBytes, byte[] signBytes, bool asn1Encoding = true)
        {
            if (encodingECPublicKey.Value is null) throw new ArgumentNullException(nameof(encodingECPublicKey));
            if (uidBytes is null) throw new ArgumentNullException(nameof(uidBytes));
            if (messageBytes is null) throw new ArgumentNullException(nameof(messageBytes));

            return VerifyWithSM3ByECPublicKey(
                ecPublicKeyBytes: EncodedString.FromString(encodingECPublicKey, fallbackEncodingKind: EncodingKinds.Hex),
                uidBytes: uidBytes,
                messageBytes: messageBytes,
                signBytes: signBytes,
                asn1Encoding: asn1Encoding
            );
        }

        /// <summary>
        /// 使用 EC 公钥基于 SM3 算法生成签名。
        /// </summary>
        /// <param name="encodingECPublicKey">经过编码后的（通常为十六进制）EC 公钥。</param>
        /// <param name="messageBytes">待验证的数据字节数组。</param>
        /// <param name="signBytes">签名字节数组。</param>
        /// <param name="asn1Encoding">指示签名结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>签名字节数组。</returns>
        public static bool VerifyWithSM3ByECPublicKey(EncodedString encodingECPublicKey, byte[] messageBytes, byte[] signBytes, bool asn1Encoding = true)
        {
            return VerifyWithSM3ByECPublicKey(
                encodingECPublicKey: encodingECPublicKey,
                uidBytes: SM2_DEFAULT_UID,
                messageBytes: messageBytes,
                signBytes: signBytes,
                asn1Encoding: asn1Encoding
            );
        }

        /// <summary>
        /// 使用私钥解密数据。
        /// </summary>
        /// <param name="privateKeyBytes">PKCS#8 私钥字节数组。</param>
        /// <param name="cipherBytes">待解密的数据字节数组。</param>
        /// <param name="asn1Encoding">指示加密结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>解密后的数据字节数组。</returns>
        public static byte[] Decrypt(byte[] privateKeyBytes, byte[] cipherBytes, bool asn1Encoding = true)
        {
            if (privateKeyBytes is null) throw new ArgumentNullException(nameof(privateKeyBytes));
            if (cipherBytes is null) throw new ArgumentNullException(nameof(cipherBytes));

            ECPrivateKeyParameters sm2PrivateKeyParams = (ECPrivateKeyParameters)PrivateKeyFactory.CreateKey(privateKeyBytes);
            return Decrypt(sm2PrivateKeyParams, cipherBytes, asn1Encoding);
        }

        /// <summary>
        /// 使用私钥解密数据。
        /// </summary>
        /// <param name="privateKeyPem">PKCS#8 私钥。</param>
        /// <param name="encodingCipher">经过编码后的（通常为 Base64）待解密数据。</param>
        /// <param name="asn1Encoding">指示加密结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>解密后的数据。</returns>
        public static EncodedString Decrypt(string privateKeyPem, EncodedString encodingCipher, bool asn1Encoding = true)
        {
            if (privateKeyPem is null) throw new ArgumentNullException(nameof(privateKeyPem));
            if (encodingCipher.Value is null) throw new ArgumentNullException(nameof(encodingCipher));

            byte[] plainBytes = Decrypt(
                privateKeyBytes: Shared.Crypto.PemReader.ToBytes(privateKeyPem),
                cipherBytes: EncodedString.FromString(encodingCipher, fallbackEncodingKind: EncodingKinds.Base64),
                asn1Encoding: asn1Encoding
            );
            return EncodedString.ToLiteralString(plainBytes);
        }

        /// <summary>
        /// 使用 EC 私钥解密数据。
        /// </summary>
        /// <param name="ecPrivateKeyBytes">EC 私钥字节数组。</param>
        /// <param name="cipherBytes">待解密的数据字节数组。</param>
        /// <param name="asn1Encoding">指示加密结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>解密后的数据字节数组。</returns>
        public static byte[] DecryptByECPrivateKey(byte[] ecPrivateKeyBytes, byte[] cipherBytes, bool asn1Encoding = true)
        {
            if (ecPrivateKeyBytes is null) throw new ArgumentNullException(nameof(ecPrivateKeyBytes));

            ECPrivateKeyParameters ecPrivateKeyParams = ReadECPrivateKeyParams(ecPrivateKeyBytes);
            return Decrypt(ecPrivateKeyParams, cipherBytes, asn1Encoding);
        }

        /// <summary>
        /// 使用 EC 私钥解密数据。
        /// </summary>
        /// <param name="encodingECPrivateKey">经过编码后的（通常为十六进制）EC 私钥。</param>
        /// <param name="cipherBytes">待解密的数据字节数组。</param>
        /// <param name="asn1Encoding">指示加密结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>解密后的数据。</returns>
        public static byte[] DecryptByECPrivateKey(EncodedString encodingECPrivateKey, byte[] cipherBytes, bool asn1Encoding = true)
        {
            if (encodingECPrivateKey.Value is null) throw new ArgumentNullException(nameof(encodingECPrivateKey));

            return DecryptByECPrivateKey(
                ecPrivateKeyBytes: EncodedString.FromString(encodingECPrivateKey, fallbackEncodingKind: EncodingKinds.Hex),
                cipherBytes: cipherBytes,
                asn1Encoding: asn1Encoding
            );
        }

        /// <summary>
        /// 使用公钥加密数据。
        /// </summary>
        /// <param name="publicKeyBytes">PKCS#8/SPKI 公钥字节数组。</param>
        /// <param name="plainBytes">待加密的数据字节数组。</param>
        /// <param name="asn1Encoding">指示加密结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>加密后的数据字节数组。</returns>
        public static byte[] Encrypt(byte[] publicKeyBytes, byte[] plainBytes, bool asn1Encoding = true)
        {
            if (publicKeyBytes is null) throw new ArgumentNullException(nameof(publicKeyBytes));
            if (plainBytes is null) throw new ArgumentNullException(nameof(plainBytes));

            ECPublicKeyParameters sm2PublicKeyParams = (ECPublicKeyParameters)PublicKeyFactory.CreateKey(publicKeyBytes);
            return Encrypt(sm2PublicKeyParams, plainBytes, asn1Encoding);
        }

        /// <summary>
        /// 使用公钥加密数据。
        /// </summary>
        /// <param name="publicKeyPem">PKCS#8/SPKI 公钥。</param>
        /// <param name="plainData">待加密的数据。</param>
        /// <param name="asn1Encoding">指示加密结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>经过 Base64 编码的加密数据。</returns>
        public static EncodedString Encrypt(string publicKeyPem, string plainData, bool asn1Encoding = true)
        {
            if (publicKeyPem is null) throw new ArgumentNullException(nameof(publicKeyPem));
            if (plainData is null) throw new ArgumentNullException(nameof(plainData));

            byte[] cipherBytes = Encrypt(
                publicKeyBytes: Shared.Crypto.PemReader.ToBytes(publicKeyPem),
                plainBytes: EncodedString.FromLiteralString(plainData),
                asn1Encoding: asn1Encoding
            );
            return EncodedString.ToBase64String(cipherBytes);
        }

        /// <summary>
        /// 使用证书加密数据。
        /// </summary>
        /// <param name="certificatePem">PEM 编码的证书。</param>
        /// <param name="plainData">待加密的数据。</param>
        /// <param name="asn1Encoding">指示加密结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>经过 Base64 编码的加密数据。</returns>
        public static EncodedString EncryptByCertificate(string certificatePem, string plainData, bool asn1Encoding = true)
        {
            if (certificatePem is null) throw new ArgumentNullException(nameof(certificatePem));

            using var x509 = Shared.Crypto.X509Loader.Load(certificatePem);
            byte[] cipherBytes = Encrypt(
                publicKeyBytes: Shared.Crypto.X509Extensions.ExportSM2PublicKeyBytes(x509),
                plainBytes: EncodedString.FromLiteralString(plainData),
                asn1Encoding: asn1Encoding
            );
            return EncodedString.ToBase64String(cipherBytes);
        }

        /// <summary>
        /// 使用 EC 公钥加密数据。
        /// </summary>
        /// <param name="ecPublicKeyBytes">EC 公钥字节数组。</param>
        /// <param name="plainBytes">待加密的数据字节数组。</param>
        /// <param name="asn1Encoding">指示加密结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>加密后的数据字节数组。</returns>
        public static byte[] EncryptByECPublicKey(byte[] ecPublicKeyBytes, byte[] plainBytes, bool asn1Encoding = true)
        {
            ECPublicKeyParameters ecPublicKeyParams = ReadECPublicKeyParams(ecPublicKeyBytes);
            return Encrypt(ecPublicKeyParams, plainBytes, asn1Encoding);
        }

        /// <summary>
        /// 使用 EC 公钥加密数据。
        /// </summary>
        /// <param name="encodingECPublicKey">经过编码后的（通常为十六进制）EC 公钥。</param>
        /// <param name="plainBytes">待加密的数据字节数组。</param>
        /// <param name="asn1Encoding">指示加密结果是否为 ASN.1 编码的形式。（默认值：true）</param>
        /// <returns>加密后的数据字节数组。</returns>
        public static byte[] EncryptByECPublicKey(EncodedString encodingECPublicKey, byte[] plainBytes, bool asn1Encoding = true)
        {
            if (encodingECPublicKey.Value is null) throw new ArgumentNullException(nameof(encodingECPublicKey));

            return EncryptByECPublicKey(
                ecPublicKeyBytes: EncodedString.FromString(encodingECPublicKey, fallbackEncodingKind: EncodingKinds.Hex),
                plainBytes: plainBytes,
                asn1Encoding: asn1Encoding
            );
        }

        /// <summary>
        /// <para>从 CRT/CER 证书中导出 PKCS#8/SPKI 公钥。</para>
        /// <para>即从 "-----BEGIN CERTIFICATE----- ... -----END CERTIFICATE-----" 转为 "-----BEGIN PUBLIC KEY----- ..... -----END PUBLIC KEY-----"。</para>
        /// </summary>
        /// <param name="certificate">PEM 编码的证书。</param>
        /// <returns>PKCS#8/SPKI 公钥。</returns>
        public static string ExportPublicKeyFromCertificate(string certificate)
        {
            if (certificate is null) throw new ArgumentNullException(nameof(certificate));

            using var x509 = Shared.Crypto.X509Loader.Load(certificate);
            byte[] publicKeyBytes = Shared.Crypto.X509Extensions.ExportSM2PublicKeyBytes(x509);
            return Shared.Crypto.PemWriter.ToString("PUBLIC KEY", publicKeyBytes, true);
        }

        /// <summary>
        /// <para>从 CRT/CER 证书中导出证书序列号。</para>
        /// </summary>
        /// <param name="certificate">PEM 编码的证书。</param>
        /// <returns>证书序列号。</returns>
        public static string ExportSerialNumberFromCertificate(string certificate)
        {
            if (certificate is null) throw new ArgumentNullException(nameof(certificate));

            using var x509 = Shared.Crypto.X509Loader.Load(certificate);
            return x509.SerialNumber.TrimStart('0');
        }

        /// <summary>
        /// <para>从 CRT/CER 证书中导出证书有效期的开始时间。</para>
        /// </summary>
        /// <param name="certificate">PEM 编码的证书。</param>
        /// <returns>证书有效期的开始时间。</returns>
        public static DateTimeOffset ExportValidFromDateFromCertificate(string certificate)
        {
            if (certificate is null) throw new ArgumentNullException(nameof(certificate));

            using var x509 = Shared.Crypto.X509Loader.Load(certificate);
            return new DateTimeOffset(x509.NotBefore);
        }

        /// <summary>
        /// <para>从 CRT/CER 证书中导出证书有效期的结束时间。</para>
        /// </summary>
        /// <param name="certificate">PEM 编码的证书。</param>
        /// <returns>证书有效期的结束时间。</returns>
        public static DateTimeOffset ExportValidToDateFromCertificate(string certificate)
        {
            if (certificate is null) throw new ArgumentNullException(nameof(certificate));

            using var x509 = Shared.Crypto.X509Loader.Load(certificate);
            return new DateTimeOffset(x509.NotAfter);
        }

        /// <summary>
        /// <para>从 CRT/CER 证书中导出 EC 公钥。</para>
        /// <para>即从 "-----BEGIN CERTIFICATE----- ... -----END CERTIFICATE-----" 转为 04+X|Y 结构的 130(128+2) 位十六进制字符串。</para>
        /// </summary>
        /// <param name="certificate">PEM 编码的证书。</param>
        /// <returns>EC 公钥（十六进制格式）。</returns>
        public static string ExportECPublicKeyFromCertificate(string certificate)
        {
            string publicKeyPem = ExportPublicKeyFromCertificate(certificate);
            return ExportECPublicKeyFromPublicKey(publicKeyPem);
        }

        /// <summary>
        /// <para>从 PKCS#8/SPKI 公钥中导出 EC 公钥。</para>
        /// <para>即从 "-----BEGIN PUBLIC KEY----- ... -----END PUBLIC KEY-----" 转为 04+X|Y 结构的 130(128+2) 位十六进制字符串。</para>
        /// </summary>
        /// <param name="publicKey">PKCS#8/SPKI 公钥。</param>
        /// <returns>EC 公钥（十六进制格式）。</returns>
        public static string ExportECPublicKeyFromPublicKey(string publicKey)
        {
            byte[] publicKeyBytes = Shared.Crypto.PemReader.ToBytes(publicKey);
            ECPublicKeyParameters sm2PublicKeyParams = (ECPublicKeyParameters)PublicKeyFactory.CreateKey(publicKeyBytes);
            ECPoint ecPublicKeyPoint = sm2PublicKeyParams.Q;
            string ecPublicKeyX = ecPublicKeyPoint.XCoord.ToBigInteger().ToString(16);
            string ecPublicKeyY = ecPublicKeyPoint.YCoord.ToBigInteger().ToString(16);
            return string.Format("04{0}{1}", ecPublicKeyX, ecPublicKeyY);
        }

        /// <summary>
        /// <para>从 PKCS#8 私钥中导出 EC 私钥。</para>
        /// <para>即从 "-----BEGIN PRIVATE KEY----- ... -----END PRIVATE KEY-----" 转为 64 位十六进制字符串。</para>
        /// </summary>
        /// <param name="privateKey">PKCS#8 私钥。</param>
        /// <returns>EC 私钥（十六进制格式）。</returns>
        public static string ExportECPrivateKeyFromPrivateKey(string privateKey)
        {
            byte[] privateKeyBytes = Shared.Crypto.PemReader.ToBytes(privateKey);
            ECPrivateKeyParameters sm2PrivateKeyParams = (ECPrivateKeyParameters)PrivateKeyFactory.CreateKey(privateKeyBytes);
            return sm2PrivateKeyParams.D.ToString(16);
        }
    }
}
