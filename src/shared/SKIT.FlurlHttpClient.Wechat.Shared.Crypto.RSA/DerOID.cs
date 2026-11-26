namespace SKIT.FlurlHttpClient.Wechat.Shared.Crypto
{
    static partial class DerOID
    {
        public static readonly string RSA_ENCRYPTION_OID = "1.2.840.113549.1.1.1";
        public static readonly byte[] RSA_ENCRYPTION_OID_RAW = EncodeObjectIdentifier(RSA_ENCRYPTION_OID);
    }
}
