namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/service/contact/sort 接口的响应。</para>
    /// </summary>
    public class CgibinServiceContactSortResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置排序后的成员账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("useridlist")]
        [System.Text.Json.Serialization.JsonPropertyName("useridlist")]
        public string[] UserIdList { get; set; } = default!;
    }
}
