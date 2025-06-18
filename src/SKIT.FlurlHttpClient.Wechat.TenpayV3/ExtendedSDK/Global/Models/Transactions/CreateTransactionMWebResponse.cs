namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global.Models
{
    /// <summary>
    /// <para>表示 [POST] /transactions/mweb 接口的响应。</para>
    /// </summary>
    public class CreateTransactionMWebResponse : WechatTenpayGlobalResponse
    {
        /// <summary>
        /// 获取或设置支付跳转链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mweb_url")]
        [System.Text.Json.Serialization.JsonPropertyName("mweb_url")]
        public string MWebUrl { get; set; } = default!;
    }
}
