using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/databasecollectionadd 接口的请求。</para>
    /// </summary>
    public class TcbDatabaseCollectionAddRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置环境 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("env")]
        [System.Text.Json.Serialization.JsonPropertyName("env")]
        public string EnvironmentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置集合名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("collection_name")]
        [System.Text.Json.Serialization.JsonPropertyName("collection_name")]
        public string CollectionName { get; set; } = string.Empty;
    }
}
