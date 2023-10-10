namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/miniapppay/get_sign 接口的响应。</para>
    /// </summary>
    public class CgibinMiniAppPayGetSignResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置签名值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_sign")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_sign")]
        public string PaySign { get; set; } = default!;
    }
}
