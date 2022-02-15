using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/downloadfunction 接口的请求。</para>
    /// </summary>
    public class TcbDownloadFunctionRequest : WechatApiRequest, IMapResponse<TcbDownloadFunctionRequest, TcbDownloadFunctionResponse>
    {
        /// <summary>
        /// 获取或设置环境 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("env")]
        [System.Text.Json.Serialization.JsonPropertyName("env")]
        public string EnvironmentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置云函数名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("function_name")]
        [System.Text.Json.Serialization.JsonPropertyName("function_name")]
        public string FunctionName { get; set; } = string.Empty;
    }
}
