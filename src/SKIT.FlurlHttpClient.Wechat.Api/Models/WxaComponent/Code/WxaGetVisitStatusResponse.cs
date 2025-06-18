namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/getvisitstatus 接口的响应。</para>
    /// </summary>
    public class WxaGetVisitStatusResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置服务状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }
    }
}
