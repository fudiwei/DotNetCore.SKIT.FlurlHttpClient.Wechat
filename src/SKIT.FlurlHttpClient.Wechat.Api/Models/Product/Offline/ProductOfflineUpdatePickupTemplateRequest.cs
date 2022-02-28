namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/offline/update_pickup_template 接口的请求。</para>
    /// </summary>
    public class ProductOfflineUpdatePickupTemplateRequest : WechatApiRequest, IInferable<ProductOfflineUpdatePickupTemplateRequest, ProductOfflineUpdatePickupTemplateResponse>
    {
        public static class Types
        {
            public class Template
            {
                public static class Types
                {
                    public class PickupTime : ProductOfflineGetPickupTemplateResponse.Types.Template.Types.PickupTime
                    {
                    }
                }

                /// <summary>
                /// 获取或设置模板 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_id")]
                [System.Text.Json.Serialization.JsonPropertyName("template_id")]
                public int TemplateId { get; set; }

                /// <summary>
                /// 获取或设置自提时间信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pickup_time")]
                [System.Text.Json.Serialization.JsonPropertyName("pickup_time")]
                public Types.PickupTime PickupTime { get; set; } = new Types.PickupTime();
            }
        }

        /// <summary>
        /// 获取或设置线下自提模板信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pickup_template")]
        [System.Text.Json.Serialization.JsonPropertyName("pickup_template")]
        public Types.Template Template { get; set; } = new Types.Template();
    }
}
