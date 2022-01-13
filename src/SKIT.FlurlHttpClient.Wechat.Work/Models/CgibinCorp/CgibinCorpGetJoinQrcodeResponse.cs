namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/corp/get_join_qrcode 接口的响应。</para>
    /// </summary>
    public class CgibinCorpGetJoinQrcodeResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置二维码 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("join_qrcode")]
        [System.Text.Json.Serialization.JsonPropertyName("join_qrcode")]
        public string QrcodeUrl { get; set; } = default!;
    }
}
