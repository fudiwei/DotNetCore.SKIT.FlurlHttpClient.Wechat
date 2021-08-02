using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示被动回复视频消息的数据。</para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90241#%E8%A7%86%E9%A2%91%E6%B6%88%E6%81%AF </para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/90377#%E8%A7%86%E9%A2%91%E6%B6%88%E6%81%AF </para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90002/90151/90859#%E8%A7%86%E9%A2%91%E6%B6%88%E6%81%AF </para>
    /// </summary>
    public class VideoMessageReply : WechatWorkEvent, WechatWorkEvent.Types.IXmlSerializable
    {
        public new static class Types
        {
            public class Video
            {
                /// <summary>
                /// 获取或设置视频 MediaId。
                /// </summary>
                [System.Xml.Serialization.XmlElement("MediaId")]
                public string MediaId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置视频标题。
                /// </summary>
                [System.Xml.Serialization.XmlElement("Title")]
                public string Title { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置视频描述。
                /// </summary>
                [System.Xml.Serialization.XmlElement("Description")]
                public string Description { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置视频信息。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Video")]
        public Types.Video Video { get; set; } = new Types.Video();

        public VideoMessageReply()
        {
            Event = null;
            MessageType = "video";
        }
    }
}
