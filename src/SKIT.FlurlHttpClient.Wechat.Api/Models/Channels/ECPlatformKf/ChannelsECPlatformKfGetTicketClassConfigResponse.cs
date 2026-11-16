namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/platformkf/getticketclassconfig 接口的响应。</para>
    /// </summary>
    public class ChannelsECPlatformKfGetTicketClassConfigResponse : WechatApiResponse
    {
        public static class Types
        {
            public class MerchantReplyOptions
            {
                public static class Types
                {
                    public class Configuration
                    {
                        public static class Types
                        {
                            public class Option
                            {
                                /// <summary>
                                /// 获取或设置工单回复选项 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("option_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("option_id")]
                                public int OptionId { get; set; }

                                /// <summary>
                                /// 获取或设置工单回复名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("option_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("option_name")]
                                public string? OptionName { get; set; }

                                /// <summary>
                                /// 获取或设置补充说明是否必填。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("is_must_description")]
                                [System.Text.Json.Serialization.JsonPropertyName("is_must_description")]
                                public bool IsMustDescription { get; set; }

                                /// <summary>
                                /// 获取或设置图片视频凭证是否必填。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("is_must_urls")]
                                [System.Text.Json.Serialization.JsonPropertyName("is_must_urls")]
                                public bool IsMustUrls { get; set; }

                                /// <summary>
                                /// 获取或设置协商时间是否必填。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("is_must_confer_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("is_must_confer_time")]
                                public bool IsMustConferTime { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置工单分类类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ticket_class_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("ticket_class_type")]
                        public int TicketClassType { get; set; }

                        /// <summary>
                        /// 获取或设置工单分类名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ticket_class_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("ticket_class_name")]
                        public string? TicketClassName { get; set; }

                        /// <summary>
                        /// 获取或设置可选回复配置。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("option_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("option_list")]
                        public List<Types.Option>? OptionList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置分类配置列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("conf_list")]
                [System.Text.Json.Serialization.JsonPropertyName("conf_list")]
                public List<Types.Configuration>? ConfigurationList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商家回复选项配置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_reply_options")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_reply_options")]
        public Types.MerchantReplyOptions? MerchantReplyOptions { get; set; }
    }
}
