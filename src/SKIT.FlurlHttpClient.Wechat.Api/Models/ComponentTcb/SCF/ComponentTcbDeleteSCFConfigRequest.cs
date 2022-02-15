using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/deletescf 接口的请求。</para>
    /// </summary>
    public class ComponentTcbDeleteSCFConfigRequest : WechatApiRequest, IMapResponse<ComponentTcbDeleteSCFConfigRequest, ComponentTcbDeleteSCFConfigResponse>
    {
        /// <summary>
        /// 获取或设置第三方平台 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ComponentAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置环境 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("env")]
        [System.Text.Json.Serialization.JsonPropertyName("env")]
        public string EnvironmentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置函数名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("functionname")]
        [System.Text.Json.Serialization.JsonPropertyName("functionname")]
        public string FunctionName { get; set; } = string.Empty;
    }
}
