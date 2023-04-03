namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /mmpaymkttransfers/promotion/paywwsptrans2pocket 接口的请求。</para>
    /// </summary>
    public class CreatePayMarketingTransfersPromotionWeWorkTransferRequest : WechatTenpaySignableRequest
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
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public override string? AppId { get; set; }

        /// <summary>
        /// 获取或设置商户付款单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("partner_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("partner_trade_no")]
        public string PartnerTradeNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置付款的应用 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agentid")]
        [System.Text.Json.Serialization.JsonPropertyName("agentid")]
        public int? AgentId { get; set; }

        /// <summary>
        /// 获取或设置终端设备号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_info")]
        [System.Text.Json.Serialization.JsonPropertyName("device_info")]
        public string? DeviceInfo { get; set; }

        /// <summary>
        /// 获取或设置金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 获取或设置备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc")]
        [System.Text.Json.Serialization.JsonPropertyName("desc")]
        public string? Description { get; set; }

        /// <summary>
        /// 获取或设置校验用户姓名选项。
        /// <para>默认值：FORCE_CHECK</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("check_name")]
        [System.Text.Json.Serialization.JsonPropertyName("check_name")]
        public string CheckNameType { get; set; } = "FORCE_CHECK";

        /// <summary>
        /// 获取或设置收款用户姓名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("re_user_name")]
        [System.Text.Json.Serialization.JsonPropertyName("re_user_name")]
        public string? UserName { get; set; }

        /// <summary>
        /// 获取或设置用户终端 IP。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spbill_create_ip")]
        [System.Text.Json.Serialization.JsonPropertyName("spbill_create_ip")]
        public string ClientIp { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置付款消息类型。
        /// <para>默认值：NORMAL_MSG</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ww_msg_type")]
        [System.Text.Json.Serialization.JsonPropertyName("ww_msg_type")]
        public string MessageType { get; set; } = "NORMAL_MSG";

        /// <summary>
        /// 获取或设置审批单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("approval_number")]
        [System.Text.Json.Serialization.JsonPropertyName("approval_number")]
        public string? ApprovalNumber { get; set; }

        /// <summary>
        /// 获取或设置审批类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("approval_type")]
        [System.Text.Json.Serialization.JsonPropertyName("approval_type")]
        public int? ApprovalType { get; set; }

        /// <summary>
        /// 获取或设置活动名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("act_name")]
        [System.Text.Json.Serialization.JsonPropertyName("act_name")]
        public string? ActivityName { get; set; }

        /// <summary>
        /// 获取或设置企业微信支付接口签名。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("workwx_sign")]
        [System.Text.Json.Serialization.JsonPropertyName("workwx_sign")]
        public string? WeWorkSign { get; set; }
    }
}
