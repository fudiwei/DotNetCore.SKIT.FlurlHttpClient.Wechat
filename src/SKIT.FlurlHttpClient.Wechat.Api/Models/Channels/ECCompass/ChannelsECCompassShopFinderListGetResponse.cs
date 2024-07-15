namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/compass/shop/finder/list/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECCompassShopFinderListGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Finder
            {
                public static class Types
                {
                    public class Data
                    {
                        /// <summary>
                        /// 获取或设置成交金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_gmv")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_gmv")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long PayGMV { get; set; }

                        /// <summary>
                        /// 获取或设置成交人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_uv")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_uv")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int PayUV { get; set; }

                        /// <summary>
                        /// 获取或设置成交退款金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_refund_gmv")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_refund_gmv")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long PayRefundGMV { get; set; }

                        /// <summary>
                        /// 获取或设置动销商品数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_product_id_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_product_id_cnt")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int PayProductCount { get; set; }

                        /// <summary>
                        /// 获取或设置退款金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_gmv")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_gmv")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long RefundGMV { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置视频号 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("finder_id")]
                [System.Text.Json.Serialization.JsonPropertyName("finder_id")]
                public string FinderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置视频号昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("finder_nickname")]
                [System.Text.Json.Serialization.JsonPropertyName("finder_nickname")]
                public string FinderNickname { get; set; } = default!;

                /// <summary>
                /// 获取或设置统计数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("data")]
                [System.Text.Json.Serialization.JsonPropertyName("data")]
                public Types.Data Data { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置视频号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finder_list")]
        [System.Text.Json.Serialization.JsonPropertyName("finder_list")]
        public Types.Finder[] FinderList { get; set; } = default!;
    }
}
