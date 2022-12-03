namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/idconvert/external_tagid 接口的响应。</para>
    /// </summary>
    public class CgibinIdConvertExternalTagIdResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Result
            {
                /// <summary>
                /// 获取或设置客户标签 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("external_tagid")]
                [System.Text.Json.Serialization.JsonPropertyName("external_tagid")]
                public string ExternalTagId { get; set; } = default!;

                /// <summary>
                /// 获取或设置服务商下的客户标签 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("open_external_tagid")]
                [System.Text.Json.Serialization.JsonPropertyName("open_external_tagid")]
                public string OpenExternalTagId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("items")]
        [System.Text.Json.Serialization.JsonPropertyName("items")]
        public Types.Result[] ResultList { get; set; } = default!;

        /// <summary>
        /// 获取或设置无效的客户标签 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invalid_external_tagid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("invalid_external_tagid_list")]
        public string[]? InvalidExternalTagIdList { get; set; } = default!;
    }
}
