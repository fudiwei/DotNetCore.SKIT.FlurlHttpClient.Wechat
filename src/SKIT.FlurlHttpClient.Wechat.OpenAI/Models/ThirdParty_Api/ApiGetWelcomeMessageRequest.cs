﻿namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.ThirdParty
{
    /// <summary>
    /// <para>表示 [POST] /v2/api/get_welcome_msg 接口的请求。</para>
    /// </summary>
    public class ApiGetWelcomeMessageRequest : WechatOpenAIThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置渠道 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channelId")]
        [System.Text.Json.Serialization.JsonPropertyName("channelId")]
        public string ChannelId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置标签 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lableId")]
        [System.Text.Json.Serialization.JsonPropertyName("lableId")]
        public string? LabelId { get; set; }
    }
}
