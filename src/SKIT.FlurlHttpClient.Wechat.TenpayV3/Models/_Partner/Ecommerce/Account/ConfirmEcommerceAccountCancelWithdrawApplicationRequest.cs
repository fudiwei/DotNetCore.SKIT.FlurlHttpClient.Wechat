using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /ecommerce/account/apply-cancel-withdraw/confirm 接口的请求。</para>
    /// </summary>
    public class ConfirmEcommerceAccountCancelWithdrawApplicationRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置微信二级商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置微信支付注销提现申请单号。与字段 <see cref="OutRequestNumber"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("applyment_id")]
        [System.Text.Json.Serialization.JsonPropertyName("applyment_id")]
        public string? ApplymentId { get; set; }

        /// <summary>
        /// 获取或设置商户注销申请单号。与字段 <see cref="ApplymentId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string? OutRequestNumber { get; set; }

        /// <summary>
        /// 获取或设置平台确认操作人标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operator_identification")]
        [System.Text.Json.Serialization.JsonPropertyName("operator_identification")]
        public string? OperatorIdentification { get; set; }

        /// <summary>
        /// 获取或设置注销确认时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("confirm_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("confirm_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset ConfirmTime { get; set; }

        /// <summary>
        /// 获取或设置注销协议版本号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cancel_contract_version")]
        [System.Text.Json.Serialization.JsonPropertyName("cancel_contract_version")]
        public string CancelContractVersion { get; set; } = string.Empty;
    }
}
