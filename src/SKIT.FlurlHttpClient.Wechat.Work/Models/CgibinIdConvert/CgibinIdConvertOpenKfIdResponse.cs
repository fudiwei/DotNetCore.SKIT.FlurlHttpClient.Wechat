namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/idconvert/open_kfid 接口的响应。</para>
    /// </summary>
    public class CgibinIdConvertOpenKfIdResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Result
            {
                /// <summary>
                /// 获取或设置客服账号 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("open_kfid")]
                [System.Text.Json.Serialization.JsonPropertyName("open_kfid")]
                public string OpenKfId { get; set; } = default!;

                /// <summary>
                /// 获取或设置服务商下的客服账号 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("new_open_kfid")]
                [System.Text.Json.Serialization.JsonPropertyName("new_open_kfid")]
                public string NewOpenKfId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("items")]
        [System.Text.Json.Serialization.JsonPropertyName("items")]
        public Types.Result[] ResultList { get; set; } = default!;

        /// <summary>
        /// 获取或设置无效的客服账号 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invalid_open_kfid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("invalid_open_kfid_list")]
        public string[]? InvalidOpenKfIdList { get; set; } = default!;
    }
}
