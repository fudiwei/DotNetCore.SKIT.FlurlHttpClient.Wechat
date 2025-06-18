namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/service/batch/getresult 接口的响应。</para>
    /// </summary>
    public class CgibinServiceBatchGetResultResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Result
            {
                public static class Types
                {
                    public class ContactIdTranslateResult
                    {
                        /// <summary>
                        /// 获取或设置 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("url")]
                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                        public string Url { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置通讯录 ID 转译任务结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact_id_translate")]
                [System.Text.Json.Serialization.JsonPropertyName("contact_id_translate")]
                public Types.ContactIdTranslateResult? ContactIdTranslateResult { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置任务类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = default!;

        /// <summary>
        /// 获取或设置任务状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置处理结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        public Types.Result Result { get; set; } = default!;
    }
}
