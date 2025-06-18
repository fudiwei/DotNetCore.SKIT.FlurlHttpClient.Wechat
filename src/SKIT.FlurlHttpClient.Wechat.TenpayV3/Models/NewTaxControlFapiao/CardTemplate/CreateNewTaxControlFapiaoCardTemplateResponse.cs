namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /new-tax-control-fapiao/card-template 接口的响应。</para>
    /// </summary>
    public class CreateNewTaxControlFapiaoCardTemplateResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("card_appid")]
        public string CardAppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置卡券模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
        public string CardTemplateId { get; set; } = default!;
    }
}
