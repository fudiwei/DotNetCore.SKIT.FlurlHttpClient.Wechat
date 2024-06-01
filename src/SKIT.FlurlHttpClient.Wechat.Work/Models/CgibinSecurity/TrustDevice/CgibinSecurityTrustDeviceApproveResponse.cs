namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/security/trustdevice/approve 接口的响应。</para>
    /// </summary>
    public class CgibinSecurityTrustDeviceApproveResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置操作成功的设备唯一标识列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("success_list")]
        [System.Text.Json.Serialization.JsonPropertyName("success_list")]
        public string[]? SucceededDeviceCodeList { get; set; }

        /// <summary>
        /// 获取或设置操作失败的设备唯一标识列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_list")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_list")]
        public string[]? FailedDeviceCodeList { get; set; }
    }
}
