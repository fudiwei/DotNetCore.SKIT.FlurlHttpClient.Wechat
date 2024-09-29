using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/shopping-receipt/merchantshoppingreceiptjumpinfos 接口的响应。</para>
    /// </summary>
    public class SetMarketingShoppingReceiptJumpInfoResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class MerchantJumpInfo
            {
                public static class Types
                {
                    public class JumpLink : SetMarketingShoppingReceiptJumpInfoRequest.Types.JumpInfo
                    {
                    }
                }

                /// <summary>
                /// 获取或设置微信支付订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("transaction_id")]
                [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
                public string TransactionId { get; set; } = default!;

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
                public string OpenId { get; set; } = default!;

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
                public Types.JumpLink JumpLink { get; set; } = default!;

                /// <summary>
                /// 获取或设置创建时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset CreateTime { get; set; }

                /// <summary>
                /// 获取或设置修改时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("modify_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("modify_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset ModifyTime { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商家电子小票跳转信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_jump_info")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_jump_info")]
        public Types.MerchantJumpInfo MerchantJumpInfo { get; set; } = default!;
    }
}
