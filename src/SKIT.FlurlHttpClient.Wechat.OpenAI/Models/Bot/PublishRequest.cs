using System;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /publish/{TOKEN} 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2023-04-10 下线。")]
    public class PublishRequest : WechatOpenAIRequest, WechatOpenAIRequest.Serialization.IEncryptedXmlable
    {
        /// <summary>
        /// 获取或设置管理员 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("managerid")]
        [System.Text.Json.Serialization.JsonPropertyName("managerid")]
        public string ManagerId { get; set; } = string.Empty;
    }
}
