using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/batchuploadscf 接口的响应。</para>
    /// </summary>
    public class ComponentTcbBatchUploadSCFResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Failure
            {
                /// <summary>
                /// 获取或设置环境 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("env")]
                [System.Text.Json.Serialization.JsonPropertyName("env")]
                public string EnvironmentId { get; set; } = default!;

                /// <summary>
                /// 获取或设置错误描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errmsg")]
                [System.Text.Json.Serialization.JsonPropertyName("errmsg")]
                public string? ErrorMessage { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置失败项列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_env_list")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_env_list")]
        public Types.Failure[]? FailureList { get; set; }
    }
}
