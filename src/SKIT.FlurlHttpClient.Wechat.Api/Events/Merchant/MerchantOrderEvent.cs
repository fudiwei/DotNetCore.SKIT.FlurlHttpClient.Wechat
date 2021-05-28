using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.merchant_order 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/WeChat_Stores/WeChat_Store_Interface.html#8 </para>
    /// </summary>
    public class MerchantOrderEvent : WechatApiEvent, WechatApiEvent.Types.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置订单号。
        /// </summary>
        [System.Xml.Serialization.XmlElement("OrderId")]
        public string OrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置订单状态。
        /// </summary>
        [System.Xml.Serialization.XmlElement("OrderStatus")]
        public int OrderStatus { get; set; }

        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [System.Xml.Serialization.XmlElement("ProductId")]
        public string ProductId { get; set; } = default!;

        /// <summary>
        /// 获取或设置 SKU 信息。
        /// </summary>
        [System.Xml.Serialization.XmlElement("SkuInfo")]
        public string SKUInformation { get; set; } = default!;
    }
}
