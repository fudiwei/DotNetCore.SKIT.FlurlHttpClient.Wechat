namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxaapi/comment/commentinfo/get 接口的响应。</para>
    /// </summary>
    public class WxaApiCommentCommentInfoGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Comment : WxaApiCommentMpCommentListGetResponse.Types.__zz__Comment
                    {
                        public static class Types
                        {
                            public class OrderInfo : WxaApiCommentMpCommentListGetResponse.Types.Comment.Types.OrderInfo
                            {
                            }

                            public class UserInfo : WxaApiCommentMpCommentListGetResponse.Types.Comment.Types.UserInfo
                            {
                            }

                            public class BusinessInfo : WxaApiCommentMpCommentListGetResponse.Types.Comment.Types.BusinessInfo
                            {
                            }

                            public class ContentInfo : WxaApiCommentMpCommentListGetResponse.Types.Comment.Types.__zz__ContentInfo
                            {
                                public static class Types
                                {
                                    public class Media : WxaApiCommentMpCommentListGetResponse.Types.Comment.Types.ContentInfo.Types.Media
                                    {
                                    }
                                }

                                /// <summary>
                                /// 获取或设置媒体文件列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("media")]
                                [System.Text.Json.Serialization.JsonPropertyName("media")]
                                public List<Types.Media>? MediaList { get; set; }
                            }

                            public class ExtraInfo : WxaApiCommentMpCommentListGetResponse.Types.Comment.Types.ExtraInfo
                            {
                            }

                            public class ProductInfo
                            {
                                public static class Types
                                {
                                    public class Product : WxaApiCommentMpCommentListGetResponse.Types.Comment.Types.ProductInfo.Types.Product
                                    {
                                    }
                                }

                                /// <summary>
                                /// 获取或设置商品列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("productList")]
                                [System.Text.Json.Serialization.JsonPropertyName("productList")]
                                public List<Types.Product>? ProductList { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置评价商品信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("productInfo")]
                        [System.Text.Json.Serialization.JsonPropertyName("productInfo")]
                        public Types.ProductInfo? ProductInfo { get; set; }

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
                        public Types.ContentInfo? ContentInfo { get; set; }

                        /// <summary>
                        /// 获取或设置评价额外信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("extInfo")]
                        [System.Text.Json.Serialization.JsonPropertyName("extInfo")]
                        public Types.ExtraInfo? ExtraInfo { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置评价信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public Types.Comment? Comment { get; set; }
            }

            public class Process
            {
                public static class Types
                {
                    public class ActionInfo
                    {
                        /// <summary>
                        /// 获取或设置进度类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public int Type { get; set; }

                        /// <summary>
                        /// 获取或设置更新时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("updateTime")]
                        [System.Text.Json.Serialization.JsonPropertyName("updateTime")]
                        public long? UpdateTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置评价 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("commentId")]
                [System.Text.Json.Serialization.JsonPropertyName("commentId")]
                public string? CommentId { get; set; }

                /// <summary>
                /// 获取或设置进度信息列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("actionList")]
                [System.Text.Json.Serialization.JsonPropertyName("actionList")]
                public List<Types.ActionInfo>? ActionList { get; set; }
            }

            public class OldComment
            {
                public static class Types
                {
                    public class ContentInfo : Data.Types.Comment.Types.ContentInfo
                    {
                    }
                }

                /// <summary>
                /// 获取或设置评价 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("commentId")]
                [System.Text.Json.Serialization.JsonPropertyName("commentId")]
                public string? CommentId { get; set; }

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
                /// 获取或设置评价内容信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public Types.ContentInfo? ContentInfo { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("info")]
        [System.Text.Json.Serialization.JsonPropertyName("info")]
        public Types.Data? Data { get; set; }

        /// <summary>
        /// 获取或设置处理进度信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("processInfo")]
        [System.Text.Json.Serialization.JsonPropertyName("processInfo")]
        public Types.Process? Process { get; set; }

        /// <summary>
        /// 获取或设置旧评价信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("oldComment")]
        [System.Text.Json.Serialization.JsonPropertyName("oldComment")]
        public Types.OldComment? OldComment { get; set; }
    }
}
