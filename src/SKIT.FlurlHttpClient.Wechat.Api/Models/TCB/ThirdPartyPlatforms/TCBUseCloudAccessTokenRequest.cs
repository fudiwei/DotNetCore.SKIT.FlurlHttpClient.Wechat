using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/usecloudaccesstoken 接口的请求。</para>
    /// </summary>
    public class TCBUseCloudAccessTokenRequest : WechatApiRequest, IInferable<TCBUseCloudAccessTokenRequest, TCBUseCloudAccessTokenResponse>
    {
        /// <summary>
        /// 获取或设置操作类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action")]
        [System.Text.Json.Serialization.JsonPropertyName("action")]
        public string Action { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置环境 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("env")]
        [System.Text.Json.Serialization.JsonPropertyName("env")]
        public string EnvironmentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否开启。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open")]
        [System.Text.Json.Serialization.JsonPropertyName("open")]
        public bool? IsOpen { get; set; }

        /// <summary>
        /// 获取或设置 API 白名单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("api_whitelist")]
        [System.Text.Json.Serialization.JsonPropertyName("api_whitelist")]
        public IList<string>? ApiWhiteList { get; set; }

        /// <summary>
        /// 获取或设置版本号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("version")]
        [System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }
    }
}
