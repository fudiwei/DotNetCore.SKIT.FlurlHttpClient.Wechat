namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/rooms/get_inventory 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingRoomsGetInventoryResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置普通设备数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("normal_count")]
        [System.Text.Json.Serialization.JsonPropertyName("normal_count")]
        public int NormalCount { get; set; }

        /// <summary>
        /// 获取或设置专款设备数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("special_count")]
        [System.Text.Json.Serialization.JsonPropertyName("special_count")]
        public int SpecialCount { get; set; }

        /// <summary>
        /// 获取或设置普通设备使用数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("normal_used_count")]
        [System.Text.Json.Serialization.JsonPropertyName("normal_used_count")]
        public int NormalUsedCount { get; set; }

        /// <summary>
        /// 获取或设置专款设备使用数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("special_used_count")]
        [System.Text.Json.Serialization.JsonPropertyName("special_used_count")]
        public int SpecialUsedCount { get; set; }

        /// <summary>
        /// 获取或设置普通设备过期数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("normal_expired_count")]
        [System.Text.Json.Serialization.JsonPropertyName("normal_expired_count")]
        public int NormalExpiredCount { get; set; }

        /// <summary>
        /// 获取或设置专款设备过期数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("special_expired_count")]
        [System.Text.Json.Serialization.JsonPropertyName("special_expired_count")]
        public int SpecialExpiredCount { get; set; }
    }
}
