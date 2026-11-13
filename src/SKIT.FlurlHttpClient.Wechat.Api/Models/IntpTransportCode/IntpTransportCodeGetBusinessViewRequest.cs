namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /intp/transportcode/getbusinessview 接口的请求。</para>
    /// </summary>
    public class IntpTransportCodeGetBusinessViewRequest : WechatApiRequest, IInferable<IntpTransportCodeGetBusinessViewRequest, IntpTransportCodeGetBusinessViewResponse>
    {
        /// <summary>
        /// 获取或设置页面类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("path_type")]
        [System.Text.Json.Serialization.JsonPropertyName("path_type")]
        public int PathType { get; set; }
    }
}
