namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/business/get 接口的请求。</para>
    /// </summary>
    public class CgibinBusinessGetRequest : WechatApiRequest, IInferable<CgibinBusinessGetRequest, CgibinBusinessGetResponse>
    {
        /// <summary>
        /// 获取或设置商户 ID。与字段 <see cref="AccountName"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_id")]
        [System.Text.Json.Serialization.JsonPropertyName("business_id")]
        public long? BusinessId { get; set; }

        /// <summary>
        /// 获取或设置商户账号。与字段 <see cref="BusinessId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_name")]
        [System.Text.Json.Serialization.JsonPropertyName("account_name")]
        public string? AccountName { get; set; }
    }
}
