namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/rooms/list_controllers 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingRoomsListControllersRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置控制器名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("controller_name")]
        [System.Text.Json.Serialization.JsonPropertyName("controller_name")]
        public string? ControllerName { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }
    }
}
