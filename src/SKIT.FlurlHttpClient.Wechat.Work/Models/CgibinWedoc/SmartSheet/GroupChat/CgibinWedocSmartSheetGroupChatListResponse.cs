namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/smartsheet/groupchat/list 接口的响应。</para>
    /// </summary>
    public class CgibinWedocSmartSheetGroupChatListResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置群聊 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chat_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("chat_id_list")]
        public string[] GroupChatIdList { get; set; } = default!;

        /// <summary>
        /// 获取或设置分页游标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// 获取或设置是否还有更多数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool HasMore { get; set; }
    }
}
