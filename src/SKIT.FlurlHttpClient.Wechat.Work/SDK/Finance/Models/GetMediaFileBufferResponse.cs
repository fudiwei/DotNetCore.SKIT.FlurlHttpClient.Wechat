namespace SKIT.FlurlHttpClient.Wechat.Work.SDK.Finance.Models
{
    /// <summary>
    /// <para>表示会话内容存档之获取媒体文件分片接口的响应。</para>
    /// </summary>
    public class GetMediaFileBufferResponse : WechatWorkFinanceResponse
    {
        /// <summary>
        /// 获取或设置文件分片二进制数组。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[] FileBufferBytes
        {
            get { return RawBytes; }
            set { RawBytes = value; }
        }

        /// <summary>
        /// 获取或设置下一次的分片索引。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? NextBufferIndex { get; set; }

        /// <summary>
        /// 获取或设置是否已是最后一个分片。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public bool IsFinished { get; set; }

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && FileBufferBytes?.Length > 0;
        }
    }
}
