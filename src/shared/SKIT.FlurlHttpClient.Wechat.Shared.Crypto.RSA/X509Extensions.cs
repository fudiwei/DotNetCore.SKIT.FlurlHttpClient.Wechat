using System.Security.Cryptography.X509Certificates;

namespace SKIT.FlurlHttpClient.Wechat.Shared.Crypto
{
    /// <summary>
    ///
    /// </summary>
    static partial class X509Extensions
    {
        /// <summary>
        /// 导出 X.509 证书中的 RSA 公钥的 DER 字节数组。
        /// </summary>
        /// <param name="x509">X.509 证书。</param>
        /// <returns></returns>
        public static byte[] ExportRSAPublicKeyBytes(this X509Certificate2 x509)
        {
            if (x509 is null) throw new ArgumentNullException(nameof(x509));

            using var rsa = x509.GetRSAPublicKey();
            if (rsa is null)
                throw new InvalidOperationException("The certificate does not contain a RSA public key.");

            byte[] publicKey = x509.PublicKey.EncodedKeyValue.RawData;
            byte[] algorithmId = DerEncoder.EncodeSequence(DerEncoder.EncodeObjectIdentifier(DerOID.RSA_ENCRYPTION_OID_RAW), DerEncoder.EncodeNull());

            byte[] spkiDer = DerEncoder.EncodeSequence(algorithmId, DerEncoder.EncodeBitString(publicKey));
            return spkiDer;
        }
    }
}
