namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/servicemarket/service/get_service_buyer_list 接口的响应。</para>
    /// </summary>
    public class WxaServiceMarketServiceGetServiceBuyerListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Buyer
            {
                public static class Types
                {
                    public class Specification
                    {
                        /// <summary>
                        /// 获取或设置规格 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("specification_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("specification_id")]
                        public string SpecificationId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置过期时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("expire_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
                        public long ExpireTime { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置服务 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_id")]
                [System.Text.Json.Serialization.JsonPropertyName("service_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                public string ServiceId { get; set; } = default!;

                /// <summary>
                /// 获取或设置规格列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spec_list")]
                [System.Text.Json.Serialization.JsonPropertyName("spec_list")]
                public Types.Specification[]? SpecificationList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置服务用户列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("buyer_list")]
        [System.Text.Json.Serialization.JsonPropertyName("buyer_list")]
        public Types.Buyer[] BuyerList { get; set; } = default!;
    }
}
