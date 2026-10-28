namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/groupchat/update_join_way 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactGroupChatUpdateJoinWayRequest : CgibinExternalContactGroupChatAddJoinWayRequest
    {
        /// <summary>
        /// 获取或设置配置 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("config_id")]
        [System.Text.Json.Serialization.JsonPropertyName("config_id")]
        public string? ConfigId { get; set; }
    }
}
