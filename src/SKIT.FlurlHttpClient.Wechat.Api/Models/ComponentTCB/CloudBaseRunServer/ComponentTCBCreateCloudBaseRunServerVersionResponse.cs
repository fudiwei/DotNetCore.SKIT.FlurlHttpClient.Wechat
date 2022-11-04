namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/createcloudbaserunserverversion 接口的响应。</para>
    /// </summary>
    public class ComponentTCBCreateCloudBaseRunServerVersionResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置操作记录 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("run_id")]
        [System.Text.Json.Serialization.JsonPropertyName("run_id")]
        public string RunId { get; set; } = default!;

        /// <summary>
        /// 获取或设置创建结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        public string Result { get; set; } = default!;

        /// <summary>
        /// 获取或设置版本名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("version_name")]
        [System.Text.Json.Serialization.JsonPropertyName("version_name")]
        public string? VersionName { get; set; }
    }
}
