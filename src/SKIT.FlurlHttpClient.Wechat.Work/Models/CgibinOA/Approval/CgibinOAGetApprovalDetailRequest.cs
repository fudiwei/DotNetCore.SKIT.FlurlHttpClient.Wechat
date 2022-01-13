namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/getapprovaldetail 接口的请求。</para>
    /// </summary>
    public class CgibinOAGetApprovalDetailRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置审批单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_no")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_no")]
        public string ApprovalNumber { get; set; } = string.Empty;
    }
}
