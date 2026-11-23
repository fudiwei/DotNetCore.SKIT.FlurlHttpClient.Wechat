namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/batchgetenvid 接口的请求。</para>
    /// </summary>
    public class ComponentTCBBatchGetEnvironmentIdRequest : WechatApiRequest, IInferable<ComponentTCBBatchGetEnvironmentIdRequest, ComponentTCBBatchGetEnvironmentIdResponse>
    {
        /// <summary>
        /// 获取或设置第三方平台 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? ComponentAccessToken { get; set; }

        /// <summary>
        /// 获取或设置 AppId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appids")]
        [System.Text.Json.Serialization.JsonPropertyName("appids")]
        public List<string>? AppIdList { get; set; }

        /// <summary>
        /// 获取或设置请求环境源。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("source_type")]
        [System.Text.Json.Serialization.JsonPropertyName("source_type")]
        public int? SourceType { get; set; }
    }
}
