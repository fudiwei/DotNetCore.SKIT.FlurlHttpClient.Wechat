namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/getwxamplinkforshow 接口的请求。</para>
    /// </summary>
    public class WxaGetWxaMpLinkForShowRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置分页页数（从 0 开始）。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int Page { get; set; } = 0;

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int Limit { get; set; } = 10;
    }
}
