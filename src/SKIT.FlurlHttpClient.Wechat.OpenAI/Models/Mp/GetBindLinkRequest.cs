using System;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /getbindlink/{TOKEN} 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2023-04-07 下线。")]
    public class GetBindLinkRequest : WechatOpenAIRequest, WechatOpenAIRequest.Serialization.IEncryptedXmlable
    {
        /// <summary>
        /// 获取或设置直播 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("redirectlink")]
        [System.Text.Json.Serialization.JsonPropertyName("redirectlink")]
        public string RedirectUrl { get; set; } = string.Empty;
    }
}
