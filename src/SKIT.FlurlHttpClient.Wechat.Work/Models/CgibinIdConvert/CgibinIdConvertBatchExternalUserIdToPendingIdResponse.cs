namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/idconvert/batch/external_userid_to_pending_id 接口的响应。</para>
    /// </summary>
    public class CgibinIdConvertBatchExternalUserIdToPendingIdResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Result
            {
                /// <summary>
                /// 获取或设置外部联系人账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("external_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("external_userid")]
                public string ExternalUserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置临时部联系人账号 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pending_id")]
                [System.Text.Json.Serialization.JsonPropertyName("pending_id")]
                public string PendingExternalUserId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        public Types.Result[] ResultList { get; set; } = default!;
    }
}
