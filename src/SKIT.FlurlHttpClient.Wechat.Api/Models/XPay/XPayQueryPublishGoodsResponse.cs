namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/query_publish_goods 接口的响应。</para>
    /// </summary>
    public class XPayQueryPublishGoodsResponse : WechatApiResponse
    {
        public static class Types
        {
            public class PublishItem
            {
                /// <summary>
                /// 获取或设置道具 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public string Id { get; set; } = default!;

                /// <summary>
                /// 获取或设置发布状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("publish_status")]
                [System.Text.Json.Serialization.JsonPropertyName("publish_status")]
                public int PublishStatus { get; set; }

                /// <summary>
                /// 获取或设置发布失败原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errmsg")]
                [System.Text.Json.Serialization.JsonPropertyName("errmsg")]
                public string? FailReason { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置道具列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("publish_item")]
        [System.Text.Json.Serialization.JsonPropertyName("publish_item")]
        public Types.PublishItem[] PublishItemList { get; set; } = default!;

        /// <summary>
        /// 获取或设置发布状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }
    }
}
