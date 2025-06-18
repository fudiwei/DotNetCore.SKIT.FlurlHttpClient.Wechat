namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/customer_acquisition/get_chat_info 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactCustomerAcquisitionGetChatInfoRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置会话信息凭据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chat_key")]
        [System.Text.Json.Serialization.JsonPropertyName("chat_key")]
        public string ChatKey { get; set; } = string.Empty;
    }
}
