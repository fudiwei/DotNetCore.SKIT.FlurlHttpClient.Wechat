using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/security/trustdevice/approve 接口的请求。</para>
    /// </summary>
    public class CgibinSecurityTrustDeviceApproveRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置设备唯一标识列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_code_list")]
        [System.Text.Json.Serialization.JsonPropertyName("device_code_list")]
        public IList<string> DeviceCodeList { get; set; } = new List<string>();
    }
}
