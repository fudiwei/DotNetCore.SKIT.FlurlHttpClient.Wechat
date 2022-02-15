﻿namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示被动回复视频消息的数据。</para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90241#%E8%A7%86%E9%A2%91%E6%B6%88%E6%81%AF </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90377#%E8%A7%86%E9%A2%91%E6%B6%88%E6%81%AF </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90859#%E8%A7%86%E9%A2%91%E6%B6%88%E6%81%AF </para>
    /// </summary>
    public class VideoMessageReply : WechatWorkEvent, WechatWorkEvent.Serialization.IXmlSerializable
    {
        public static class Types
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
