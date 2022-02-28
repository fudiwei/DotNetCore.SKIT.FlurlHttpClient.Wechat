namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/delivery/update_freight_template 接口的请求。</para>
    /// </summary>
    public class ProductDeliveryUpdateFreightTemplateRequest : WechatApiRequest, IInferable<ProductDeliveryUpdateFreightTemplateRequest, ProductDeliveryUpdateFreightTemplateResponse>
    {
        public static class Types
        {
            public class Template : ProductDeliveryInsertFreightTemplateRequest.Types.Template
            {
                /// <summary>
                /// 获取或设置模板 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_id")]
                [System.Text.Json.Serialization.JsonPropertyName("template_id")]
                public int TemplateId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置运费模板信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("freight_template")]
        [System.Text.Json.Serialization.JsonPropertyName("freight_template")]
        public Types.Template Template { get; set; } = new Types.Template();
    }
}
