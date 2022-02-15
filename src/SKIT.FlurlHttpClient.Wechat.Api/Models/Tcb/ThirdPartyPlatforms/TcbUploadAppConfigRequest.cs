namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/uploadappconfig 接口的请求。</para>
    /// </summary>
    public class TcbUploadAppConfigRequest : WechatApiRequest, IMapResponse<TcbUploadAppConfigRequest, TcbUploadAppConfigResponse>
    {
        /// <summary>
        /// 获取或设置配置类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int Type { get; set; }

        /// <summary>
        /// 获取或设置 JSON 格式的配置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("config")]
        [System.Text.Json.Serialization.JsonPropertyName("config")]
        public string JsonConfig { get; set; } = string.Empty;
    }
}
