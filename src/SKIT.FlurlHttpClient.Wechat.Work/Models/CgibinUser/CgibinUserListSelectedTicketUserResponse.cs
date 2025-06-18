namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/user/list_selected_ticket_user 接口的响应。</para>
    /// </summary>
    public class CgibinUserListSelectedTicketUserResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置选人用户的 OpenUserId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operator_open_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("operator_open_userid")]
        public string OperatorOpenUserId { get; set; } = default!;

        /// <summary>
        /// 获取或设置应用可见范围内用户 OpenUserId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_userid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("open_userid_list")]
        public string[] OpenUserIdList { get; set; } = default!;

        /// <summary>
        /// 获取或设置未授权应用的用户 OpenUserId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unauth_open_userid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("unauth_open_userid_list")]
        public string[]? UnauthOpenUserIdList { get; set; }

        /// <summary>
        /// 获取或设置用户选择的总人数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total")]
        [System.Text.Json.Serialization.JsonPropertyName("total")]
        public int TotalCount { get; set; }
    }
}
