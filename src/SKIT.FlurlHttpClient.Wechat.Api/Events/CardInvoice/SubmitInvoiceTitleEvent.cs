using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.submit_invoice_title 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/Quick_issuing/Interface_Instructions.html </para>
    /// </summary>
    public class SubmitInvoiceTitleEvent : WechatApiEvent, WechatApiEvent.Types.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置发票抬头类型。
        /// </summary>
        [System.Xml.Serialization.XmlElement("title_type")]
        public string TitleType { get; set; } = default!;

        /// <summary>
        /// 获取或设置发票抬头。
        /// </summary>
        [System.Xml.Serialization.XmlElement("title")]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 获取或设置税号。
        /// </summary>
        [System.Xml.Serialization.XmlElement("tax_no", IsNullable = true)]
        public string? TaxNumber { get; set; }

        /// <summary>
        /// 获取或设置联系电话。
        /// </summary>
        [System.Xml.Serialization.XmlElement("phone", IsNullable = true)]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// 获取或设置联系地址。
        /// </summary>
        [System.Xml.Serialization.XmlElement("addr", IsNullable = true)]
        public string? Address { get; set; }

        /// <summary>
        /// 获取或设置开户行。
        /// </summary>
        [System.Xml.Serialization.XmlElement("bank_type", IsNullable = true)]
        public string? Bank { get; set; }

        /// <summary>
        /// 获取或设置银行账号。
        /// </summary>
        [System.Xml.Serialization.XmlElement("bank_no", IsNullable = true)]
        public string? BankNumber { get; set; }

        /// <summary>
        /// 获取或设置附加信息。
        /// </summary>
        [System.Xml.Serialization.XmlElement("attach", IsNullable = true)]
        public string? Attachment { get; set; }
    }
}
