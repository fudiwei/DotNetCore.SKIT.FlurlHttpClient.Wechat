namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.Finance.Models
{
    /// <summary>
    /// <para>表示会话内容存档之获取媒体文件分片接口的请求。</para>
    /// </summary>
    public class GetMediaFileBufferRequest : WechatWorkFinanceRequest
    {
        /// <summary>
        /// 获取或设置起始分片索引。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? BufferIndex { get; set; }

        /// <summary>
        /// 获取或设置文件 FileId。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string FileId { get; set; } = string.Empty;
    }
}
