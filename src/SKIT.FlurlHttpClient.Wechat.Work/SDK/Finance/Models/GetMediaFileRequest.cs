namespace SKIT.FlurlHttpClient.Wechat.Work.SDK.Finance.Models
{
    /// <summary>
    /// <para>表示会话内容存档之获取媒体文件接口的请求。</para>
    /// </summary>
    public class GetMediaFileRequest : WechatWorkFinanceRequest
    {
        /// <summary>
        /// 获取或设置文件 FileId。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string FileId { get; set; } = string.Empty;
    }
}
