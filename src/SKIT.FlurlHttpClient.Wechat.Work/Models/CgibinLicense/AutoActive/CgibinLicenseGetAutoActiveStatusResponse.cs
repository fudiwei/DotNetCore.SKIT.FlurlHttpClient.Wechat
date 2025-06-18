namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/license/get_auto_active_status 接口的响应。</para>
    /// </summary>
    public class CgibinLicenseGetAutoActiveStatusResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置许可自动激活状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auto_active_status")]
        [System.Text.Json.Serialization.JsonPropertyName("auto_active_status")]
        public int AutoActiveStatus { get; set; }
    }
}
