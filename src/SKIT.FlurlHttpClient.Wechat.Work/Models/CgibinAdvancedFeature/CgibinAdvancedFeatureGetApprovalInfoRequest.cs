namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/advanced_feature/get_approval_info 接口的请求。</para>
    /// </summary>
    public class CgibinAdvancedFeatureGetApprovalInfoRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置申请 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apply_id")]
        [System.Text.Json.Serialization.JsonPropertyName("apply_id")]
        public string ApplyId { get; set; } = string.Empty;
    }
}
