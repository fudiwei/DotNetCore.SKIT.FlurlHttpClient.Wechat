namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /channels/ec/qic/inspect/submitconfig/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECQICInspectSubmitConfigGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class SubmitConfig
            {
                public static class Types
                {
                    public class Delivery
                    {
                        public static class Types
                        {
                            public class DeliveryProduct
                            {
                                public static class Types
                                {
                                    public class Insure
                                    {
                                        /// <summary>
                                        /// 获取或设置保价类型 ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                                        public string Id { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置保价类型名称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("name")]
                                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                                        public string Name { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置上限类型。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("upper_limit_type")]
                                        [System.Text.Json.Serialization.JsonPropertyName("upper_limit_type")]
                                        public int UpperLimitType { get; set; }

                                        /// <summary>
                                        /// 获取或设置上限金额（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("upper_limit_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("upper_limit_amount")]
                                        public int? UpperLimitAmount { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置快递产品 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id")]
                                [System.Text.Json.Serialization.JsonPropertyName("id")]
                                public int Id { get; set; }

                                /// <summary>
                                /// 获取或设置快递产品名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string Name { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置保价类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("enable_insure")]
                                [System.Text.Json.Serialization.JsonPropertyName("enable_insure")]
                                public int Insure { get; set; }

                                /// <summary>
                                /// 获取或设置保价类型列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("insure_type_list")]
                                [System.Text.Json.Serialization.JsonPropertyName("insure_type_list")]
                                public Types.Insure[] InsureList { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置快递公司 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public string Id { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置快递公司名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置快递产品列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_products")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_products")]
                        public Types.DeliveryProduct[] DeliveryProductList { get; set; } = default!;
                    }

                    public class InspectOrganization
                    {
                        /// <summary>
                        /// 获取或设置质检机构 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public string Id { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置质检机构名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置快递公司列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_list")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_list")]
                public Types.Delivery[] DeliveryList { get; set; } = default!;

                /// <summary>
                /// 获取或设置质检机构信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("inspect_org_list")]
                [System.Text.Json.Serialization.JsonPropertyName("inspect_org_list")]
                public Types.InspectOrganization[] InspectOrganizationList { get; set; } = default!;

                /// <summary>
                /// 获取或设置资费标准 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("charge_url")]
                [System.Text.Json.Serialization.JsonPropertyName("charge_url")]
                public string? ChargeUrl { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置送检配置模板信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("submit_config")]
        [System.Text.Json.Serialization.JsonPropertyName("submit_config")]
        public Types.SubmitConfig SubmitConfig { get; set; } = default!;
    }
}
