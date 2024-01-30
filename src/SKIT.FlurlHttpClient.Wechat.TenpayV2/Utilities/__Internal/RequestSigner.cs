using System;
using System.Collections.Generic;
using System.Linq;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Utilities
{
    internal static class RequestSigner
    {
        private const string DEFAULT_SECRET_KEY = "key";

        public static string Sign(IDictionary<string, string?> paramsMap, string secret, string? signType = null)
        {
            return Sign(paramsMap: paramsMap, secretKey: DEFAULT_SECRET_KEY, secretValue: secret, signType: signType);
        }

        public static string Sign(IDictionary<string, string?> paramsMap, string secretKey, string secretValue, string? signType = null)
        {
            if (paramsMap is null) throw new ArgumentNullException(nameof(paramsMap));

            IDictionary<string, string?> sortedParamsMap = new SortedDictionary<string, string?>(paramsMap, StringComparer.OrdinalIgnoreCase);
            string sortedQueryString = string.Join("&", sortedParamsMap.Where(e => !string.IsNullOrEmpty(e.Value)).Select(e => $"{e.Key}={e.Value}"));
            return SignFromSortedQueryString(queryString: sortedQueryString, secretKey: secretKey, secretValue: secretValue, signType: signType);
        }

        public static string SignFromJson(string json, string secret, string? signType = null)
        {
            return SignFromJson(json: json, secretKey: DEFAULT_SECRET_KEY, secretValue: secret, signType: signType);
        }

        public static string SignFromJson(string json, string secretKey, string secretValue, string? signType = null)
        {
            return SignFromSortedQueryString(queryString: JsonHelper.ParseToSortedQueryString(json), secretKey: secretKey, secretValue: secretValue, signType: signType);
        }

        public static string SignFromSortedQueryString(string queryString, string secret, string? signType = null)
        {
            return SignFromSortedQueryString(queryString: queryString, secretKey: DEFAULT_SECRET_KEY, secretValue: secret, signType: signType);
        }

        public static string SignFromSortedQueryString(string queryString, string secretKey, string secretValue, string? signType = null)
        {
            signType = signType ?? Constants.SignTypes.MD5;
            queryString = queryString + $"&{secretKey}={secretValue}";

            switch (signType)
            {
                case Constants.SignTypes.MD5:
                    {
                        return MD5Utility.Hash(queryString).ToUpper();
                    }

                case Constants.SignTypes.HMAC_SHA256:
                    {
                        return HMACUtility.HashWithSHA256(secretValue, queryString).ToUpper();
                    }

                default:
                    throw new NotSupportedException("Unsupported sign type.");
            }
        }
    }
}
