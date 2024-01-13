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
                public string DeliveryId { get; set; } = default!;

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
                public Types.Template[] Items { get; set; } = default!;
            }

            public class Template
            {
                public static class Types
                {
                    public class Option
                    {
                        /// <summary>
                        /// 获取或设置信息类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("option_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("option_id")]
                        public int OptionId { get; set; }

                        /// <summary>
                        /// 获取或设置打印字号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("font_size")]
                        [System.Text.Json.Serialization.JsonPropertyName("font_size")]
                        public int FontSize { get; set; }

                        /// <summary>
                        /// 获取或设置字体是否加粗。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_bold")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_bold")]
                        public bool IsBold { get; set; }

                        /// <summary>
                        /// 获取或设置是否选用此信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_open")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_open")]
                        public bool IsOpen { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置模板 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_id")]
                [System.Text.Json.Serialization.JsonPropertyName("template_id")]
                public string TemplateId { get; set; } = default!;

                /// <summary>
                /// 获取或设置模板类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_type")]
                [System.Text.Json.Serialization.JsonPropertyName("template_type")]
                public string Type { get; set; } = default!;

                /// <summary>
                /// 获取或设置模板名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_name")]
                [System.Text.Json.Serialization.JsonPropertyName("template_name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置模板描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_desc")]
                [System.Text.Json.Serialization.JsonPropertyName("template_desc")]
                public string Description { get; set; } = default!;

                /// <summary>
                /// 获取或设置模板信息选项列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("options")]
                [System.Text.Json.Serialization.JsonPropertyName("options")]
                public Types.Option[] Options { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否为该快递公司默认模板。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_default")]
                [System.Text.Json.Serialization.JsonPropertyName("is_default")]
                public bool IsDefault { get; set; }

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
        }

        /// <summary>
        /// 获取或设置模板列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_template")]
        [System.Text.Json.Serialization.JsonPropertyName("total_template")]
        public Types.TemplateList[] TemplateList { get; set; } = default!;
    }
}
