namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant/express/add 接口的响应。</para>
    /// </summary>
    public class MerchantExpressAddResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置邮费模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public int TemplateId { get; set; }
    }
}
