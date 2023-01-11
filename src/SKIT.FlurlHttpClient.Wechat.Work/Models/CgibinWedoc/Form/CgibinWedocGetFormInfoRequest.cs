namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/get_form_info 接口的请求。</para>
    /// </summary>
    public class CgibinWedocGetFormInfoRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置收集表 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("formid")]
        [System.Text.Json.Serialization.JsonPropertyName("formid")]
        public string FormId { get; set; } = string.Empty;
    }
}
