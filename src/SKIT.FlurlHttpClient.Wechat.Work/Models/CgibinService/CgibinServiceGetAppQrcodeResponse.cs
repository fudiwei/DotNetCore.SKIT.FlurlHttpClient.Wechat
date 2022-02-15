namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/service/get_app_qrcode 接口的响应。</para>
    /// </summary>
    public class CgibinServiceGetAppQrcodeResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置二维码 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qrcode")]
        [System.Text.Json.Serialization.JsonPropertyName("qrcode")]
        public string? QrcodeUrl { get; set; }

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && RawBytes?.Length > 0;
        }
    }
}
