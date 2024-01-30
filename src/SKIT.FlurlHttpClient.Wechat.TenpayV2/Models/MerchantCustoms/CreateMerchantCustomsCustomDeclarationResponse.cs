using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/mch/customs/customdeclareorder 接口的响应。</para>
    /// </summary>
    public class CreateMerchantCustomsCustomDeclarationResponse : WechatTenpaySignableResponse
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_id")]
#pragma warning disable CS8618
#pragma warning disable CS8765
        public override string MerchantId { get; set; }
#pragma warning restore CS8765
#pragma warning restore CS8618

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
#pragma warning disable CS8618
#pragma warning disable CS8765
        public override string AppId { get; set; }
#pragma warning restore CS8765
#pragma warning restore CS8618

        /// <summary>
        /// 获取或设置状态码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state")]
        [System.Text.Json.Serialization.JsonPropertyName("state")]
        public string State { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
        public string OutTradeNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信支付订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户子订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_order_no")]
        public string? SubOrderNumber { get; set; }

        /// <summary>
        /// 获取或设置微信子订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_order_id")]
        public string? SubOrderId { get; set; }

        /// <summary>
        /// 获取或设置最后更新时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("modify_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.DigitalDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("modify_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.DigitalDateTimeOffsetConverter))]
        public DateTimeOffset ModifyTime { get; set; }

        /// <summary>
        /// 获取或设置订购人和支付人身份信息校验结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cert_check_result")]
        [System.Text.Json.Serialization.JsonPropertyName("cert_check_result")]
        public string? CertificateCheckResult { get; set; }

        /// <summary>
        /// 获取或设置验核机构。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("verify_department")]
        [System.Text.Json.Serialization.JsonPropertyName("verify_department")]
        public string? VerifyDepartment { get; set; }

        /// <summary>
        /// 获取或设置验核机构交易流水号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("verify_department_trade_id")]
        [System.Text.Json.Serialization.JsonPropertyName("verify_department_trade_id")]
        public string? VerifyDepartmentTradeId { get; set; }
    }
}
