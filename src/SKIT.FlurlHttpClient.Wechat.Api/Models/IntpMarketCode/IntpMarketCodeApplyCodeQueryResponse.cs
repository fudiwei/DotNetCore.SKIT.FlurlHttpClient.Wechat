namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /intp/marketcode/applycodequery 接口的响应。</para>
    /// </summary>
    public class IntpMarketCodeApplyCodeQueryResponse : WechatApiResponse
    {
        public static class Types
        {
            public class CodeGeneration
            {
                /// <summary>
                /// 获取或设置号段开始位置。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("code_start")]
                [System.Text.Json.Serialization.JsonPropertyName("code_start")]
                public long CodeStart { get; set; }

                /// <summary>
                /// 获取或设置号段结束位置。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("code_end")]
                [System.Text.Json.Serialization.JsonPropertyName("code_end")]
                public long CodeEnd { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("application_id")]
        [System.Text.Json.Serialization.JsonPropertyName("application_id")]
        public long ApplicationId { get; set; }

        /// <summary>
        /// 获取或设置外部单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("isv_application_id")]
        [System.Text.Json.Serialization.JsonPropertyName("isv_application_id")]
        public string ISVApplicationId { get; set; } = default!;

        /// <summary>
        /// 获取或设置申请单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = default!;

        /// <summary>
        /// 获取或设置号段生成列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code_generate_list")]
        [System.Text.Json.Serialization.JsonPropertyName("code_generate_list")]
        public Types.CodeGeneration[]? CodeGenerationList { get; set; }

        /// <summary>
        /// 获取或设置更新时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_time")]
        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
        public long? UpdateTimestamp { get; set; }

        /// <summary>
        /// 获取或设置创建时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        public long? CreateTimestamp { get; set; }
    }
}
