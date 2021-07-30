using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示被动回复音乐消息的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Passive_user_reply_message.html#4 </para>
    /// </summary>
    public class MusicMessageReply : WechatApiEvent, WechatApiEvent.Types.IXmlSerializable
    {
        public new static class Types
        {
            public class Music
            {
                /// <summary>
                /// 获取或设置音乐链接。
                /// </summary>
                [System.Xml.Serialization.XmlElement("MusicUrl")]
                public string MusicUrl { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置高质量音乐链接。
                /// </summary>
                [System.Xml.Serialization.XmlElement("HQMusicUrl", IsNullable = true)]
                public string? HQMusicUrl { get; set; }

                /// <summary>
                /// 获取或设置音乐封面图片 MediaId。
                /// </summary>
                [System.Xml.Serialization.XmlElement("ThumbMediaId")]
                public string ThumbMediaId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置音乐标题。
                /// </summary>
                [System.Xml.Serialization.XmlElement("Title")]
                public string Title { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置音乐描述。
                /// </summary>
                [System.Xml.Serialization.XmlElement("Description")]
                public string Description { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置音乐信息。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Music")]
        public Types.Music Music { get; set; } = new Types.Music();

        public MusicMessageReply()
        {
            Event = null;
            MessageType = "music";
        }
    }
}
