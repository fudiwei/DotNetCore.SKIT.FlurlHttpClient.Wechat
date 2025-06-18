using System;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /geth5link/{TOKEN} 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2023-04-07 下线。")]
    public class GetH5LinkRequest : WechatChatbotRequest, WechatChatbotRequest.Serialization.IEncryptedXmlable
    {
        /// <summary>
        /// 获取或设置页面标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }
    }
}
