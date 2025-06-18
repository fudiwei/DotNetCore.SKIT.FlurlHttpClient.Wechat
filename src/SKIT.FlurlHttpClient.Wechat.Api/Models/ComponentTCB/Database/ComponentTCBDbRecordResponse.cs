namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/dbrecord 接口的响应。</para>
    /// </summary>
    public class ComponentTCBDbRecordResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Pagination
            {
                /// <summary>
                /// 获取或设置分页起始位置。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("offset")]
                [System.Text.Json.Serialization.JsonPropertyName("offset")]
                public int Offset { get; set; }

                /// <summary>
                /// 获取或设置分页每页数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("limit")]
                [System.Text.Json.Serialization.JsonPropertyName("limit")]
                public int Limit { get; set; }

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int TotalCount { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置插入成功的数据集合主键 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("id_list")]
        public string[]? IdList { get; set; }

        /// <summary>
        /// 获取或设置查询分页信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pager")]
        [System.Text.Json.Serialization.JsonPropertyName("pager")]
        public Types.Pagination? Pagination { get; set; }

        /// <summary>
        /// 获取或设置查询数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public string[]? Data { get; set; }

        /// <summary>
        /// 获取或设置修改记录数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("modified")]
        [System.Text.Json.Serialization.JsonPropertyName("modified")]
        public int? ModifiedCount { get; set; }

        /// <summary>
        /// 获取或设置匹配记录数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("matched")]
        [System.Text.Json.Serialization.JsonPropertyName("matched")]
        public int? MatchedCount { get; set; }

        /// <summary>
        /// 获取或设置新插入记录的 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 获取或设置删除记录数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deleted")]
        [System.Text.Json.Serialization.JsonPropertyName("deleted")]
        public int? DeletedCount { get; set; }
    }
}
