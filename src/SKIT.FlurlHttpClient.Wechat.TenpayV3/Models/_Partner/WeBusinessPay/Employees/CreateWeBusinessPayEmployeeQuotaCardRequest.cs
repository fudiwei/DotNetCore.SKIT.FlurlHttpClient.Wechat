using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /webizpay/employees/{employee_id}/quota-cards 接口的请求。</para>
    /// </summary>
    public class CreateWeBusinessPayEmployeeQuotaCardRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置微信商户号。如果不指定将使用构造 <see cref="WechatTenpayClient"/> 时的 <see cref="WechatTenpayClientOptions.MerchantId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_mchid")]
        public string? MerchantId { get; set; }

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置微信授权关系 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string EmployeeId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户卡号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_card_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_card_no")]
        public string OutCardNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置企业支付卡模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_template_id")]
        public string CardTemplateId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置可用金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 获取或设置有效期结束时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("effective_end_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("effective_end_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset EffectiveEndTime { get; set; }

        /// <summary>
        /// 获取或设置卡片名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_name")]
        [System.Text.Json.Serialization.JsonPropertyName("card_name")]
        public string CardName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置卡片备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_remark")]
        [System.Text.Json.Serialization.JsonPropertyName("card_remark")]
        public string? CardRemark { get; set; }
    }
}
