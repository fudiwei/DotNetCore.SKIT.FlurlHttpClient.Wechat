using System.Collections.Generic;
using System.Globalization;

namespace SKIT.FlurlHttpClient.Wechat.Shared.Crypto
{
    static partial class DerOID
    {
        public const string EC_PUBLIC_KEY_OID = "1.2.840.10045.2.1";
        public static readonly byte[] EC_PUBLIC_KEY_OID_RAW = EncodeObjectIdentifier(EC_PUBLIC_KEY_OID);

        public const string SM2_EC_OID = "1.2.156.10197.1.301";
        public static readonly byte[] SM2_EC_OID_RAW = EncodeObjectIdentifier(SM2_EC_OID);
    }
}
