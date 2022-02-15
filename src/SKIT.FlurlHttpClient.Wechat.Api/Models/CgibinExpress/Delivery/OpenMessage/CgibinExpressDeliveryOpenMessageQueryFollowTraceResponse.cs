namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/delivery/open_msg/query_follow_trace 接口的响应。</para>
    /// </summary>
    public class CgibinExpressDeliveryOpenMessageQueryFollowTraceResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Waybill
            {
                /// <summary>
                /// 获取或设置运单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("waybill_id")]
                [System.Text.Json.Serialization.JsonPropertyName("waybill_id")]
                public string WaybillId { get; set; } = default!;

                /// <summary>
                /// 获取或设置运单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }
            }

            public class Shop
            {
                public static class Types
                {
                    public class Goods
                    {
                        public static class Types
                        {
                            public class Detail
                            {
                                /// <summary>
                                /// 获取或设置商品名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("goods_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("goods_name")]
                                public string GoodsName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品图片 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("goods_img_url")]
                                [System.Text.Json.Serialization.JsonPropertyName("goods_img_url")]
                                public string GoodsImageUrl { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品详情描述。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("goods_desc")]
                                [System.Text.Json.Serialization.JsonPropertyName("goods_desc")]
                                public string? GoodsDescription { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置商品详情列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("detail_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("detail_list")]
                        public Types.Detail[] DetailList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置商品信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_info")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_info")]
                public Types.Goods? Goods { get; set; }
            }

            public class Delivery
            {
                /// <summary>
                /// 获取或设置快递公司 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_id")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
                public string DeliveryId { get; set; } = default!;

                /// <summary>
                /// 获取或设置快递公司名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_name")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_name")]
                public string DeliveryName { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置运单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waybill_info")]
        [System.Text.Json.Serialization.JsonPropertyName("waybill_info")]
        public Types.Waybill Waybill { get; set; } = default!;

        /// <summary>
        /// 获取或设置店铺信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_info")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_info")]
        public Types.Shop? Shop { get; set; }

        /// <summary>
        /// 获取或设置快递信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_info")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_info")]
        public Types.Delivery? Delivery { get; set; }
    }
}
