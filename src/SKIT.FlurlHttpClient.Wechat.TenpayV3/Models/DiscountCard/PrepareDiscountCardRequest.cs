namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /discount-card/cards 接口的请求。</para>
    /// </summary>
    public class PrepareDiscountCardRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户领卡号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_card_code")]
        [System.Text.Json.Serialization.JsonPropertyName("out_card_code")]
        public string OutCardCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置先享卡模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_template_id")]
        public string CardTemplateId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置回调通知地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public string? NotifyUrl { get; set; }
    }
}
