using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/meetingroom/list 接口的请求。</para>
    /// </summary>
    public class CgibinOAMeetingRoomListRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置指定城市。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city")]
        [System.Text.Json.Serialization.JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// 获取或设置指定楼宇。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("building")]
        [System.Text.Json.Serialization.JsonPropertyName("building")]
        public string? Building { get; set; }

        /// <summary>
        /// 获取或设置指定楼层。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("floor")]
        [System.Text.Json.Serialization.JsonPropertyName("floor")]
        public string? Floor { get; set; }

        /// <summary>
        /// 获取或设置指定支持的设备 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("equipment")]
        [System.Text.Json.Serialization.JsonPropertyName("equipment")]
        public IList<int>? EquipmentIdList { get; set; }
    }
}
