﻿namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/databasedelete 接口的请求。</para>
    /// </summary>
    public class TCBDatabaseDeleteRequest : WechatApiRequest, IInferable<TCBDatabaseDeleteRequest, TCBDatabaseDeleteResponse>
    {
        /// <summary>
        /// 获取或设置环境 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("env")]
        [System.Text.Json.Serialization.JsonPropertyName("env")]
        public string EnvironmentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置数据库操作语句。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("query")]
        [System.Text.Json.Serialization.JsonPropertyName("query")]
        public string QueryString { get; set; } = string.Empty;
    }
}
