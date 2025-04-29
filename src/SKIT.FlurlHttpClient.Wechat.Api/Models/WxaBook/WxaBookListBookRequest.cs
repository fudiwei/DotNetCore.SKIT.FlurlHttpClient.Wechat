namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/book/listbook 接口的请求。</para>
    /// </summary>
    public class WxaBookListBookRequest : WechatApiRequest, IInferable<WxaBookListBookRequest, WxaBookListBookResponse>
    {
        /// <summary>
        /// 获取或设置是否返回编辑版信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_edited_data")]
        [System.Text.Json.Serialization.JsonPropertyName("need_edited_data")]
        public bool? IsNeedEditedData { get; set; }

        /// <summary>
        /// 获取或设置分页起始 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("last_id")]
        [System.Text.Json.Serialization.JsonPropertyName("last_id")]
        public long? LastId { get; set; }

        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }
    }
}
