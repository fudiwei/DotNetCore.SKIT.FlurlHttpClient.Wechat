namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/business/register 接口的响应。</para>
    /// </summary>
    public class CgibinBusinessRegisterResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置商户 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_id")]
        [System.Text.Json.Serialization.JsonPropertyName("business_id")]
        public long BusinessId { get; set; }
    }
}
