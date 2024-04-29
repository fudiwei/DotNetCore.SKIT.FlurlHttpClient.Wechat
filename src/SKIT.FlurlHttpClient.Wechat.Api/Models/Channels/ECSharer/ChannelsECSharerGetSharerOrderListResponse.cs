namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/sharer/get_sharer_order_list 接口的响应。</para>
    /// </summary>
    public class ChannelsECSharerGetSharerOrderListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Order
            {
                public static class Types
                {
                    public class FinderScene
                    {
                        /// <summary>
                        /// 获取或设置视频号 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promoter_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("promoter_id")]
                        public string PromoterId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置视频号昵称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("finder_nickname")]
                        [System.Text.Json.Serialization.JsonPropertyName("finder_nickname")]
                        public string FinderNickname { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置直播间唯一标识。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("live_export_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("live_export_id")]
                        public string? LiveExportId { get; set; }

                        /// <summary>
                        /// 获取或设置短视频唯一标识。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("video_export_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("video_export_id")]
                        public string? VideoExportId { get; set; }

                        /// <summary>
                        /// 获取或设置短视频标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("video_title")]
                        [System.Text.Json.Serialization.JsonPropertyName("video_title")]
                        public string? VideoTitle { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string OrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置分享场景值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("share_scene")]
                [System.Text.Json.Serialization.JsonPropertyName("share_scene")]
                public int ShareScene { get; set; }

                /// <summary>
                /// 获取或设置分享员 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sharer_openid")]
                [System.Text.Json.Serialization.JsonPropertyName("sharer_openid")]
                public string SharerOpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置分享员类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sharer_type")]
                [System.Text.Json.Serialization.JsonPropertyName("sharer_type")]
                public int SharerType { get; set; }

                /// <summary>
                /// 获取或设置视频号场景信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("finder_scene_info")]
                [System.Text.Json.Serialization.JsonPropertyName("finder_scene_info")]
                public Types.FinderScene? FinderScene { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置订单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_list")]
        [System.Text.Json.Serialization.JsonPropertyName("order_list")]
        public Types.Order[] OrderList { get; set; } = default!;
    }
}
