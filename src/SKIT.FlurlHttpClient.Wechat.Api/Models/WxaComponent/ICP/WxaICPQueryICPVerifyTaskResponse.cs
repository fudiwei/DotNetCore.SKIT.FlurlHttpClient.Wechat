namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/icp/query_icp_verifytask 接口的响应。</para>
    /// </summary>
    public class WxaICPQueryICPVerifyTaskResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置是否已完成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_finish")]
        [System.Text.Json.Serialization.JsonPropertyName("is_finish")]
        public bool IsFinished { get; set; }

        /// <summary>
        /// 获取或设置任务状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("face_status")]
        [System.Text.Json.Serialization.JsonPropertyName("face_status")]
        public int FaceStatus { get; set; }
    }
}
