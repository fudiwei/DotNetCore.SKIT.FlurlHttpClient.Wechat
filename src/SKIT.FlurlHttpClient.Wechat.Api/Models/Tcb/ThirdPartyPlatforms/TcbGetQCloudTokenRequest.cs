namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/getqcloudtoken 接口的请求。</para>
    /// </summary>
    public class TcbGetQCloudTokenRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置有效期（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lifespan")]
        [System.Text.Json.Serialization.JsonPropertyName("lifespan")]
        public int ExpiresIn { get; set; }
    }
}
