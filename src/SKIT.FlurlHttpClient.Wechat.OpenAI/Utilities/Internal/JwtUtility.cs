using System;
using JWT;
using JWT.Algorithms;
using JWT.Serializers;
using Newtonsoft.Json;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Utilities
{
    internal static class JwtUtility
    {
        private static readonly Lazy<IJwtEncoder> _encoder = new Lazy<IJwtEncoder>(() =>
        {
#pragma warning disable CS0618
            IJwtAlgorithm algorithm = new HMACSHA256Algorithm();
#pragma warning restore CS0618
            IJsonSerializer serializer = new JsonNetSerializer(new JsonSerializer() { NullValueHandling = NullValueHandling.Ignore });
            IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
            IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);
            return encoder;
        }, isThreadSafe: true);

        public static string EncodeWithHS256(object payload, string secret)
        {
            return _encoder.Value.Encode(payload, secret);
        }
    }
}
