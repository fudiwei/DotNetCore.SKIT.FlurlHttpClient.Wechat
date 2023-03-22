namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/idconvert/convert_tmp_external_userid 接口的响应。</para>
    /// </summary>
    public class CgibinIdConvertConvertTempExternalUserIdResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Result
            {
                /// <summary>
                /// 获取或设置外部联系人临时 ID ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tmp_external_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("tmp_external_userid")]
                public string TempExternalUserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置外部联系人账号 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("external_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("external_userid")]
                public string? ExternalUserId { get; set; }

                /// <summary>
                /// 获取或设置企业 CorpId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("corpid")]
                [System.Text.Json.Serialization.JsonPropertyName("corpid")]
                public string? CorpId { get; set; }

                /// <summary>
                /// 获取或设置成员账号 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string? UserId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置转换结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("results")]
        [System.Text.Json.Serialization.JsonPropertyName("results")]
        public Types.Result[] ResultList { get; set; } = default!;

        /// <summary>
        /// 获取或设置无效的外部联系人临时 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invalid_tmp_external_userid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("invalid_tmp_external_userid_list")]
        public string[]? InvalidTempExternalUserIdList { get; set; }
    }
}
