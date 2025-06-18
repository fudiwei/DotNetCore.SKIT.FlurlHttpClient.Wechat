namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/batch/userid_to_openuserid 接口的响应。</para>
    /// </summary>
    public class CgibinBatchUserIdToOpenUserIdResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class User
            {
                /// <summary>
                /// 获取或设置转换成功的 UserId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string UserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置转换成功的 UserId 对应的服务商主体下的密文。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("open_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("open_userid")]
                public string OpenUserId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置转换成功的成员列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_userid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("open_userid_list")]
        public Types.User[] UserList { get; set; } = default!;

        /// <summary>
        /// 获取或设置无效的成员 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invalid_userid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("invalid_userid_list")]
        public string[] InvalidUserIdList { get; set; } = default!;
    }
}
