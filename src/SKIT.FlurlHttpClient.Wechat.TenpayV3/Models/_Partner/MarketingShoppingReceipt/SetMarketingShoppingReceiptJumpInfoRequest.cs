using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/shopping-receipt/merchantshoppingreceiptjumpinfos 接口的请求。</para>
    /// </summary>
    public class SetMarketingShoppingReceiptJumpInfoRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class JumpInfo
            {
                /// <summary>
                /// 获取或设置小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_appid")]
                public string MiniProgramAppId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置小程序页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_path")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_path")]
                public string MiniProgramPagePath { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置微信支付订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置微信支付商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_mchid")]
        public string? TransactionMerchantId { get; set; }

        /// <summary>
        /// 获取或设置微信支付子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_sub_mchid")]
        public string? TransactionSubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置上传时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_upload_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_upload_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? UploadTime { get; set; }

        /// <summary>
        /// 获取或设置跳转信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("jump_info")]
        [System.Text.Json.Serialization.JsonPropertyName("jump_info")]
        public Types.JumpInfo JumpInfo { get; set; } = new Types.JumpInfo();
    }
}
