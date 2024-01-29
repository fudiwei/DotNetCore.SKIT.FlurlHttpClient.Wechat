namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/groupchat/get 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactGroupChatGetRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置客户群 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chat_id")]
        [System.Text.Json.Serialization.JsonPropertyName("chat_id")]
        public string GroupChatId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否需要返回群成员的名字。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_name")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("need_name")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool? RequireMemberName { get; set; }
    }
}
