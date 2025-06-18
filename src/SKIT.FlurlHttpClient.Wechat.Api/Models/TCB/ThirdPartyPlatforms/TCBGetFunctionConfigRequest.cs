﻿namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/getfuncconfig 接口的请求。</para>
    /// </summary>
    public class TCBGetFunctionConfigRequest : WechatApiRequest, IInferable<TCBGetFunctionConfigRequest, TCBGetFunctionConfigResponse>
    {
        /// <summary>
        /// 获取或设置环境 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("env")]
        [System.Text.Json.Serialization.JsonPropertyName("env")]
        public string EnvironmentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置函数名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("function_name")]
        [System.Text.Json.Serialization.JsonPropertyName("function_name")]
        public string FunctionName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置配置类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int Type { get; set; }
    }
}
