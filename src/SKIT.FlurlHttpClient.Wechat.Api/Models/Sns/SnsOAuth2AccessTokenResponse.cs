namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /sns/oauth2/access_token 接口的响应。</para>
    /// </summary>
    public class SnsOAuth2AccessTokenResponse : SnsOAuth2RefreshTokenResponse
    {
        /// <summary>
        /// 获取或设置用户全局标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unionid")]
        [System.Text.Json.Serialization.JsonPropertyName("unionid")]
        public string? UnionId { get; set; }

        /// <summary>
        /// 获取或设置是否为快照页模式虚拟账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_snapshotuser")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("is_snapshotuser")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
        public bool IsSnapshotUser { get; set; }
    }
}
