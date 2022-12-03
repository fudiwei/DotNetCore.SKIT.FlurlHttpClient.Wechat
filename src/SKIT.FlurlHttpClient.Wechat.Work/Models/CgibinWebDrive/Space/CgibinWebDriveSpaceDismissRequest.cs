namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedrive/space_dismiss 接口的请求。</para>
    /// </summary>
    public class CgibinWebDriveSpaceDismissRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置空间 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spaceid")]
        [System.Text.Json.Serialization.JsonPropertyName("spaceid")]
        public string SpaceId { get; set; } = string.Empty;
    }
}
