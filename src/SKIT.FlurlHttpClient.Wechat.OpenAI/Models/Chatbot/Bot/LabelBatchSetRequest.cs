using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /label/batchset/{TOKEN} 接口的请求。</para>
    /// </summary>
    public class LabelBatchSetRequest : WechatChatbotRequest, WechatChatbotRequest.Serialization.IEncryptedXmlable
    {
        public static class Types
        {
            public class OpenIdList
            {
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public IList<string> Items { get; set; } = new List<string>();
            }
        }

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置标签名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category")]
        [System.Text.Json.Serialization.JsonPropertyName("category")]
        public string Category { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置二级标签名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("label")]
        [System.Text.Json.Serialization.JsonPropertyName("label")]
        public string Label { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置标签分类规则。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc")]
        [System.Text.Json.Serialization.JsonPropertyName("desc")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置要设置标签的 OpenId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.OpenIdList OpenIdList { get; set; } = new Types.OpenIdList();
    }
}
