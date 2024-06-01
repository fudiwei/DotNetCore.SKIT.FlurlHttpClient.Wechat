namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/idconvert/apply_to_upgrade_chatid 接口的请求。</para>
    /// </summary>
    public class CgibinIdConvertApplyToUpgradeChatIdRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置完成升级的时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("upgrade_time")]
        [System.Text.Json.Serialization.JsonPropertyName("upgrade_time")]
        public long UpgradeTimestamp { get; set; }
    }
}
