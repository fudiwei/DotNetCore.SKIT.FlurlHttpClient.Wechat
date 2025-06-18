namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/store/classification/tree/product/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECStoreClassificationTreeProductGetRequest : WechatApiRequest, IInferable<ChannelsECStoreClassificationTreeProductGetRequest, ChannelsECStoreClassificationTreeProductGetResponse>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置一级分类 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("level_1_id")]
                [System.Text.Json.Serialization.JsonPropertyName("level_1_id")]
                public long Level1ClassificationId { get; set; }

                /// <summary>
                /// 获取或设置二级分类 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("level_2_id")]
                [System.Text.Json.Serialization.JsonPropertyName("level_2_id")]
                public long Level2ClassificationId { get; set; }

                /// <summary>
                /// 获取或设置分页每页数量。
                /// <para>默认值：10</para>
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_size")]
                [System.Text.Json.Serialization.JsonPropertyName("page_size")]
                public int Limit { get; set; } = 10;

                /// <summary>
                /// 获取或设置分页游标。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_context")]
                [System.Text.Json.Serialization.JsonPropertyName("page_context")]
                public string? Cursor { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置请求数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("req")]
        [System.Text.Json.Serialization.JsonPropertyName("req")]
        public Types.Data Data { get; set; } = new Types.Data();
    }
}
