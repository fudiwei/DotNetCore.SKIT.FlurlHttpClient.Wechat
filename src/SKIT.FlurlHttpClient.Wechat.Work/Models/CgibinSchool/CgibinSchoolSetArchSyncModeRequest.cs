namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/school/set_arch_sync_mode 接口的请求。</para>
    /// </summary>
    public class CgibinSchoolSetArchSyncModeRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置家校通讯录同步模式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("arch_sync_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("arch_sync_mode")]
        public int ArchSyncMode { get; set; }
    }
}
