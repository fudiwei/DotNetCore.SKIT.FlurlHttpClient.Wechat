namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedrive/file_share 接口的响应。</para>
    /// </summary>
    public class CgibinWebDriveFileShareResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置分享链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("share_url")]
        [System.Text.Json.Serialization.JsonPropertyName("share_url")]
        public string ShareUrl { get; set; } = default!;
    }
}
