using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/getliveinfo 接口的响应。</para>
    /// </summary>
    public class WxaBusinessGetLiveInfoResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Room
            {
                public static class Types
                {
                    public class Goods
                    {
                        /// <summary>
                        /// 获取或设置商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("goods_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("goods_id")]
                        public int GoodsId { get; set; }

                        /// <summary>
                        /// 获取或设置商品名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小程序商品详情页路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("url")]
                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                        public string PagePath { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品封面图 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cover_img")]
                        [System.Text.Json.Serialization.JsonPropertyName("cover_img")]
                        public string CoverImageUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置价格类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("price_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("price_type")]
                        public int PriceType { get; set; }

                        /// <summary>
                        /// 获取或设置价格 1（单位：元）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("price")]
                        [System.Text.Json.Serialization.JsonPropertyName("price")]
                        public double Price1 { get; set; }

                        /// <summary>
                        /// 获取或设置价格 2（单位：元）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("price2")]
                        [System.Text.Json.Serialization.JsonPropertyName("price2")]
                        public double Price2 { get; set; }

                        /// <summary>
                        /// 获取或设置第三方小程序 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("third_party_appid")]
                        [System.Text.Json.Serialization.JsonPropertyName("third_party_appid")]
                        public string? ThirdPartyAppId { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置直播间 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("roomid")]
                [System.Text.Json.Serialization.JsonPropertyName("roomid")]
                public long RoomId { get; set; }

                /// <summary>
                /// 获取或设置直播间名字。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置直播间背景图 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cover_img")]
                [System.Text.Json.Serialization.JsonPropertyName("cover_img")]
                public string CoverImageUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置分享图 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("share_img")]
                [System.Text.Json.Serialization.JsonPropertyName("share_img")]
                public string ShareImageUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置直播间类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("live_type")]
                [System.Text.Json.Serialization.JsonPropertyName("live_type")]
                public int LiveType { get; set; }

                /// <summary>
                /// 获取或设置直播间状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("live_status")]
                [System.Text.Json.Serialization.JsonPropertyName("live_status")]
                public int LiveStatus { get; set; }

                /// <summary>
                /// 获取或设置直播间开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_time")]
                [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                public long StartTimestamp { get; set; }

                /// <summary>
                /// 获取或设置直播间计划结束时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                public long EndTimestamp { get; set; }

                /// <summary>
                /// 获取或设置主播昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("anchor_name")]
                [System.Text.Json.Serialization.JsonPropertyName("anchor_name")]
                public string AnchorName { get; set; } = default!;

                /// <summary>
                /// 获取或设置创建者 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("creater_openid")]
                [System.Text.Json.Serialization.JsonPropertyName("creater_openid")]
                public string? CreatorOpenId { get; set; }

                /// <summary>
                /// 获取或设置官方收录封面 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("feeds_img")]
                [System.Text.Json.Serialization.JsonPropertyName("feeds_img")]
                public string FeedsImageUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否开启官方收录。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_feeds_public")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("is_feeds_public")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                public bool IsFeedsPublic { get; set; }

                /// <summary>
                /// 获取或设置是否关闭点赞。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("close_like")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("close_like")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                public bool IsCloseLike { get; set; }

                /// <summary>
                /// 获取或设置是否关闭货架。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("close_goods")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("close_goods")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                public bool IsCloseGoods { get; set; }

                /// <summary>
                /// 获取或设置商品列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods")]
                [System.Text.Json.Serialization.JsonPropertyName("goods")]
                public Types.Goods[]? GoodsList { get; set; }

                /// <summary>
                /// 获取或设置是否关闭评论。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("close_comment")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("close_comment")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                public bool IsCloseComment { get; set; }

                /// <summary>
                /// 获取或设置是否关闭回放。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("close_replay")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("close_replay")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                public bool IsCloseReplay { get; set; }

                /// <summary>
                /// 获取或设置是否关闭客服。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("close_kf")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("close_kf")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                public bool IsCloseKf { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置房间列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("room_info")]
        [System.Text.Json.Serialization.JsonPropertyName("room_info")]
        public Types.Room[] RoomList { get; set; } = default!;

        /// <summary>
        /// 获取或设置房间总数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total")]
        [System.Text.Json.Serialization.JsonPropertyName("total")]
        public int Total { get; set; }
    }
}
