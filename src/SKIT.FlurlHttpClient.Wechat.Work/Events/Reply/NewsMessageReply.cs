using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示被动回复图文消息的数据。</para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90241#%E5%9B%BE%E6%96%87%E6%B6%88%E6%81%AF </para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/90377#%E5%9B%BE%E6%96%87%E6%B6%88%E6%81%AF </para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90002/90151/90859#%E5%9B%BE%E6%96%87%E6%B6%88%E6%81%AF </para>
    /// </summary>
    public class NewsMessageReply : WechatWorkEvent, WechatWorkEvent.Serialization.IXmlSerializable
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
