namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /mmpaymkttransfers/sendredpack 接口的请求。</para>
    /// </summary>
    public class SendPayMarketingTransfersRedPackRequest : WechatTenpaySignableRequest
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_id")]
        public override string? MerchantId { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wxappid")]
        [System.Text.Json.Serialization.JsonPropertyName("wxappid")]
        public override string? AppId { get; set; }

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mch_id")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置子商户 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msgappid")]
        [System.Text.Json.Serialization.JsonPropertyName("msgappid")]
        public string? SubAppId { get; set; }

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_billno")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_billno")]
        public string MerchantBillNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置接受红包的用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("re_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("re_openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置红包发送者名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("send_name")]
        [System.Text.Json.Serialization.JsonPropertyName("send_name")]
        public string? SenderName { get; set; }

        /// <summary>
        /// 获取或设置红包金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("total_amount")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int TotalAmount { get; set; }

        /// <summary>
        /// 获取或设置红包数量。
        /// <para>默认值：1</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int TotalCount { get; set; } = 1;

        /// <summary>
        /// 获取或设置红包祝福语。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wishing")]
        [System.Text.Json.Serialization.JsonPropertyName("wishing")]
        public string? Wishing { get; set; }

        /// <summary>
        /// 获取或设置用户终端 IP。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("client_ip")]
        [System.Text.Json.Serialization.JsonPropertyName("client_ip")]
        public string ClientIp { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置活动名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("act_name")]
        [System.Text.Json.Serialization.JsonPropertyName("act_name")]
        public string? ActivityName { get; set; }

        /// <summary>
        /// 获取或设置备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        [System.Text.Json.Serialization.JsonPropertyName("remark")]
        public string? Remark { get; set; }

        /// <summary>
        /// 获取或设置场景 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_id")]
        [System.Text.Json.Serialization.JsonPropertyName("scene_id")]
        public string? SceneId { get; set; }

        /// <summary>
        /// 获取或设置活动风控信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("risk_info")]
        [System.Text.Json.Serialization.JsonPropertyName("risk_info")]
        public string? RiskInfo { get; set; }
    }
}
