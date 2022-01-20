namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/get_moment_send_result 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactGetMomentSendResultResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Result
            {
                /// <summary>
                /// 获取或设置发送成功的外部联系人账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("external_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("external_userid")]
                public string ExternalUserId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置朋友圈发送结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("customer_list")]
        [System.Text.Json.Serialization.JsonPropertyName("customer_list")]
        public Types.Result[] ResultList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
