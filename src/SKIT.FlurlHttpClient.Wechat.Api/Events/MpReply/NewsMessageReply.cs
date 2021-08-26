using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示被动回复图文消息的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Passive_user_reply_message.html#5 </para>
    /// </summary>
    public class NewsMessageReply : WechatApiEvent, WechatApiEvent.Serialization.IXmlSerializable
    {
        public static class Types
        {
            public class ArticleItem
            {
                /// <summary>
                /// 获取或设置图文链接。
                /// </summary>
                [System.Xml.Serialization.XmlElement("Url")]
                public string Url { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置图文封面图片链接。
                /// </summary>
                [System.Xml.Serialization.XmlElement("PicUrl")]
                public string PictureUrl { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置图文标题。
                /// </summary>
                [System.Xml.Serialization.XmlElement("Title")]
                public string Title { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置图文描述。
                /// </summary>
                [System.Xml.Serialization.XmlElement("Description")]
                public string Description { get; set; } = string.Empty;
            }

            public class ArticleList
            {
                /// <summary>
                /// 获取或设置图文列表。
                /// </summary>
                [System.Xml.Serialization.XmlElement("item", Type = typeof(ArticleItem))]
                public ArticleItem[] Items { get; set; } = new ArticleItem[0];
            }
        }

        /// <summary>
        /// 获取或设置图文数量。
        /// </summary>
        [System.Xml.Serialization.XmlElement("ArticleCount")]
        public int ArticleCount { get; set; }

        /// <summary>
        /// 获取或设置图文列表。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Articles")]
        public Types.ArticleList ArticleList { get; set; } = new Types.ArticleList();

        public NewsMessageReply()
        {
            Event = null;
            MessageType = "news";
        }
    }
}
