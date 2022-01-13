namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/externalcontact/list 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactListResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置外部联系人账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("external_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("external_userid")]
        public string[] ExternalUserIdList { get; set; } = default!;
    }
}
