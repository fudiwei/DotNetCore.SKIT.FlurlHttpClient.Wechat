namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/advanced_feature/get_apply_id_list 接口的响应。</para>
    /// </summary>
    public class CgibinAdvancedFeatureGetApplyIdListResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置申请 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apply_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("apply_id_list")]
        public string[] ApplyIdList { get; set; } = default!;

        /// <summary>
        /// 获取或设置分页游标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// 获取或设置是否还有更多数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool HasMore { get; set; }
    }
}
