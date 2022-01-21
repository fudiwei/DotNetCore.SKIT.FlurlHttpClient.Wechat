namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /mmpaymkttransfers/promotion/transfers 接口的请求。</para>
    /// </summary>
    public class CreatePayMarketingTransfersPromotionTransferRequest : WechatTenpaySignableRequest
    {
        /// <summary>
        /// 获取或设置微信商户号。如果不指定将使用构造 <see cref="WechatTenpayClient"/> 时的 <see cref="WechatTenpayClientOptions.MerchantId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("mchid")]
        public string? MerchantId { get; set; }

        /// <summary>
        /// 获取或设置微信 AppId。如果不指定将使用构造 <see cref="WechatTenpayClient"/> 时的 <see cref="WechatTenpayClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置商户订单号。
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
        public string Description { get; set; } = string.Empty;

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
        /// 获取或设置付款场景。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene")]
        [System.Text.Json.Serialization.JsonPropertyName("scene")]
        public string? Scene { get; set; }

        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_id")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
        public int? BrandId { get; set; }

        /// <summary>
        /// 获取或设置消息模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finder_template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("finder_template_id")]
        public string? FinderTemplateId { get; set; }
    }
}
