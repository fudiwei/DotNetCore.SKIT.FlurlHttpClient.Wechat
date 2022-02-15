namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/school/set_upgrade_info 接口的响应。</para>
    /// </summary>
    public class CgibinSchoolSetUpgradeInfoResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置下次升年级的时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_upgrade_time")]
        [System.Text.Json.Serialization.JsonPropertyName("next_upgrade_time")]
        public long NextUpgradeTimestamp { get; set; }
    }
}
