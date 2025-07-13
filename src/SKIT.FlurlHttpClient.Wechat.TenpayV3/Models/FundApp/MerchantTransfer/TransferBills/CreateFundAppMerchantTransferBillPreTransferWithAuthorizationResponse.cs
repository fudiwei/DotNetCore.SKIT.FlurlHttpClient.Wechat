using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /fund-app/mch-transfer/transfer-bills/pre-transfer-with-authorization 接口的响应。</para>
    /// </summary>
    public class CreateFundAppMerchantTransferBillPreTransferWithAuthorizationResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置商户单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_bill_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_bill_no")]
        public string OutBillNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信转账单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_bill_no")]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_bill_no")]
        public string TransferBillNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置单据状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state")]
        [System.Text.Json.Serialization.JsonPropertyName("state")]
        public string State { get; set; } = default!;

        /// <summary>
        /// 获取或设置单据创建时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset CreateTime { get; set; }

        /// <summary>
        /// 获取或设置跳转领取页面的携带信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("package_info")]
        [System.Text.Json.Serialization.JsonPropertyName("package_info")]
        public string? PackageInfo { get; set; }

        /// <summary>
        /// 获取或设置用户展示昵称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_display_name")]
        [System.Text.Json.Serialization.JsonPropertyName("user_display_name")]
        public string? UserDisplayName { get; set; }

        /// <summary>
        /// 获取或设置商户侧授权单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_authorization_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_authorization_no")]
        public string? OutAuthorizationNumber { get; set; }
    }
}
