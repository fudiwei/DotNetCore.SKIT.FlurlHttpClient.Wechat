using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /openapi/publish_progress/{TOKEN} 接口的响应。</para>
    /// </summary>
    public class OpenApiPublishProgressResponse : WechatOpenAIResponse<OpenApiPublishProgressResponse.Types.Data>
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
    }
}
