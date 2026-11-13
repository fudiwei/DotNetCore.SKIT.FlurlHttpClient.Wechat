namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/book/querybookauthv2 接口的请求。</para>
    /// </summary>
    public class WxaBookQueryBookAuthV2Request : WechatApiRequest, IInferable<WxaBookQueryBookAuthV2Request, WxaBookQueryBookAuthV2Response>
    {
        /// <summary>
        /// 获取或设置作品 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("book_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("book_ids")]
        public List<string>? BookIdList { get; set; }

        /// <summary>
        /// 获取或设置主授权账号 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("grantor_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("grantor_appid")]
        public string? GrantorAppId { get; set; }

        /// <summary>
        /// 获取或设置查询类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int? Type { get; set; }

        /// <summary>
        /// 获取或设置分页游标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("count")]
        [System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Limit { get; set; }
    }
}
