namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/merchant/updatefreighttemplate 接口的请求。</para>
    /// </summary>
    public class ChannelsECMerchantUpdateFreightTemplateRequest : WechatApiRequest, IInferable<ChannelsECMerchantUpdateFreightTemplateRequest, ChannelsECMerchantUpdateFreightTemplateResponse>
    {
        public static class Types
        {
            public class FreightTemplate : ChannelsECMerchantAddFreightTemplateRequest.Types.FreightTemplate
            {
                /// <summary>
                /// 获取或设置运费模板 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_id")]
                [System.Text.Json.Serialization.JsonPropertyName("template_id")]
                public long TemplateId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置运费模板信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("freight_template")]
        [System.Text.Json.Serialization.JsonPropertyName("freight_template")]
        public Types.FreightTemplate FreightTemplate { get; set; } = new Types.FreightTemplate();
    }
}
