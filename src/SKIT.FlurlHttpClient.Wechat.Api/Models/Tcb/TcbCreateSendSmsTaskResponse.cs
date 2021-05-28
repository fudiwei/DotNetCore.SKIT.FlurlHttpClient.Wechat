using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/createsendsmstask 接口的响应。</para>
    /// </summary>
    public class TcbCreateSendSmsTaskResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置查询 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("query_id")]
        [System.Text.Json.Serialization.JsonPropertyName("query_id")]
        public string QueryId { get; set; } = default!;
    }
}
