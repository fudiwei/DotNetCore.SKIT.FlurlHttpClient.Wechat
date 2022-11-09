using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Utilities
{
    /// <summary>
    /// SM2 算法工具类。
    /// </summary>
    public static partial class SM2Utility
    {
        // 默认用户身份标识：1234567812345678
        private static readonly byte[] DEFAULT_USERID_BYTES = new byte[] { 0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x37, 0x38, 0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x37, 0x38 };

        private static byte[] ConvertPkcs8PrivateKeyToByteArray(string privateKey)
        {
            privateKey = privateKey
                .Replace("-----BEGIN PRIVATE KEY-----", string.Empty)
                .Replace("-----END PRIVATE KEY-----", string.Empty);
            privateKey = Regex.Replace(privateKey, "\\s+", string.Empty);
            return Convert.FromBase64String(privateKey);
        }

        private static byte[] ConvertPkcs8PublicKeyToByteArray(string publicKey)
        {
            publicKey = publicKey
                .Replace("-----BEGIN PUBLIC KEY-----", string.Empty)
                .Replace("-----END PUBLIC KEY-----", string.Empty);
            publicKey = Regex.Replace(publicKey, "\\s+", string.Empty);
            return Convert.FromBase64String(publicKey);
        }

        private static X509Certificate ParseX509Certificate(string certificate)
        {
            using (TextReader sreader = new StringReader(certificate))
            {
                PemReader pemReader = new PemReader(sreader);
                return (X509Certificate)pemReader.ReadObject();
            }
        }

        private static ECPublicKeyParameters ConvertCertificateToPublicKeyParams(string certificate)
        {
            X509Certificate cert = ParseX509Certificate(certificate);
            return (ECPublicKeyParameters)cert.GetPublicKey();
        }

        private static byte[] SignWithSM3(ECPrivateKeyParameters ecPrivateKeyParams, byte[] userIdBytes, byte[] plainBytes)
        {
            ISigner signer = new SM2Signer(new SM3Digest());
            ICipherParameters idParams = new ParametersWithID(new ParametersWithRandom(ecPrivateKeyParams), userIdBytes);
            signer.Init(true, idParams);
            signer.BlockUpdate(plainBytes, 0, plainBytes.Length);
            return signer.GenerateSignature();
        }

        private static bool VerifyWithSM3(ECPublicKeyParameters ecPublicKeyParams, byte[] userIdBytes, byte[] plainBytes, byte[] signBytes)
        {
            ISigner signer = new SM2Signer(new SM3Digest());
            ICipherParameters idParams = new ParametersWithID(new ParametersWithRandom(ecPublicKeyParams), userIdBytes);
            signer.Init(false, idParams);
            signer.BlockUpdate(plainBytes, 0, plainBytes.Length);
            return signer.VerifySignature(signBytes);
        }

        /// <summary>
        /// 使用私钥基于 SM3 算法生成签名。
        /// </summary>
        /// <param name="privateKeyBytes">PKCS#8 私钥字节数组。</param>
        /// <param name="plainBytes">待签名的数据字节数组。</param>
        /// <returns>签名字节数组。</returns>
        public static byte[] SignWithSM3(byte[] privateKeyBytes, byte[] plainBytes)
        {
            return SignWithSM3(
                privateKeyBytes: privateKeyBytes,
                userIdBytes: DEFAULT_USERID_BYTES,
                plainBytes: plainBytes
            );
        }

        /// <summary>
        /// 使用私钥基于 SM3 算法生成签名。
        /// </summary>
        /// <param name="privateKeyBytes">PKCS#8 私钥字节数组。</param>
        /// <param name="userIdBytes">用户身份标识字节数组。</param>
        /// <param name="plainBytes">待签名的数据字节数组。</param>
        /// <returns>签名字节数组。</returns>
        public static byte[] SignWithSM3(byte[] privateKeyBytes, byte[] userIdBytes, byte[] plainBytes)
        {
            if (privateKeyBytes == null) throw new ArgumentNullException(nameof(privateKeyBytes));
            if (userIdBytes == null) throw new ArgumentNullException(nameof(userIdBytes));
            if (plainBytes == null) throw new ArgumentNullException(nameof(plainBytes));

            //ECPrivateKeyParameters ecKeyParams = (ECPrivateKeyParameters)PrivateKeyFactory.CreateKey(privateKeyBytes);
            //return SignWithSM3(ecKeyParams, userIdBytes, plainBytes);

            BigInteger userD = new BigInteger(1, privateKeyBytes);
            SM2Factory sm2Factory = new SM2Factory();

            ECPoint userKey = sm2Factory.ecc_point_g.Multiply(userD);
            SM3Digest sm3Digest = new SM3Digest();
            var z = sm2Factory.Sm2GetZ(userIdBytes, userKey);
            sm3Digest.BlockUpdate(z, 0, z.Length);
            sm3Digest.BlockUpdate(plainBytes, 0, plainBytes.Length);
            var md = new byte[32];
            sm3Digest.DoFinal(md, 0);

            var result = sm2Factory.Sm2Sign(md, userD, userKey);
            return result.ToByteArray();
        }

        /// <summary>
        /// 使用私钥基于 SM3 算法生成签名。
        /// </summary>
        /// <param name="privateKey">PKCS#8 私钥（PEM 格式）。</param>
        /// <param name="plainText">待签名的文本数据。</param>
        /// <returns>经 Base64 编码的签名。</returns>
        public static string SignWithSM3(string privateKey, string plainText)
        {
            if (privateKey == null) throw new ArgumentNullException(nameof(privateKey));
            if (plainText == null) throw new ArgumentNullException(nameof(plainText));

            byte[] privateKeyBytes = ConvertPkcs8PrivateKeyToByteArray(privateKey);
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
            byte[] signBytes = SignWithSM3(privateKeyBytes, plainBytes);
            return Convert.ToBase64String(signBytes);
        }

        /// <summary>
        /// 使用公钥基于 SM3 算法验证签名。
        /// </summary>
        /// <param name="publicKeyBytes">PKCS#8 公钥字节数据。</param>
        /// <param name="plainBytes">待验证的数据字节数据。</param>
        /// <param name="signBytes">待验证的签名字节数据。</param>
        /// <returns>验证结果。</returns>
        public static bool VerifyWithSM3(byte[] publicKeyBytes, byte[] plainBytes, byte[] signBytes)
        {
            return VerifyWithSM3(
                publicKeyBytes: publicKeyBytes,
                userIdBytes: DEFAULT_USERID_BYTES,
                plainBytes: plainBytes,
                signBytes: signBytes
            );
        }

        /// <summary>
        /// 使用公钥基于 SM3 算法验证签名。
        /// </summary>
        /// <param name="publicKeyBytes">PKCS#8 公钥字节数据。</param>
        /// <param name="userIdBytes">用户身份标识字节数组。</param>
        /// <param name="plainBytes">待验证的数据字节数据。</param>
        /// <param name="signBytes">待验证的签名字节数据。</param>
        /// <returns>验证结果。</returns>
        public static bool VerifyWithSM3(byte[] publicKeyBytes, byte[] userIdBytes, byte[] plainBytes, byte[] signBytes)
        {
            if (publicKeyBytes == null) throw new ArgumentNullException(nameof(publicKeyBytes));
            if (userIdBytes == null) throw new ArgumentNullException(nameof(userIdBytes));
            if (plainBytes == null) throw new ArgumentNullException(nameof(plainBytes));
            if (signBytes == null) throw new ArgumentNullException(nameof(signBytes));

            ECPublicKeyParameters ecPublicKeyParams = (ECPublicKeyParameters)PublicKeyFactory.CreateKey(publicKeyBytes);
            return VerifyWithSM3(ecPublicKeyParams, userIdBytes, plainBytes, signBytes);
        }

        /// <summary>
        /// 使用公钥基于 SM3 算法验证签名。
        /// </summary>
        /// <param name="publicKey">PKCS#8 公钥（PEM 格式）。</param>
        /// <param name="plainText">待验证的文本数据。</param>
        /// <param name="signature">经 Base64 编码的待验证的签名。</param>
        /// <returns>验证结果。</returns>
        public static bool VerifyWithSM3(string publicKey, string plainText, string signature)
        {
            if (publicKey == null) throw new ArgumentNullException(nameof(publicKey));
            if (plainText == null) throw new ArgumentNullException(nameof(plainText));
            if (signature == null) throw new ArgumentNullException(nameof(signature));

            byte[] publicKeyBytes = ConvertPkcs8PublicKeyToByteArray(publicKey);
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
            byte[] signBytes = Convert.FromBase64String(signature);
            return VerifyWithSM3(publicKeyBytes, plainBytes, signBytes);
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
        public static string ExportPublicKey(string certificate)
        {
            if (certificate == null) throw new ArgumentNullException(nameof(certificate));

            using (TextWriter swriter = new StringWriter())
            {
                ECKeyParameters ecKeyParams = ConvertCertificateToPublicKeyParams(certificate);
                PemWriter pemWriter = new PemWriter(swriter);
                pemWriter.WriteObject(ecKeyParams);
                pemWriter.Writer.Flush();
                return swriter.ToString()!;
            }
        }

        /// <summary>
        /// <para>从 CRT/CER 证书中导出证书序列号。</para>
        /// </summary>
        /// <param name="certificate">证书（PEM 格式）。</param>
        /// <returns>证书序列号。</returns>
        public static string ExportSerialNumber(string certificate)
        {
            if (certificate == null) throw new ArgumentNullException(nameof(certificate));

            X509Certificate cert = ParseX509Certificate(certificate);
            return cert.SerialNumber.ToString(16);
        }

        /// <summary>
        /// <para>从 CRT/CER 证书中导出证书颁发时间。</para>
        /// </summary>
        /// <param name="certificate">证书（PEM 格式）。</param>
        /// <returns>证书颁发时间。</returns>
        public static DateTimeOffset ExportEffectiveTime(string certificate)
        {
            if (certificate == null) throw new ArgumentNullException(nameof(certificate));

            X509Certificate cert = ParseX509Certificate(certificate);
            return new DateTimeOffset(cert.NotBefore);
        }

        /// <summary>
        /// <para>从 CRT/CER 证书中导出证书过期时间。</para>
        /// </summary>
        /// <param name="certificate">证书（PEM 格式）。</param>
        /// <returns>证书过期时间。</returns>
        public static DateTimeOffset ExportExpireTime(string certificate)
        {
            if (certificate == null) throw new ArgumentNullException(nameof(certificate));

            X509Certificate cert = ParseX509Certificate(certificate);
            return new DateTimeOffset(cert.NotAfter);
        }
    }

    partial class SM2Utility
    {
        internal sealed class Cipher
        {
            private int ct = 1;

            private ECPoint? p2;
            private SM3Digest? sm3keybase;
            private SM3Digest? sm3c3;

            private byte[] key = new byte[32];
            private byte keyOff = 0;

            private void Reset()
            {
                sm3keybase = new SM3Digest();
                sm3c3 = new SM3Digest();


                byte[] p;


                p = p2.Normalize().XCoord.ToBigInteger().ToByteArray32();

                sm3keybase.BlockUpdate(p, 0, p.Length);
                sm3c3.BlockUpdate(p, 0, p.Length);


                p = p2.Normalize().YCoord.ToBigInteger().ToByteArray32();

                sm3keybase.BlockUpdate(p, 0, p.Length);


                ct = 1;
                NextKey();
            }

            private void NextKey()
            {

                SM3Digest sm3keycur = new SM3Digest(sm3keybase);
                sm3keycur.Update((byte)(ct >> 24 & 0xff));
                sm3keycur.Update((byte)(ct >> 16 & 0xff));
                sm3keycur.Update((byte)(ct >> 8 & 0xff));
                sm3keycur.Update((byte)(ct & 0xff));
                sm3keycur.DoFinal(key, 0);
                var testKey = HexUtility.ConvertBytesToHex(key);

                keyOff = 0;
                ct++;
            }

            public ECPoint Init_enc(SM2Factory sm2, ECPoint userKey)
            {
                BigInteger k = null;
                ECPoint c1 = null;


                AsymmetricCipherKeyPair key = sm2.ecc_key_pair_generator.GenerateKeyPair();
                ECPrivateKeyParameters ecpriv = (ECPrivateKeyParameters)key.Private;
                ECPublicKeyParameters ecpub = (ECPublicKeyParameters)key.Public;
                k = ecpriv.D;
                c1 = ecpub.Q;


                p2 = userKey.Multiply(k);
                Reset();


                return c1;
            }

            public void Encrypt(byte[] data)
            {
                sm3c3.BlockUpdate(data, 0, data.Length);
                for (int i = 0; i < data.Length; i++)
                {
                    if (keyOff == key.Length)
                        NextKey();


                    data[i] ^= key[keyOff++];
                }
            }

            public void Init_dec(BigInteger userD, ECPoint c1)
            {
                p2 = c1.Multiply(userD);
                Reset();
            }

            public void Decrypt(byte[] data)
            {

                for (int i = 0; i < data.Length; i++)
                {
                    if (keyOff == key.Length)
                        NextKey();


                    data[i] ^= key[keyOff++];
                }
                sm3c3.BlockUpdate(data, 0, data.Length);
            }

            public void Dofinal(byte[] c3)
            {
                byte[] p = p2.Normalize().YCoord.ToBigInteger().ToByteArray32();
                sm3c3.BlockUpdate(p, 0, p.Length);
                sm3c3.DoFinal(c3, 0);
                Reset();
            }
        }

        internal sealed class SM2Factory
        {
            public static readonly string[] SM2_PARAMS = {
                "FFFFFFFEFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF00000000FFFFFFFFFFFFFFFF", // p,0
                "FFFFFFFEFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF00000000FFFFFFFFFFFFFFFC", // a,1
                "28E9FA9E9D9F5E344D5A9E4BCF6509A7F39789F515AB8F92DDBCBD414D940E93", // b,2
                "FFFFFFFEFFFFFFFFFFFFFFFFFFFFFFFF7203DF6B21C6052B53BBF40939D54123", // n,3
                "32C4AE2C1F1981195F9904466A39C9948FE30BBFF2660BE1715A4589334C74C7", // gx,4
                "BC3736A2F4F6779C59BDCEE36B692153D0A9877CC62A474002DF32E52139F0A0"  // gy,5
            };

            public string[] ecc_param = SM2_PARAMS;

            public readonly BigInteger ecc_p;
            public readonly BigInteger ecc_a;
            public readonly BigInteger ecc_b;
            public readonly BigInteger ecc_n;
            public readonly BigInteger ecc_gx;
            public readonly BigInteger ecc_gy;

            public readonly ECCurve ecc_curve;
            public readonly ECPoint ecc_point_g;

            public readonly ECDomainParameters ecc_bc_spec;

            public readonly ECKeyPairGenerator ecc_key_pair_generator;

            public SM2Factory()
            {
                ecc_param = SM2_PARAMS;

                ECFieldElement ecc_gx_fieldelement;
                ECFieldElement ecc_gy_fieldelement;

                ecc_p = new BigInteger(ecc_param[0], 16);
                ecc_a = new BigInteger(ecc_param[1], 16);
                ecc_b = new BigInteger(ecc_param[2], 16);
                ecc_n = new BigInteger(ecc_param[3], 16);
                ecc_gx = new BigInteger(ecc_param[4], 16);
                ecc_gy = new BigInteger(ecc_param[5], 16);


                ecc_gx_fieldelement = new FpFieldElement(ecc_p, ecc_gx);
                ecc_gy_fieldelement = new FpFieldElement(ecc_p, ecc_gy);

                ecc_curve = new FpCurve(ecc_p, ecc_a, ecc_b);
                ecc_point_g = new FpPoint(ecc_curve, ecc_gx_fieldelement, ecc_gy_fieldelement);

                ecc_bc_spec = new ECDomainParameters(ecc_curve, ecc_point_g, ecc_n);

                ECKeyGenerationParameters ecc_ecgenparam;
                ecc_ecgenparam = new ECKeyGenerationParameters(ecc_bc_spec, new SecureRandom());

                ecc_key_pair_generator = new ECKeyPairGenerator();
                ecc_key_pair_generator.Init(ecc_ecgenparam);
            }

            public SM2Signature Sm2Sign(byte[] md, BigInteger userD, ECPoint userKey)
            {
                BigInteger e = new BigInteger(1, md);
                BigInteger k = null;
                ECPoint kp = null;
                BigInteger r = null;
                BigInteger s = null;
                do
                {
                    do
                    {
                        // 正式环境
                        AsymmetricCipherKeyPair keypair = ecc_key_pair_generator.GenerateKeyPair();
                        ECPrivateKeyParameters ecpriv = (ECPrivateKeyParameters)keypair.Private;
                        ECPublicKeyParameters ecpub = (ECPublicKeyParameters)keypair.Public;
                        k = ecpriv.D;
                        kp = ecpub.Q;
                        //System.out.println("BigInteger:" + k + "\nECPoint:" + kp);

                        //System.out.println("计算曲线点X1: "+ kp.getXCoord().toBigInteger().toString(16));
                        //System.out.println("计算曲线点Y1: "+ kp.getYCoord().toBigInteger().toString(16));
                        //System.out.println("");
                        // r
                        r = e.Add(kp.XCoord.ToBigInteger());
                        r = r.Mod(this.ecc_n);
                    } while (r.Equals(BigInteger.Zero) || r.Add(k).Equals(this.ecc_n) || r.ToString(16).Length != 64);

                    // (1 + dA)~-1
                    BigInteger da_1 = userD.Add(BigInteger.One);
                    da_1 = da_1.ModInverse(this.ecc_n);
                    // s
                    s = r.Multiply(userD);
                    s = k.Subtract(s).Mod(this.ecc_n);
                    s = da_1.Multiply(s).Mod(this.ecc_n);
                } while (s.Equals(BigInteger.Zero) || s.ToString(16).Length != 64);
                var sM2Signature = new SM2Signature
                {
                    R = r.ToByteArray32(),
                    S = s.ToByteArray32()
                };
                return sM2Signature;
            }

            public SM2Result Sm2Verify(byte[] md, ECPoint userKey, BigInteger r, BigInteger s)
            {
                var sm2Result = new SM2Result();

                BigInteger e = new BigInteger(1, md);
                BigInteger t = r.Add(s).Mod(this.ecc_n);
                if (t.Equals(BigInteger.Zero))
                {
                    return sm2Result;
                }
                else
                {
                    ECPoint x1y1 = ecc_point_g.Multiply(s);
                    //System.out.println("计算曲线点X0: "+ x1y1.normalize().getXCoord().toBigInteger().toString(16));
                    //System.out.println("计算曲线点Y0: "+ x1y1.normalize().getYCoord().toBigInteger().toString(16));
                    //System.out.println("");

                    x1y1 = x1y1.Add(userKey.Multiply(t));
                    //System.out.println("计算曲线点X1: "+ x1y1.normalize().getXCoord().toBigInteger().toString(16));
                    //System.out.println("计算曲线点Y1: "+ x1y1.normalize().getYCoord().toBigInteger().toString(16));
                    //System.out.println("");
                    sm2Result.R = e.Add(x1y1.Normalize().XCoord.ToBigInteger()).Mod(this.ecc_n);
                    //System.out.println("R: " + sm2Result.R.toString(16));
                    return sm2Result;
                }
            }

            public byte[] Sm2GetZ(byte[] userId, ECPoint userKey)
            {
                SM3Digest sm3 = new SM3Digest();
                byte[] p;
                // userId length
                int len = userId.Length * 8;
                sm3.Update((byte)(len >> 8 & 0x00ff));
                sm3.Update((byte)(len & 0x00ff));

                // userId
                sm3.BlockUpdate(userId, 0, userId.Length);

                // a,b
                p = ecc_a.ToByteArray32();
                sm3.BlockUpdate(p, 0, p.Length);
                p = ecc_b.ToByteArray32();
                sm3.BlockUpdate(p, 0, p.Length);
                // gx,gy
                p = ecc_gx.ToByteArray32();
                sm3.BlockUpdate(p, 0, p.Length);
                p = ecc_gy.ToByteArray32();
                sm3.BlockUpdate(p, 0, p.Length);

                // x,y
                p = userKey.Normalize().XCoord.ToBigInteger().ToByteArray32();
                sm3.BlockUpdate(p, 0, p.Length);
                p = userKey.Normalize().YCoord.ToBigInteger().ToByteArray32();
                sm3.BlockUpdate(p, 0, p.Length);

                // Z
                byte[] md = new byte[sm3.GetDigestSize()];
                sm3.DoFinal(md, 0);

                return md;
            }
        }

        internal sealed class SM2Signature
        {
            public byte[] R { get; set; }

            public byte[] S { get; set; }

            public SM2Signature()
            {
                R = Array.Empty<byte>();
                S = Array.Empty<byte>();
            }

            public SM2Signature(byte[] signBytes)
                : this()
            {
                if (signBytes.Length == 65)
                {
                    signBytes = signBytes.Skip(1).ToArray();
                }

                if (signBytes.Length == 64)
                {
                    R = signBytes.Take(32).ToArray();
                    S = signBytes.Skip(32).ToArray();
                }
                else
                {
                    throw new ArgumentException("Invalid signature data.", nameof(signBytes));
                }
            }

            public byte[] ToByteArray()
            {
                return R.Concat(S).ToArray();
            }

            public byte[] ToByteArray04()
            {
                byte[] temp = new byte[65];
                temp[0] = 0x04;

                Array.Copy(this.R, 0, temp, 1, 32);
                Array.Copy(this.S, 0, temp, 33, 32);

                return temp;
            }
        }

        internal sealed class SM2Result
        {
            public BigInteger R;
            public BigInteger S;

            public byte[] sa;
            public byte[] sb;
            public byte[] s1;
            public byte[] s2;

            public ECPoint keyra;
            public ECPoint keyrb;
        }
    }
}
