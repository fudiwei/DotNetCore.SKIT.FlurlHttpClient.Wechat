using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/databaseaggregate 接口的响应。</para>
    /// </summary>
    public class TcbDatabaseAggregateResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置查询数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public string[] Data { get; set; } = default!;
    }
}
