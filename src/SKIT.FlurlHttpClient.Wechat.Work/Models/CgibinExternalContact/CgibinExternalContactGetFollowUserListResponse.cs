namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/externalcontact/get_follow_user_list 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactGetFollowUserListResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置配置了客户联系功能的成员账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("follow_user")]
        [System.Text.Json.Serialization.JsonPropertyName("follow_user")]
        public string[] FollowUserIdList { get; set; } = default!;
    }
}
