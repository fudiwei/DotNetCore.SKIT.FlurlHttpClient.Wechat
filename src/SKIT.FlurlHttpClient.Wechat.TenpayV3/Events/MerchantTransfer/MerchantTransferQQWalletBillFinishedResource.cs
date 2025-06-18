using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Events
{
    /// <summary>
    /// <para>表示 MCHTRANSFER.QQWALLETBILL.FINISHED", 通知的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4014301851 ]]> <br/>
    /// </para>
    /// </summary>
    public class MerchantTransferQQWalletBillFinishedResource : WechatTenpayEvent.Types.IDecryptedResource
    {
        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("mchid")]
        public string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置 QQ 互联开放平台 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户转账单号
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
        /// 获取或设置转账金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_amount")]
        public int TransferAmount { get; set; }

        /// <summary>
        /// 获取或设置转账备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_remark")]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_remark")]
        public string TransferRemark { get; set; } = default!;

        /// <summary>
        /// 获取或设置收款用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置收款用户的 QQ 号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_qq")]
        [System.Text.Json.Serialization.JsonPropertyName("user_qq")]
        public string? UserQQ { get; set; }

        /// <summary>
        /// 获取或设置收款用户姓名（需使用商户私钥解密）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_name")]
        [System.Text.Json.Serialization.JsonPropertyName("user_name")]
        public string? UserName { get; set; }

        /// <summary>
        /// 获取或设置更新时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset UpdateTime { get; set; }

        /// <summary>
        /// 获取或设置创建时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset CreateTime { get; set; }

        /// <summary>
        /// 获取或设置失败原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_reason")]
        public string? FailReason { get; set; }
    }
}
