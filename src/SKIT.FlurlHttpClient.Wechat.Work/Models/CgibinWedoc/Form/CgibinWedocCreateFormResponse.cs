namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/create_form 接口的响应。</para>
    /// </summary>
    public class CgibinWedocCreateFormResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置收集表 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("formid")]
        [System.Text.Json.Serialization.JsonPropertyName("formid")]
        public string FormId { get; set; } = default!;
    }
}
