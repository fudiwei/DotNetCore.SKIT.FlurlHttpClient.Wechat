namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/getretailinfo 接口的请求。</para>
    /// </summary>
    public class WxaBusinessGetRetailInfoRequest : WechatApiRequest, IInferable<WxaBusinessGetRetailInfoRequest, WxaBusinessGetRetailInfoResponse>
    {
        /// <summary>
        /// 获取或设置门店负责人的 OpenId。与字段 <see cref="Mobilephone"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置门店负责人的手机号。与字段 <see cref="OpenId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mobile_phone")]
        [System.Text.Json.Serialization.JsonPropertyName("mobile_phone")]
        public string? Mobilephone { get; set; }
    }
}
