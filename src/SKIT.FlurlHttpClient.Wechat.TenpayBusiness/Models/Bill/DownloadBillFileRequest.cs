namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [GET] /{download_url} 接口的请求。</para>
    /// </summary>
    public class DownloadBillFileRequest : WechatTenpayBusinessRequest
    {
        /// <summary>
        /// 获取或设置文件下载链接。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string DownloadUrl { get; set; } = string.Empty;
    }
}
