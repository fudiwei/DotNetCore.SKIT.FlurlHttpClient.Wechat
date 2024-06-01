namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/advanced_feature/get_apply_id_list 接口的请求。</para>
    /// </summary>
    public class CgibinAdvancedFeatureGetApplyIdListRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置申请的高级账号类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_type")]
        [System.Text.Json.Serialization.JsonPropertyName("business_type")]
        public int BusinessType { get; set; }

        /// <summary>
        /// 获取或设置申请的成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置申请类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("req_type")]
        [System.Text.Json.Serialization.JsonPropertyName("req_type")]
        public int? RequestType { get; set; }

        /// <summary>
        /// 获取或设置分页游标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }
    }
}
