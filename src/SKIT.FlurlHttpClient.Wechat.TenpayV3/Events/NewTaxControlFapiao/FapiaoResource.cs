using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Events
{
    /// <summary>
    /// <para>表示 FAPIAO.USER_APPLIED 通知的数据。</para>
    /// <para>标识 FAPIAO.CARD_INSERTED 通知的数据。</para>
    /// <para>标识 FAPIAO.CARD_DISCARDED 通知的数据。</para>
    /// <para>标识 FAPIAO.ISSUED 通知的数据。</para>
    /// <para>标识 FAPIAO.REVERSED 通知的数据。</para>
    /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/fapiao/fapiao-card-template/invoice-card-cancel-notice.html </para>
    /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/fapiao/fapiao-applications/invoice-issued-success-notice.html </para>
    /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/fapiao/fapiao-applications/invoice-flush-success-notice.html </para>
    /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/fapiao/fapiao-applications/invoice-insert-bag-success-notice.html </para>
    /// </summary>
    public class FapiaoResource : WechatTenpayEvent.Types.IDecryptedResource
    {
        public static class Types
        {
            public class Fapiao
            {
                /// <summary>
                /// 获取或设置商户发票单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fapiao_id")]
                [System.Text.Json.Serialization.JsonPropertyName("fapiao_id")]
                public string FapiaoId { get; set; } = default!;

                /// <summary>
                /// 获取或设置发票状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fapiao_status")]
                [System.Text.Json.Serialization.JsonPropertyName("fapiao_status")]
                public string FapiaoStatus { get; set; } = default!;

                /// <summary>
                /// 获取或设置卡包状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("card_status")]
                [System.Text.Json.Serialization.JsonPropertyName("card_status")]
                public string CardStatus { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("mchid")]
        public string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置发票申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fapiao_apply_id")]
        [System.Text.Json.Serialization.JsonPropertyName("fapiao_apply_id")]
        public string FapiaoApplyId { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户填写时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apply_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("apply_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        public DateTimeOffset? ApplyTime { get; set; }

        /// <summary>
        /// 获取或设置发票列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fapiao_information")]
        [System.Text.Json.Serialization.JsonPropertyName("fapiao_information")]
        public Types.Fapiao[]? FapiaoList { get; set; }
    }
}
