using System.Security.Cryptography.X509Certificates;

namespace SKIT.FlurlHttpClient.Wechat.Shared.Crypto
{
    /// <summary>
    ///
    /// </summary>
    static partial class X509Extensions
    {
        /// <summary>
        /// 导出 X.509 证书中的 SM2 公钥的 DER 字节数组。
        /// </summary>
        /// <param name="x509">X.509 证书。</param>
        /// <returns></returns>
        public static byte[] ExportSM2PublicKeyBytes(this X509Certificate2 x509)
        {
            if (x509 is null) throw new ArgumentNullException(nameof(x509));

            if (x509.PublicKey is null || !string.Equals(x509.PublicKey.Oid?.Value, DerOID.EC_PUBLIC_KEY_OID))
                throw new InvalidOperationException("The certificate does not contain an EC public key.");

            byte[]? encodedCurveOid = x509.PublicKey.EncodedParameters?.RawData;
            if (encodedCurveOid is null ||
                encodedCurveOid.Length != 10 ||
                encodedCurveOid[0] != 0x06 ||
                encodedCurveOid[1] != DerOID.SM2_EC_OID_RAW.Length)
                throw new InvalidOperationException("The certificate does not contain a SM2 public key.");
            for (int i = 0; i < DerOID.SM2_EC_OID_RAW.Length; i++)
            {
                if (encodedCurveOid[i + 2] != DerOID.SM2_EC_OID_RAW[i])
                    throw new InvalidOperationException("The certificate does not contain a SM2 public key.");
            }

            byte[] ecPublicKey = x509.PublicKey.EncodedKeyValue.RawData;
            if (ecPublicKey.Length != 65 || ecPublicKey[0] != 0x04)
                throw new InvalidOperationException("The certificate contains an invalid SM2 public key.");
            byte[] algorithmId = DerEncoder.EncodeSequence(
                DerEncoder.EncodeObjectIdentifier(DerOID.EC_PUBLIC_KEY_OID_RAW),
                DerEncoder.EncodeObjectIdentifier(DerOID.SM2_EC_OID_RAW)
            );

            byte[] spkiDer = DerEncoder.EncodeSequence(algorithmId, DerEncoder.EncodeBitString(ecPublicKey));
            return spkiDer;
        }
    }
}
