namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/newguidegroup 接口的请求。</para>
    /// </summary>
    public class CgibinGuideNewGuideGroupRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置顾问分组名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_name")]
        [System.Text.Json.Serialization.JsonPropertyName("group_name")]
        public string GroupName { get; set; } = string.Empty;
    }
}
