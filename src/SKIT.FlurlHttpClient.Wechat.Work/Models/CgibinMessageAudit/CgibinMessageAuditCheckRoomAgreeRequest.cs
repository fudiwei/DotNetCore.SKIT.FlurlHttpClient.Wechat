namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/msgaudit/check_room_agree 接口的请求。</para>
    /// </summary>
    public class CgibinMessageAuditCheckRoomAgreeRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置待查询的群聊房间 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("roomid")]
        [System.Text.Json.Serialization.JsonPropertyName("roomid")]
        public string RoomId { get; set; } = string.Empty;
    }
}
