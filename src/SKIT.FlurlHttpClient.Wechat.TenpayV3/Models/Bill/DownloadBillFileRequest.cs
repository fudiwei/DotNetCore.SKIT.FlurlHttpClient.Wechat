namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /{download_url} 接口的请求。</para>
    /// </summary>
    public class DownloadBillFileRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置账单下载地址。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string DownloadUrl { get; set; } = string.Empty;
    }
}
