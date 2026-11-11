namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global.Models
{
    /// <summary>
    /// <para>表示 [POST] /transactions/native 接口的响应。</para>
    /// </summary>
    public class CreateTransactionNativeResponse : WechatTenpayGlobalResponse
    {
        /// <summary>
        /// 获取或设置二维码链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code_url")]
        [System.Text.Json.Serialization.JsonPropertyName("code_url")]
        public string? QrcodeUrl { get; set; }
    }
}
