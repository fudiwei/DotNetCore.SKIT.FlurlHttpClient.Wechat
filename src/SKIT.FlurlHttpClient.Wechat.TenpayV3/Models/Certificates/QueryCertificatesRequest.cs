namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /certificates 接口的请求。</para>
    /// </summary>
    public class QueryCertificatesRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置算法类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? AlgorithmType { get; set; }
    }
}
