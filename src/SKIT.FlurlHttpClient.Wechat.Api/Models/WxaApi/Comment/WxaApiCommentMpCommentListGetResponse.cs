namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxaapi/comment/mpcommentlist/get 接口的响应。</para>
    /// </summary>
    public class WxaApiCommentMpCommentListGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Comment
            {
                public static class Types
                {
                    public class OrderInfo
                    {
                        /// <summary>
                        /// 获取或设置商户单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("busiOrderId")]
                        [System.Text.Json.Serialization.JsonPropertyName("busiOrderId")]
                        public string BusinessOrderId { get; set; } = default!;
                    }

                    public class UserInfo
                    {
                        /// <summary>
                        /// 获取或设置用户的 OpenId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("openid")]
                        [System.Text.Json.Serialization.JsonPropertyName("openid")]
                        public string OpenId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置用户的昵称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("nickName")]
                        [System.Text.Json.Serialization.JsonPropertyName("nickName")]
                        public string Nickname { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置用户的头像 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("headImg")]
                        [System.Text.Json.Serialization.JsonPropertyName("headImg")]
                        public string HeadImageUrl { get; set; } = default!;
                    }

                    public class BusinessInfo
                    {
                        /// <summary>
                        /// 获取或设置小程序的 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("appid")]
                        [System.Text.Json.Serialization.JsonPropertyName("appid")]
                        public string OpenId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小程序的昵称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("nickName")]
                        [System.Text.Json.Serialization.JsonPropertyName("nickName")]
                        public string Nickname { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小程序的头像 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("headImg")]
                        [System.Text.Json.Serialization.JsonPropertyName("headImg")]
                        public string HeadImageUrl { get; set; } = default!;
                    }

                    public class ContentInfo
                    {
                        public static class Types
                        {
                            public class Media
                            {
                                /// <summary>
                                /// 获取或设置图片 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("img")]
                                [System.Text.Json.Serialization.JsonPropertyName("img")]
                                public string? ImageUrl { get; set; }

                                /// <summary>
                                /// 获取或设置缩略图 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("thumbImg")]
                                [System.Text.Json.Serialization.JsonPropertyName("thumbImg")]
                                public string? ImageThumbnailUrl { get; set; }

                                /// <summary>
                                /// 获取或设置视频 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("video")]
                                [System.Text.Json.Serialization.JsonPropertyName("video")]
                                public string? VideoUrl { get; set; }

                                /// <summary>
                                /// 获取或设置视频封面 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("videoCover")]
                                [System.Text.Json.Serialization.JsonPropertyName("videoCover")]
                                public string? VideoCoverUrl { get; set; }

                                /// <summary>
                                /// 获取或设置视频时长（单位:秒)。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("videoDuration")]
                                [System.Text.Json.Serialization.JsonPropertyName("videoDuration")]
                                public int? VideoDuration { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置评价内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("txt")]
                        [System.Text.Json.Serialization.JsonPropertyName("txt")]
                        public string Text { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置媒体文件列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("media")]
                        [System.Text.Json.Serialization.JsonPropertyName("media")]
                        public Types.Media[]? MediaList { get; set; }
                    }

                    public class ExtraInfo
                    {
                        /// <summary>
                        /// 获取或设置是否已发过差评客服会话。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("isAlreadySendTmpl")]
                        [System.Text.Json.Serialization.JsonPropertyName("isAlreadySendTmpl")]
                        public bool IsAlreadySendTemplate { get; set; }
                    }

                    public class ProductInfo
                    {
                        public static class Types
                        {
                            public class Product
                            {
                                /// <summary>
                                /// 获取或设置商品名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string Name { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品图片 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("picUrl")]
                                [System.Text.Json.Serialization.JsonPropertyName("picUrl")]
                                public string PictureUrl { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置商品列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("productList")]
                        [System.Text.Json.Serialization.JsonPropertyName("productList")]
                        public Types.Product[] ProductList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置评价 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("commentId")]
                [System.Text.Json.Serialization.JsonPropertyName("commentId")]
                public string CommentId { get; set; } = default!;

                /// <summary>
                /// 获取或设置金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                public int Amount { get; set; }

                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("orderId")]
                [System.Text.Json.Serialization.JsonPropertyName("orderId")]
                public string OrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置微信支付订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wxPayId")]
                [System.Text.Json.Serialization.JsonPropertyName("wxPayId")]
                public string WechatpayTransactionId { get; set; } = default!;

                /// <summary>
                /// 获取或设置支付时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("payTime")]
                [System.Text.Json.Serialization.JsonPropertyName("payTime")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long PayTimestamp { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("createTime")]
                [System.Text.Json.Serialization.JsonPropertyName("createTime")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置评价分数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("score")]
                [System.Text.Json.Serialization.JsonPropertyName("score")]
                public int Score { get; set; }

                /// <summary>
                /// 获取或设置评价商品信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("productInfo")]
                [System.Text.Json.Serialization.JsonPropertyName("productInfo")]
                public Types.ProductInfo ProductInfo { get; set; } = default!;

                /// <summary>
                /// 获取或设置商家订单信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("orderInfo")]
                [System.Text.Json.Serialization.JsonPropertyName("orderInfo")]
                public Types.OrderInfo? OrderInfo { get; set; }

                /// <summary>
                /// 获取或设置评价订单信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userInfo")]
                [System.Text.Json.Serialization.JsonPropertyName("userInfo")]
                public Types.UserInfo? UserInfo { get; set; }

                /// <summary>
                /// 获取或设置商家小程序信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bizInfo")]
                [System.Text.Json.Serialization.JsonPropertyName("bizInfo")]
                public Types.BusinessInfo? BusinessInfo { get; set; }

                /// <summary>
                /// 获取或设置评价内容信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public Types.ContentInfo ContentInfo { get; set; } = default!;

                /// <summary>
                /// 获取或设置评价额外信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("extInfo")]
                [System.Text.Json.Serialization.JsonPropertyName("extInfo")]
                public Types.ExtraInfo ExtraInfo { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置评价列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("commentList")]
        [System.Text.Json.Serialization.JsonPropertyName("commentList")]
        public Types.Comment[] CommentList { get; set; } = default!;

        /// <summary>
        /// 获取或设置评价总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total")]
        [System.Text.Json.Serialization.JsonPropertyName("total")]
        public int TotalCount { get; set; }

        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }
    }
}
