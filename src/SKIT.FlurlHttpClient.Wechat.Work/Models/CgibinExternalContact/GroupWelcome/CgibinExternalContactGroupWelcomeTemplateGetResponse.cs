using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/group_welcome_template/get 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactGroupWelcomeTemplateGetResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Text : CgibinExternalContactGroupWelcomeTemplateAddRequest.Types.Text
            {
            }

            public class Image : CgibinExternalContactGroupWelcomeTemplateAddRequest.Types.Image
            {
            }

            public class Link : CgibinExternalContactGroupWelcomeTemplateAddRequest.Types.Link
            {
            }

            public class Video : CgibinExternalContactGroupWelcomeTemplateAddRequest.Types.Video
            {
            }

            public class MiniProgram : CgibinExternalContactGroupWelcomeTemplateAddRequest.Types.MiniProgram
            {
            }
        }

        /// <summary>
        /// 获取或设置文本消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("text")]
        [System.Text.Json.Serialization.JsonPropertyName("text")]
        public Types.Text? Text { get; set; }

        /// <summary>
        /// 获取或设置图片消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image")]
        [System.Text.Json.Serialization.JsonPropertyName("image")]
        public Types.Image? Image { get; set; }

        /// <summary>
        /// 获取或设置图文消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("link")]
        [System.Text.Json.Serialization.JsonPropertyName("link")]
        public Types.Link? Link { get; set; }

        /// <summary>
        /// 获取或设置视频消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("video")]
        [System.Text.Json.Serialization.JsonPropertyName("video")]
        public Types.Video? Video { get; set; }

        /// <summary>
        /// 获取或设置小程序消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("miniprogram")]
        [System.Text.Json.Serialization.JsonPropertyName("miniprogram")]
        public Types.MiniProgram? MiniProgram { get; set; }

        /// <summary>
        /// 获取或设置授权方安装的应用 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agentid")]
        [System.Text.Json.Serialization.JsonPropertyName("agentid")]
        public int? AgentId { get; set; }
    }
}
