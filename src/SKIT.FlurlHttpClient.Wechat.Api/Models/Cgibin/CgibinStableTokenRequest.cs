using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/stable_token 接口的请求。</para>
    /// </summary>
    public class CgibinStableTokenRequest : WechatApiRequest, IInferable<CgibinTokenRequest, CgibinTokenResponse>
    {
        /// <summary>
        /// 使用默认值即可，无需修改
        /// </summary>
        [JsonProperty("grant_type")]
        [JsonPropertyName("grant_type")]
        public string GrantType { get; set; } = "client_credential";

        /// <summary>
        /// 账号唯一凭证，即 AppID
        /// </summary>
        [JsonProperty("appid")]
        [JsonPropertyName("appid")]
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 帐号唯一凭证密钥，即 AppSecret
        /// </summary>
        [JsonProperty("secret")]
        [JsonPropertyName("secret")]
        public string AppSecret { get; set; } = default!;

        /// <summary>
        /// 是否强制刷新
        /// </summary>
        [JsonProperty("force_refresh")]
        [JsonPropertyName("force_refresh")]
        public bool ForceRefresh { get; set; }
    }
}
