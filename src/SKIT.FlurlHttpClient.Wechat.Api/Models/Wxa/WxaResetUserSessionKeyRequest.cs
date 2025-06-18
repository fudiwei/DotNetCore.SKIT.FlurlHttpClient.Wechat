using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/resetusersessionkey 接口的请求。</para>
    /// </summary>
    public class WxaResetUserSessionKeyRequest : WechatApiRequest, IInferable<WxaResetUserSessionKeyRequest, WxaResetUserSessionKeyResponse>
    {
        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户登录态签名。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string Signature { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户登录态签名的哈希方法。
        /// <para>默认值："hmac_sha256"</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string SignMethod { get; set; } = "hmac_sha256";

        public void SetSignatureBySessionKey(string sessionKey, string signMethod = "hmac_sha256")
        {
            if (sessionKey is null) throw new ArgumentNullException(nameof(sessionKey));
            if (signMethod is null) throw new ArgumentNullException(nameof(signMethod));

            switch (signMethod)
            {
                case "hmac_sha256":
                    Signature = Utilities.HMACUtility.HashWithSHA256(sessionKey, string.Empty).Value!.ToLower();
                    SignMethod = signMethod;
                    break;

                default:
                    throw new NotSupportedException();
            }
        }
    }
}
