namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedrive/mng_capacity 接口的响应。</para>
    /// </summary>
    public class CgibinWedriveManageCapacityResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置全员容量（单位：字节）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_capacity_for_all")]
        [System.Text.Json.Serialization.JsonPropertyName("total_capacity_for_all")]
        public long TotalCapacityForAll { get; set; }

        /// <summary>
        /// 获取或设置专业容量（单位：字节）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_capacity_for_vip")]
        [System.Text.Json.Serialization.JsonPropertyName("total_capacity_for_vip")]
        public long TotalCapacityForVip { get; set; }

        /// <summary>
        /// 获取或设置全员可用容量（单位：字节）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rest_capacity_for_all")]
        [System.Text.Json.Serialization.JsonPropertyName("rest_capacity_for_all")]
        public long RestCapacityForAll { get; set; }

        /// <summary>
        /// 获取或设置专业可用容量（单位：字节）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rest_capacity_for_vip")]
        [System.Text.Json.Serialization.JsonPropertyName("rest_capacity_for_vip")]
        public long RestCapacityForVip { get; set; }
    }
}
