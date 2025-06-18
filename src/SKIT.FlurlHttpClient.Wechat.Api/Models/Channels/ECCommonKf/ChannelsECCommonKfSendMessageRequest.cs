namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/commkf/sendmsg 接口的请求。</para>
    /// </summary>
    public class ChannelsECCommonKfSendMessageRequest : WechatApiRequest, IInferable<ChannelsECCommonKfSendMessageRequest, ChannelsECCommonKfSendMessageResponse>
    {
        public static class Types
        {
            public class TextMessage
            {
                /// <summary>
                /// 获取或设置文本内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public string Content { get; set; } = string.Empty;
            }

            public class ImageMessage
            {
                /// <summary>
                /// 获取或设置图片 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cos_url")]
                [System.Text.Json.Serialization.JsonPropertyName("cos_url")]
                public string CosUrl { get; set; } = string.Empty;
            }

            public class FileMessage
            {
                /// <summary>
                /// 获取或设置文件 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cos_url")]
                [System.Text.Json.Serialization.JsonPropertyName("cos_url")]
                public string CosUrl { get; set; } = string.Empty;
            }

            public class OrderShareMessage
            {
                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public string OrderId { get; set; } = string.Empty;
            }

            public class ProductShareMessage
            {
                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                public string ProductId { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置唯一任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("request_id")]
        [System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_id")]
        [System.Text.Json.Serialization.JsonPropertyName("open_id")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置消息类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg_type")]
        [System.Text.Json.Serialization.JsonPropertyName("msg_type")]
        public string MessageType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置文本消息内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("text")]
        [System.Text.Json.Serialization.JsonPropertyName("text")]
        public Types.TextMessage? MessageContentForText { get; set; }

        /// <summary>
        /// 获取或设置图片消息内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image")]
        [System.Text.Json.Serialization.JsonPropertyName("image")]
        public Types.ImageMessage? MessageContentForImage { get; set; }

        /// <summary>
        /// 获取或设置文件消息内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file")]
        [System.Text.Json.Serialization.JsonPropertyName("file")]
        public Types.FileMessage? MessageContentForFile { get; set; }

        /// <summary>
        /// 获取或设置订单分享卡片消息内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_share")]
        [System.Text.Json.Serialization.JsonPropertyName("order_share")]
        public Types.OrderShareMessage? MessageContentForOrderShare { get; set; }

        /// <summary>
        /// 获取或设置商品分享卡片消息内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_share")]
        [System.Text.Json.Serialization.JsonPropertyName("product_share")]
        public Types.ProductShareMessage? MessageContentForProductShare { get; set; }
    }
}
