namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/idconvert/unionid_to_external_userid 接口的响应。</para>
    /// </summary>
    public class CgibinIdConvertUnionIdToExternalUserIdResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置外部联系人账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("external_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("external_userid")]
        public string? ExternalUserId { get; set; }

        /// <summary>
        /// 获取或设置临时外部联系人账号 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pending_id")]
        [System.Text.Json.Serialization.JsonPropertyName("pending_id")]
        public string? PendingExternalUserId { get; set; }
    }
}
