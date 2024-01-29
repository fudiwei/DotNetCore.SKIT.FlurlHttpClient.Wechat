namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.open_product_spu_status_update 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/ministore/minishopopencomponent2/callback/spu_status_update.html </para>
    /// </summary>
    public class OpenProductSPUStatusUpdateEvent : WechatApiEvent
    {
        public static class Types
        {
            public class EventData
            {
                /// <summary>
                /// 获取或设置审核状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                [System.Xml.Serialization.XmlElement("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置商家自定义商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("out_product_id")]
                [System.Xml.Serialization.XmlElement("out_product_id")]
                public string OutProductId { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                [System.Xml.Serialization.XmlElement("product_id")]
                public long ProductId { get; set; }

                /// <summary>
                /// 获取或设置下架原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reject_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("reject_reason")]
                [System.Xml.Serialization.XmlElement("reject_reason")]
                public string? RejectReason { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置事件数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("OpenProductSpuAudit")]
        [System.Text.Json.Serialization.JsonPropertyName("OpenProductSpuAudit")]
        [System.Xml.Serialization.XmlElement("OpenProductSpuAudit")]
        public Types.EventData EventData { get; set; } = default!;
    }
}
