namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/getapprovalinfo 接口的响应。</para>
    /// </summary>
    public class CgibinOAGetApprovalInfoResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置审批单号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_no_list")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_no_list")]
        public string[] ApprovalNumberList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public int? NextCursor { get; set; }
    }
}
