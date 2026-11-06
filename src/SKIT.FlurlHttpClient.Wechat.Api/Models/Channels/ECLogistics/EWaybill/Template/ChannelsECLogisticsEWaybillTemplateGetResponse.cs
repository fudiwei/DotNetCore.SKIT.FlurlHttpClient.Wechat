namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/logistics/ewaybill/biz/template/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECLogisticsEWaybillTemplateGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class TemplateList
            {
                /// <summary>
                /// 获取或设置快递公司 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_id")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
                public string? DeliveryId { get; set; }

                /// <summary>
                /// 获取或设置默认模板 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("default_template_id")]
                [System.Text.Json.Serialization.JsonPropertyName("default_template_id")]
                public string? DefaultTemplateId { get; set; }

                /// <summary>
                /// 获取或设置模板列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_list")]
                [System.Text.Json.Serialization.JsonPropertyName("template_list")]
                public List<Template>? Items { get; set; }
            }

            public abstract class __zz__Template : ChannelsECLogisticsEWaybillTemplateCreateRequest.Types.__zz__Template
            {
                /// <summary>
                /// 获取或设置模板 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_id")]
                [System.Text.Json.Serialization.JsonPropertyName("template_id")]
                public string? TemplateId { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                public long UpdateTimestamp { get; set; }
            }

            public class Template : __zz__Template
            {
                public static class Types
                {
                    public class Option : ChannelsECLogisticsEWaybillTemplateCreateRequest.Types.Template.Types.Option
                    {
                    }
                }

                /// <summary>
                /// 获取或设置模板信息选项列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("options")]
                [System.Text.Json.Serialization.JsonPropertyName("options")]
                public List<Types.Option>? OptionList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置模板列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_template")]
        [System.Text.Json.Serialization.JsonPropertyName("total_template")]
        public List<Types.TemplateList>? TemplateList { get; set; }
    }
}
