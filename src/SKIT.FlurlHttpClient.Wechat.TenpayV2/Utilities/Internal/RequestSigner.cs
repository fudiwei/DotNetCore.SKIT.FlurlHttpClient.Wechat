using System;
using System.Collections.Generic;
using System.Linq;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Utilities
{
    internal static class RequestSigner
    {
        public static string Sign(IDictionary<string, string?> paramsMap, string secret, string? signType)
        {
            if (paramsMap == null) throw new ArgumentNullException(nameof(paramsMap));

            IDictionary<string, string?> sortedParamsMap = new SortedDictionary<string, string?>(paramsMap, StringComparer.OrdinalIgnoreCase);
            string sortedQueryString = string.Join("&", sortedParamsMap.Where(e => !string.IsNullOrEmpty(e.Value)).Select(e => $"{e.Key}={e.Value}"));
            return SignFromSortedQueryString(sortedQueryString, secret, signType);
        }

        public static string SignFromJson(string json, string secret, string? signType)
        {
            return SignFromSortedQueryString(JsonUtility.ParseToSortedQueryString(json), secret, signType);
        }

        public static string SignFromSortedQueryString(string queryString, string secret, string? signType)
        {
            signType = signType ?? Constants.SignTypes.MD5;
            queryString = queryString + $"&key={secret}";

            switch (signType)
            {
                case Constants.SignTypes.MD5:
                    {
                        return MD5Utility.Hash(queryString).ToUpper();
                    }

                case Constants.SignTypes.HMAC_SHA256:
                    {
                        return HMACUtility.HashWithSHA256(secret, queryString).ToUpper();
                    }

                default:
                    throw new NotSupportedException("Unsupported sign type.");
            }
        }
    }
}
