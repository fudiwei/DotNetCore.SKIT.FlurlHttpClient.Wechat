namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.aftersale_wait_merchant_confirm_receipt 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/ministore/minishopopencomponent2/callback/aftersale/aftersale_wait_merchant_confirm_receipt.html ]]>
    /// </para>
    /// </summary>
    public class AftersaleWaitMerchantConfirmReceiptEvent : WechatApiEvent
    {
        public static class Types
        {
            public class AftersaleOrder
            {
                /// <summary>
                /// 获取或设置售后单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("aftersale_id")]
                [System.Text.Json.Serialization.JsonPropertyName("aftersale_id")]
                [System.Xml.Serialization.XmlElement("aftersale_id")]
                public long AftersaleOrderId { get; set; }

                /// <summary>
                /// 获取或设置商家自定义售后单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_aftersale_id")]
                [System.Text.Json.Serialization.JsonPropertyName("out_aftersale_id")]
                [System.Xml.Serialization.XmlElement("out_aftersale_id")]
                public string OutAftersaleOrderId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置售后单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aftersale_info")]
        [System.Text.Json.Serialization.JsonPropertyName("aftersale_info")]
        [System.Xml.Serialization.XmlElement("aftersale_info")]
        public Types.AftersaleOrder AftersaleOrder { get; set; } = default!;
    }
}
