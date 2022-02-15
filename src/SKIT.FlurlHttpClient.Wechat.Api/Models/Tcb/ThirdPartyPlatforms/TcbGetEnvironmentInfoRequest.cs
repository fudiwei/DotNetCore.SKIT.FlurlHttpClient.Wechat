using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/getenvinfo 接口的请求。</para>
    /// </summary>
    public class TcbGetEnvironmentInfoRequest : WechatApiRequest, IMapResponse<TcbGetEnvironmentInfoRequest, TcbGetEnvironmentInfoResponse>
    {
        /// <summary>
        /// 获取或设置环境 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("env")]
        [System.Text.Json.Serialization.JsonPropertyName("env")]
        public string EnvironmentId { get; set; } = string.Empty;
    }
}
