using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/invokecloudfunction 接口的响应。</para>
    /// </summary>
    public class TcbInvokeCloudFunctionResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置函数返回结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resp_data")]
        [System.Text.Json.Serialization.JsonPropertyName("resp_data")]
        public string? Data { get; set; }
    }
}
