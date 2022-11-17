namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/get_new_external_userid 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactGetNewExternalUserIdResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Result
            {
                /// <summary>
                /// 获取或设置原外部联系人账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("external_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("external_userid")]
                public string ExternalUserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置新外部联系人账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("new_external_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("new_external_userid")]
                public string NewExternalUserId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置转换结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("items")]
        [System.Text.Json.Serialization.JsonPropertyName("items")]
        public Types.Result[] ResultList { get; set; } = default!;
    }
}
