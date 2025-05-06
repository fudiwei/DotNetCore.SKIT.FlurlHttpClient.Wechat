using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/activity/add 接口的请求。</para>
    /// </summary>
    public class ChannelsECProductActivityAddRequest : WechatApiRequest, IInferable<ChannelsECProductActivityAddRequest, ChannelsECProductActivityAddResponse>
    {
        public static class Types
        {
            public class GiftActivity
            {
                public static class Types
                {
                    public class Detail
                    {
                        public static class Types
                        {
                            public class ReceiveLimit
                            {
                                /// <summary>
                                /// 获取或设置是否限领。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("is_limited")]
                                [System.Text.Json.Serialization.JsonPropertyName("is_limited")]
                                public bool IsLimited { get; set; }

                                /// <summary>
                                /// 获取或设置限领套数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("limit_num")]
                                [System.Text.Json.Serialization.JsonPropertyName("limit_num")]
                                public int LimitCount { get; set; }
                            }

                            public class MainProduct
                            {
                                /// <summary>
                                /// 获取或设置商品 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                                public long ProductId { get; set; }
                            }

                            public class GiftSet
                            {
                                public static class Types
                                {
                                    public class Gift
                                    {
                                        /// <summary>
                                        /// 获取或设置赠品 ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("gift_id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("gift_id")]
                                        public long GiftProductId { get; set; }

                                        /// <summary>
                                        /// 获取或设置赠品件数。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("give_num")]
                                        [System.Text.Json.Serialization.JsonPropertyName("give_num")]
                                        public int GiveCount { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置赠品列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("gift_items")]
                                [System.Text.Json.Serialization.JsonPropertyName("gift_items")]
                                public IList<Types.Gift> GiftList { get; set; } = new List<Types.Gift>();

                                /// <summary>
                                /// 获取或设置赠品总套数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("gift_set_num")]
                                [System.Text.Json.Serialization.JsonPropertyName("gift_set_num")]
                                public int GiftSetCount { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置场景值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("show_scene")]
                        [System.Text.Json.Serialization.JsonPropertyName("show_scene")]
                        public int ShowScene { get; set; }

                        /// <summary>
                        /// 获取或设置场景值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("receive_limit")]
                        [System.Text.Json.Serialization.JsonPropertyName("receive_limit")]
                        public Types.ReceiveLimit ReceiveLimit { get; set; } = new Types.ReceiveLimit();

                        /// <summary>
                        /// 获取或设置主商品列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("main_products")]
                        [System.Text.Json.Serialization.JsonPropertyName("main_products")]
                        public IList<Types.MainProduct> MainProductList { get; set; } = new List<Types.MainProduct>();

                        /// <summary>
                        /// 获取或设置赠品套装信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("gift_set")]
                        [System.Text.Json.Serialization.JsonPropertyName("gift_set")]
                        public Types.GiftSet GiftSet { get; set; } = new Types.GiftSet();
                    }
                }

                /// <summary>
                /// 获取或设置买赠活动 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("activity_id")]
                [System.Text.Json.Serialization.JsonPropertyName("activity_id")]
                public long? ActivityId { get; set; }

                /// <summary>
                /// 获取或设置买赠活动标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string Title { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置买赠活动开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_time")]
                [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                public long StartTimestamp { get; set; }

                /// <summary>
                /// 获取或设置买赠活动开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                public long EndTimestamp { get; set; }

                /// <summary>
                /// 获取或设置买赠活动详情。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("detail")]
                [System.Text.Json.Serialization.JsonPropertyName("detail")]
                public Types.Detail Detail { get; set; } = new Types.Detail();
            }
        }

        /// <summary>
        /// 获取或设置买赠活动信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gift_activity")]
        [System.Text.Json.Serialization.JsonPropertyName("gift_activity")]
        public Types.GiftActivity GiftActivity { get; set; } = new Types.GiftActivity();
    }
}
