﻿namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/dbmigrationstate 接口的请求。</para>
    /// </summary>
    public class ComponentTCBDbMigrationStateRequest : WechatApiRequest, IInferable<ComponentTCBDbMigrationStateRequest, ComponentTCBDbMigrationStateResponse>
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
        /// 获取或设置任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("job_id")]
        [System.Text.Json.Serialization.JsonPropertyName("job_id")]
        public int JobId { get; set; }
    }
}
