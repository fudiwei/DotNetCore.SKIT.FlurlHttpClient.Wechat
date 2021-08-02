using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示被动回复图片消息的数据。</para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90241#%E5%9B%BE%E7%89%87%E6%B6%88%E6%81%AF </para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/90377#%E5%9B%BE%E7%89%87%E6%B6%88%E6%81%AF </para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90002/90151/90859#%E5%9B%BE%E7%89%87%E6%B6%88%E6%81%AF </para>
    /// </summary>
    public class ImageMessageReply : WechatWorkEvent, WechatWorkEvent.Types.IXmlSerializable
    {
        public new static class Types
        {
            public class Image
            {
                /// <summary>
                /// 获取或设置图片 MediaId。
                /// </summary>
                [System.Xml.Serialization.XmlElement("MediaId")]
                public string MediaId { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置图片信息。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Image")]
        public Types.Image Image { get; set; } = new Types.Image();

        public ImageMessageReply()
        {
            Event = null;
            MessageType = "image";
        }
    }
}
