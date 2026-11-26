using System.Formats.Asn1;
using System.Security.Cryptography;

namespace SKIT.FlurlHttpClient.Wechat.Shared.Crypto.RSA
{
    /// <summary>
    /// 
    /// </summary>
    static class RSAKeyReader
    {
        /// <summary>
        /// 读取 PEM 编码字符串为 RSA 私钥的 DER 字节数组。
        /// 支持 PKCS#1 和 PKCS#8 两种封装格式。
        /// </summary>
        /// <param name="encodingPEM">PEM 编码字符串。</param>
        /// <returns></returns>
        public static byte[] ReadPrivateKeyBytes(string encodingPEM)
        {
            if (encodingPEM is null) throw new ArgumentNullException(nameof(encodingPEM));

            string sanitizedPEM = PemReader.Sanitize(encodingPEM);

            ReadOnlySpan<char> pem = sanitizedPEM.AsSpan();
            switch (RSAKeySniffer.DetectPrivateKeyFormat(pem))
            {
                case RSAPrivateKeyFormat.PKCS1:
                    {
                        byte[] pkcs1Der = PemReader.ToBytes(sanitizedPEM, true);

#if NETCOREAPP || NET5_0_OR_GREATER
                        using var rsa = new RSACryptoServiceProvider();
                        rsa.ImportRSAPrivateKey(pkcs1Der, out _);
                        return rsa.ExportPkcs8PrivateKey();
#else
                        byte[] version = DerEncoder.EncodeInteger(new byte[] { 0 });
                        byte[] algorithmId = DerEncoder.EncodeSequence(DerEncoder.EncodeObjectIdentifier(DerOID.RSA_ENCRYPTION_OID_RAW), DerEncoder.EncodeNull());
                        byte[] privateKeyInfo = DerEncoder.EncodeOctetString(pkcs1Der);

                        byte[] pkcs8Der = DerEncoder.EncodeSequence(version, algorithmId, privateKeyInfo);
                        return pkcs8Der;
#endif
                    }

                case RSAPrivateKeyFormat.PKCS8:
                    {
                        byte[] pkcs8Der = PemReader.ToBytes(sanitizedPEM, true);
                        return pkcs8Der;
                    }

                default:
                    throw new ArgumentException("Invalid RSA private key format.");
            }
        }

        /// <summary>
        /// 读取 PEM 编码字符串为 RSA 公钥的 DER 字节数组。
        /// 支持 PKCS#1 和 PKCS#8/SPKI 两种封装格式。
        /// </summary>
        /// <param name="encodingPEM">PEM 编码字符串。</param>
        /// <returns></returns>
        public static byte[] ReadPublicKeyBytes(string encodingPEM)
        {
            if (encodingPEM is null) throw new ArgumentNullException(nameof(encodingPEM));

            string sanitizedPEM = PemReader.Sanitize(encodingPEM);

            ReadOnlySpan<char> pem = sanitizedPEM.AsSpan();
            switch (RSAKeySniffer.DetectPublicKeyFormat(pem))
            {
                case RSAPublicKeyFormat.PKCS1:
                    {
                        byte[] pkcs1Der = PemReader.ToBytes(sanitizedPEM, true);

#if NETCOREAPP || NET5_0_OR_GREATER
                        using var rsa = new RSACryptoServiceProvider();
                        rsa.ImportRSAPublicKey(pkcs1Der, out _);
                        return rsa.ExportSubjectPublicKeyInfo();
#else
                        byte[] algorithmId = DerEncoder.EncodeSequence(DerEncoder.EncodeObjectIdentifier(DerOID.RSA_ENCRYPTION_OID_RAW), DerEncoder.EncodeNull());
                        byte[] subjectPublicKeyInfo = DerEncoder.EncodeBitString(pkcs1Der);

                        byte[] spkiDer = DerEncoder.EncodeSequence(algorithmId, subjectPublicKeyInfo);
                        return spkiDer;
#endif
                    }

                case RSAPublicKeyFormat.SPKI:
                    {
                        byte[] spkiDer = PemReader.ToBytes(sanitizedPEM, true);
                        return spkiDer;
                    }

                default:
                    throw new ArgumentException("Invalid RSA public key format.");
            }
        }

#if !NETCOREAPP && !NET5_0_OR_GREATER
        /// <summary>
        /// 读取 RSA 私钥的 DER 字节数组为 <see cref="RSAParameters"/> 对象。
        /// </summary>
        /// <param name="bytes">RSA 私钥的 DER 字节数组。</param>
        /// <returns></returns>
        public static RSAParameters ReadPrivateKeyParams(byte[] bytes)
        {
            try
            {
                var root = new AsnReader(bytes, AsnEncodingRules.DER);

                var pkcs8 = root.ReadSequence();
                root.ThrowIfNotEmpty();

                ReadAsnAsVersion(pkcs8);
                ReadAsnAsRsaAlgorithm(pkcs8.ReadSequence());

                byte[] octets = pkcs8.ReadOctetString();
                pkcs8.ThrowIfNotEmpty();

                var privateKey = new AsnReader(octets, AsnEncodingRules.DER);
                var key = privateKey.ReadSequence();
                privateKey.ThrowIfNotEmpty();

                ReadAsnAsVersion(key);

                byte[] modulus = ReadAsnAsInteger(key);
                int modulusLength = modulus.Length;
                int halfLength = (modulusLength + 1) / 2;
                var result = new RSAParameters
                {
                    Modulus = modulus,
                    Exponent = ReadAsnAsInteger(key),
                    D = PadAsnInteger(ReadAsnAsInteger(key), modulusLength),
                    P = PadAsnInteger(ReadAsnAsInteger(key), halfLength),
                    Q = PadAsnInteger(ReadAsnAsInteger(key), halfLength),
                    DP = PadAsnInteger(ReadAsnAsInteger(key), halfLength),
                    DQ = PadAsnInteger(ReadAsnAsInteger(key), halfLength),
                    InverseQ = PadAsnInteger(ReadAsnAsInteger(key), halfLength)
                };
                key.ThrowIfNotEmpty();
                return result;
            }
            catch (AsnContentException ex)
            {
                throw new CryptographicException("Invalid DER-encoded RSA private key.", ex);
            }
        }

        /// <summary>
        /// 读取 RSA 公钥的 DER 字节数组为 <see cref="RSAParameters"/> 对象。
        /// </summary>
        /// <param name="bytes">RSA 公钥的 DER 字节数组。</param>
        /// <returns></returns>
        /// <exception cref="CryptographicException"></exception>
        public static RSAParameters ReadPublicKeyParams(byte[] bytes)
        {
            try
            {
                var root = new AsnReader(bytes, AsnEncodingRules.DER);

                var spki = root.ReadSequence();
                root.ThrowIfNotEmpty();

                ReadAsnAsRsaAlgorithm(spki.ReadSequence());
                byte[] bitString = spki.ReadBitString(out int unusedBits);
                spki.ThrowIfNotEmpty();

                if (unusedBits != 0) throw new CryptographicException("Invalid RSA public key.");

                var publicKey = new AsnReader(bitString, AsnEncodingRules.DER);
                var key = publicKey.ReadSequence();
                publicKey.ThrowIfNotEmpty();

                var result = new RSAParameters { Modulus = ReadAsnAsInteger(key), Exponent = ReadAsnAsInteger(key) };
                key.ThrowIfNotEmpty();
                return result;
            }
            catch (AsnContentException ex)
            {
                throw new CryptographicException("Invalid DER-encoded RSA public key.", ex);
            }
        }

        private static void ReadAsnAsRsaAlgorithm(AsnReader reader)
        {
            if (reader.ReadObjectIdentifier() != DerOID.RSA_ENCRYPTION_OID)
                throw new CryptographicException("Invalid RSA algorithm identifier.");
            if (reader.HasData)
                reader.ReadNull();
            reader.ThrowIfNotEmpty();
        }

        private static void ReadAsnAsVersion(AsnReader reader)
        {
            ReadOnlySpan<byte> version = reader.ReadIntegerBytes().Span;
            if (version.Length != 1 || version[0] != 0)
                throw new CryptographicException("Unsupported RSA key version.");
        }

        private static byte[] ReadAsnAsInteger(AsnReader reader)
        {
            ReadOnlySpan<byte> value = reader.ReadIntegerBytes().Span;
            if ((value[0] & 0x80) != 0)
                throw new CryptographicException("Invalid RSA integer.");
            if (value.Length > 1 && value[0] == 0)
                value = value.Slice(1);
            return value.ToArray();
        }

        private static byte[] PadAsnInteger(byte[] value, int length)
        {
            if (value.Length > length) throw new CryptographicException("Invalid RSA private key.");
            if (value.Length == length) return value;

            byte[] padded = new byte[length];
            Buffer.BlockCopy(value, 0, padded, length - value.Length, value.Length);
            return padded;
        }
#endif
    }
}
