namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /union/promoter/open_account/bind 接口的请求。</para>
    /// </summary>
    public class UnionPromoterOpenAccountBindRequest : WechatApiRequest, IInferable<UnionPromoterOpenAccountBindRequest, UnionPromoterOpenAccountBindResponse>
    {
        /// <summary>
        /// 获取或设置开放平台账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openAccount")]
        [System.Text.Json.Serialization.JsonPropertyName("openAccount")]
        public string OpenAccount { get; set; } = string.Empty;
    }
}
