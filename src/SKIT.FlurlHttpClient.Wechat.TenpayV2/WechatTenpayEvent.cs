using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2
{
    /// <summary>
    /// 表示微信支付 API 回调通知事件的基类。
    /// </summary>
    [Serializable]
    public class WechatTenpayEvent : ICommonWebhookEvent
    {
        public static class Types
        {
            public interface IDecryptedRequestInfo
            {
            }
        }

        /// <summary>
        /// 获取或设置微信支付回调的状态码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("return_code")]
        [System.Text.Json.Serialization.JsonPropertyName("return_code")]
        public string ReturnCode { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信支付回调的状态描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("return_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("return_msg")]
        public string ReturnMessage { get; set; } = default!;

        /// <summary>
        /// 获取微信支付 API 返回的错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_code")]
        [System.Text.Json.Serialization.JsonPropertyName("err_code")]
        public string? ErrorCode { get; set; }

        /// <summary>
        /// 获取微信支付 API 返回的状态描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_code_des")]
        [System.Text.Json.Serialization.JsonPropertyName("err_code_des")]
        public string? ErrorCodeDescription { get; set; }

        /// <summary>
        /// 获取或设置业务结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result_code")]
        [System.Text.Json.Serialization.JsonPropertyName("result_code")]
        public string? ResultCode { get; set; }

        /// <summary>
        /// 获取或设置业务结果描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("result_msg")]
        public string? ResultMessage { get; set; }

        /// <summary>
        /// 获取或设置微信支付回调的商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_id")]
        public string? MerchantId { get; set; }

        /// <summary>
        /// 获取或设置微信支付回调的 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置微信支付回调的随机字符串。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nonce_str")]
        [System.Text.Json.Serialization.JsonPropertyName("nonce_str")]
        public string? NonceString { get; set; }

        /// <summary>
        /// 获取或设置签名类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign_type")]
        [System.Text.Json.Serialization.JsonPropertyName("sign_type")]
        public string? SignType { get; set; }

        /// <summary>
        /// 获取或设置签名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign")]
        [System.Text.Json.Serialization.JsonPropertyName("sign")]
        public string? Signature { get; set; }

        /// <summary>
        /// 获取或设置 Base64 编码后的加密信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("req_info")]
        [System.Text.Json.Serialization.JsonPropertyName("req_info")]
        public string? EncryptedRequestInfo { get; set; }
    }
}
