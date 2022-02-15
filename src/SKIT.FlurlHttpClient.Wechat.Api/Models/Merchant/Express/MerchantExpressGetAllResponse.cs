namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /merchant/express/getall 接口的响应。</para>
    /// </summary>
    public class MerchantExpressGetAllResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Template : MerchantExpressGetByIdResponse.Types.Template
            {
            }
        }

        /// <summary>
        /// 获取或设置邮费模板列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("templates_info")]
        [System.Text.Json.Serialization.JsonPropertyName("templates_info")]
        public Types.Template[] TemplateList { get; set; } = default!;
    }
}
