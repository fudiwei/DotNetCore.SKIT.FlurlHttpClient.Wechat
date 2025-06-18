namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/batchgetenvid 接口的响应。</para>
    /// </summary>
    public class ComponentTCBBatchGetEnvironmentIdResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Relation
            {
                /// <summary>
                /// 获取或设置 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置环境 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("env_list")]
                [System.Text.Json.Serialization.JsonPropertyName("env_list")]
                public string[] EnvironmentIdList { get; set; } = default!;
            }

            public class Error : ComponentTCBBatchShareEnvironmentResponse.Types.Error
            {
            }
        }

        /// <summary>
        /// 获取或设置关系列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("relation_data")]
        [System.Text.Json.Serialization.JsonPropertyName("relation_data")]
        public Types.Relation[] RelationList { get; set; } = default!;

        /// <summary>
        /// 获取或设置错误列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_list")]
        [System.Text.Json.Serialization.JsonPropertyName("err_list")]
        public Types.Error[]? ErrorList { get; set; }
    }
}
