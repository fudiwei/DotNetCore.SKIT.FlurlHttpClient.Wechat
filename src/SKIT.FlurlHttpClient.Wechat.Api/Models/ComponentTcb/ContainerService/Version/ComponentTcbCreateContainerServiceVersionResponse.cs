namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/createcsversion 接口的响应。</para>
    /// </summary>
    public class ComponentTcbCreateContainerServiceVersionResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置版本名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("version_name")]
        [System.Text.Json.Serialization.JsonPropertyName("version_name")]
        public string VersionName { get; set; } = default!;
    }
}
