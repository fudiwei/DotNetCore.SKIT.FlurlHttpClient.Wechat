using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/logistics/ewaybill/biz/template/create 接口的请求。</para>
    /// </summary>
    public class ChannelsECLogisticsEWaybillTemplateCreateRequest : WechatApiRequest, IInferable<ChannelsECLogisticsEWaybillTemplateCreateRequest, ChannelsECLogisticsEWaybillTemplateCreateResponse>
    {
        public static class Types
        {
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
                        public bool? IsBold { get; set; }

                        /// <summary>
                        /// 获取或设置是否选用此信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_open")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_open")]
                        public bool? IsOpen { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置模板类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_type")]
                [System.Text.Json.Serialization.JsonPropertyName("template_type")]
                public string Type { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置模板名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_name")]
                [System.Text.Json.Serialization.JsonPropertyName("template_name")]
                public string Name { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置模板描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_desc")]
                [System.Text.Json.Serialization.JsonPropertyName("template_desc")]
                public string Description { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置模板信息选项。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("options")]
                [System.Text.Json.Serialization.JsonPropertyName("options")]
                public IList<Types.Option> Options { get; set; } = new List<Types.Option>();

                /// <summary>
                /// 获取或设置是否为该快递公司默认模板。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_default")]
                [System.Text.Json.Serialization.JsonPropertyName("is_default")]
                public bool IsDefault { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置快递公司 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_id")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
        public string DeliveryId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置模板信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("info")]
        [System.Text.Json.Serialization.JsonPropertyName("info")]
        public Types.Template Template { get; set; } = new Types.Template();
    }
}
