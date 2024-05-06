namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global.Models
{
    /// <summary>
    /// <para>表示 [POST] /papay/contracts/h5-pre-entrust-sign 接口的请求。</para>
    /// </summary>
    public class PresignPAPayContractEntrustH5Request : PresignPAPayContractEntrustAppRequest
    {
        /// <summary>
        /// 获取或设置签约后跳转 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("return_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("return_appid")]
        public string? ReturnAppId { get; set; }
    }
}
