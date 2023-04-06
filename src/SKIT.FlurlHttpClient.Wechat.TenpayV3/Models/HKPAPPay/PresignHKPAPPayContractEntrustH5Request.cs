namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /papay/contracts/h5-pre-entrust-sign 接口的请求。</para>
    /// </summary>
    public class PresignHKPAPPayContractEntrustH5Request : PresignHKPAPPayContractEntrustAppRequest
    {
        /// <summary>
        /// 获取或设置签约后跳转 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("return_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("return_appid")]
        public string? ReturnAppId { get; set; }
    }
}
