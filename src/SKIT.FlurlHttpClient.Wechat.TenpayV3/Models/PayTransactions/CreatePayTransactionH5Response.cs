namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /pay/transactions/h5 接口的响应。</para>
    /// </summary>
    public class CreatePayTransactionH5Response : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置支付跳转链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("h5_url")]
        [System.Text.Json.Serialization.JsonPropertyName("h5_url")]
        public string H5Url { get; set; } = default!;
    }
}
