namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/openhw/model/register_sn 接口的响应。</para>
    /// </summary>
    public class CgibinOpenHardwareModelRegisterSerialNumberResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置设备二维码数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qr_code")]
        [System.Text.Json.Serialization.JsonPropertyName("qr_code")]
        public string QrcodeData { get; set; } = default!;
    }
}
