using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/batchcreatecsversion 接口的响应。</para>
    /// </summary>
    public class ComponentTcbBatchCreateContainerServiceVersionResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Success
            {
                /// <summary>
                /// 获取或设置环境 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("env")]
                [System.Text.Json.Serialization.JsonPropertyName("env")]
                public string EnvironmentId { get; set; } = default!;

                /// <summary>
                /// 获取或设置版本名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("version_name")]
                [System.Text.Json.Serialization.JsonPropertyName("version_name")]
                public string VersionName { get; set; } = default!;
            }

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
                [Newtonsoft.Json.JsonProperty("errormsg")]
                [System.Text.Json.Serialization.JsonPropertyName("errormsg")]
                public string ErrorMessage { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置成功项列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("succ_list")]
        [System.Text.Json.Serialization.JsonPropertyName("succ_list")]
        public Types.Success[] SuccessList { get; set; } = default!;

        /// <summary>
        /// 获取或设置失败项列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_list")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_list")]
        public Types.Failure[] FailureList { get; set; } = default!;
    }
}
