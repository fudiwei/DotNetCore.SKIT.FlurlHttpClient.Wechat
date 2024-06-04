using System;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /publish_progress/{TOKEN} 接口的响应。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2023-04-10 下线。")]
    public class PublishProgressResponse : WechatOpenAIResponse<PublishProgressResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置进度（范围：0～100）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("progress")]
                [System.Text.Json.Serialization.JsonPropertyName("progress")]
                public int Progress { get; set; }

                /// <summary>
                /// 获取或设置状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public override int? ReturnCode { get; set; }

        /// <summary>
        /// 获取微信智能对话 API 返回的错误描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg")]
        [System.Text.Json.Serialization.JsonPropertyName("msg")]
        public string? ReturnMessage { get; set; }
    }
}
