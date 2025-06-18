using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/logistics/ewaybill/biz/template/config 接口的响应。</para>
    /// </summary>
    public class ChannelsECLogisticsEWaybillTemplateConfigResponse : WechatApiResponse
    {
        public static class Types
        {
            public class TemplateConfig
            {
                public static class Types
                {
                    public class Config
                    {
                        public static class Types
                        {
                            public class CustomConfig
                            {
                                /// <summary>
                                /// 获取或设置自定义区域宽度（单位：像素）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("width")]
                                [System.Text.Json.Serialization.JsonPropertyName("width")]
                                public int? Width { get; set; }

                                /// <summary>
                                /// 获取或设置自定义区域高度（单位：像素）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("height")]
                                [System.Text.Json.Serialization.JsonPropertyName("height")]
                                public int? Height { get; set; }

                                /// <summary>
                                /// 获取或设置自定义区域到顶部距离（单位：像素）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("top")]
                                [System.Text.Json.Serialization.JsonPropertyName("top")]
                                public int? Top { get; set; }

                                /// <summary>
                                /// 获取或设置自定义区域到左边距离（单位：像素）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("left")]
                                [System.Text.Json.Serialization.JsonPropertyName("left")]
                                public int? Left { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置模板类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public string Type { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置模板描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("desc")]
                        public string Description { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置面单宽度（单位：毫米）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("width")]
                        [System.Text.Json.Serialization.JsonPropertyName("width")]
                        public int Width { get; set; }

                        /// <summary>
                        /// 获取或设置面单高度（单位：毫米）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("height")]
                        [System.Text.Json.Serialization.JsonPropertyName("height")]
                        public int Height { get; set; }

                        /// <summary>
                        /// 获取或设置标准模板 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("url")]
                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                        public string Url { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置自定义模板配置。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("custom_config")]
                        [System.Text.Json.Serialization.JsonPropertyName("custom_config")]
                        public Types.CustomConfig? CustomConfig { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置一联单模板配置信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("single")]
                [System.Text.Json.Serialization.JsonPropertyName("single")]
                public Types.Config SingleConfig { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置模板配置信息字典。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("config")]
        [System.Text.Json.Serialization.JsonPropertyName("config")]
        public IDictionary<string, Types.TemplateConfig> TemplateConfigMap { get; set; } = default!;
    }
}
