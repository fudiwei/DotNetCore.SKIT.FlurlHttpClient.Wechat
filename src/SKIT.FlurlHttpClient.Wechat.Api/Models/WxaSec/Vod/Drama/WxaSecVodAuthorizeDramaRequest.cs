using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/vod/authorizedrama 接口的请求。</para>
    /// </summary>
    public class WxaSecVodAuthorizeDramaRequest : WechatApiRequest, IInferable<WxaSecVodAuthorizeDramaRequest, WxaSecVodAuthorizeDramaResponse>
    {
        /// <summary>
        /// 获取或设置授权的剧目 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("drama_id")]
        [System.Text.Json.Serialization.JsonPropertyName("drama_id")]
        public IList<long> DramaIdList { get; set; } = new List<long>();

        /// <summary>
        /// 获取或设置被授权方小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorized_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("authorized_appid")]
        public string AuthorizedAppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置授权到期时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authz_expire_time")]
        [System.Text.Json.Serialization.JsonPropertyName("authz_expire_time")]
        public long? ExpireTimestamp { get; set; }
    }
}
