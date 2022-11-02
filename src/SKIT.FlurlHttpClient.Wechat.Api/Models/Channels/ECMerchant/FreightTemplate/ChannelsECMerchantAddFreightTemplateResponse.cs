namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/merchant/addfreighttemplate 接口的响应。</para>
    /// </summary>
    public class ChannelsECMerchantAddFreightTemplateResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置运费模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public long TemplateId { get; set; }
    }
}
