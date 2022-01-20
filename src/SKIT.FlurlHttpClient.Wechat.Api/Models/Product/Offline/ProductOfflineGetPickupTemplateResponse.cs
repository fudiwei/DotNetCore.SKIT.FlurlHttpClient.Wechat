namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/offline/get_pickup_template 接口的响应。</para>
    /// </summary>
    public class ProductOfflineGetPickupTemplateResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Template
            {
                public static class Types
                {
                    public class PickupTime
                    {
                        /// <summary>
                        /// 获取或设置开店时间的小时。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("start_business_hour")]
                        [System.Text.Json.Serialization.JsonPropertyName("start_business_hour")]
                        public int StartBusinessHour { get; set; }

                        /// <summary>
                        /// 获取或设置开店时间的分钟。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("start_business_minute")]
                        [System.Text.Json.Serialization.JsonPropertyName("start_business_minute")]
                        public int StartBusinessMinute { get; set; }

                        /// <summary>
                        /// 获取或设置关店时间的小时。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("end_business_hour")]
                        [System.Text.Json.Serialization.JsonPropertyName("end_business_hour")]
                        public int EndBusinessHour { get; set; }

                        /// <summary>
                        /// 获取或设置关店时间的分钟。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("end_business_minute")]
                        [System.Text.Json.Serialization.JsonPropertyName("end_business_minute")]
                        public int EndBusinessMinute { get; set; }

                        /// <summary>
                        /// 获取或设置备货时间（单位：分钟）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promise_delivery_minutes")]
                        [System.Text.Json.Serialization.JsonPropertyName("promise_delivery_minutes")]
                        public int PromiseDeliveryTime { get; set; }

                        /// <summary>
                        /// 获取或设置可预定时间（单位：分钟）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("book_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("book_time")]
                        public int BookTime { get; set; }
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
                public Types.PickupTime PickupTime { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置线下自提模板信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pickup_template")]
        [System.Text.Json.Serialization.JsonPropertyName("pickup_template")]
        public Types.Template Template { get; set; } = default!;
    }
}
