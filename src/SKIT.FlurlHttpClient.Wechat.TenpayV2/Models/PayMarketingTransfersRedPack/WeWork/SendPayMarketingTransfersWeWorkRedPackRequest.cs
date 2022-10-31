namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /mmpaymkttransfers/sendworkwxredpack 接口的请求。</para>
    /// </summary>
    public class SendPayMarketingTransfersWeWorkRedPackRequest : WechatTenpaySignableRequest
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
        /// 获取或设置红包发送者名称。与字段 <see cref="AgentId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sender_name")]
        [System.Text.Json.Serialization.JsonPropertyName("sender_name")]
        public string? SenderName { get; set; }

        /// <summary>
        /// 获取或设置红包发送者头像 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sender_header_media_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sender_header_media_id")]
        public string? SenderHeadImageMediaId { get; set; }

        /// <summary>
        /// 获取或设置发送红包的应用 ID。与字段 <see cref="SenderName"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agentid")]
        [System.Text.Json.Serialization.JsonPropertyName("agentid")]
        public int? AgentId { get; set; }

        /// <summary>
        /// 获取或设置红包金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("total_amount")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int TotalAmount { get; set; }

        /// <summary>
        /// 获取或设置红包祝福语。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wishing")]
        [System.Text.Json.Serialization.JsonPropertyName("wishing")]
        public string? Wishing { get; set; }

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
        /// 获取或设置企业微信支付接口签名。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("workwx_sign")]
        [System.Text.Json.Serialization.JsonPropertyName("workwx_sign")]
        public string? WeWorkSign { get; set; }
    }
}
