namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/qrcode/gen 接口的请求。</para>
    /// </summary>
    public class ProductQrcodeGenerateRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置需要验证的身份。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int Type { get; set; }
    }
}
