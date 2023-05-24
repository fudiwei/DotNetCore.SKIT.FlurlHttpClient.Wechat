namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/miniapppay/apply_mch 接口的响应。</para>
    /// </summary>
    public class CgibinMiniAppPayApplyMechantResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置错误描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("error_description")]
        [System.Text.Json.Serialization.JsonPropertyName("error_description")]
        public string? ErrorDescription { get; set; }
    }
}
