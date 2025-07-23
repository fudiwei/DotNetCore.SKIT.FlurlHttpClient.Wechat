namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/smartsheet/groupchat/get 接口的响应。</para>
    /// </summary>
    public class CgibinWedocSmartSheetGroupChatGetResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置群聊名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 获取或设置群主成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("owner")]
        [System.Text.Json.Serialization.JsonPropertyName("owner")]
        public string OwnerUserId { get; set; } = default!;

        /// <summary>
        /// 获取或设置群成员账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_list")]
        [System.Text.Json.Serialization.JsonPropertyName("user_list")]
        public string[] UserIdList { get; set; } = default!;
    }
}
