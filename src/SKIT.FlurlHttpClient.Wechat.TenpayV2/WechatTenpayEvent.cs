using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2
{
    /// <summary>
    /// 表示微信支付 API 回调通知事件的基类。
    /// </summary>
    [Serializable]
    public class WechatTenpayEvent
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
        /// 获取或设置微信支付回调的商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_id")]
        public string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信支付回调的 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mch_id")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置子商户 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
        public string? SubAppId { get; set; }

        /// <summary>
        /// 获取或设置微信支付回调的随机字符串。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nonce_str")]
        [System.Text.Json.Serialization.JsonPropertyName("nonce_str")]
        public string NonceString { get; set; } = default!;

        /// <summary>
        /// 获取或设置 Base64 编码后的加密信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("req_info")]
        [System.Text.Json.Serialization.JsonPropertyName("req_info")]
        public string EncryptedRequestInfo { get; set; } = default!;
    }
}
