namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/sync/contact_sync_success 接口的请求。</para>
    /// </summary>
    public class CgibinSyncContactSyncSuccessRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置通讯录迁移凭证。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? AccessToken { get; set; }
    }
}
