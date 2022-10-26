namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.create_map_poi_audit_info 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/WeChat_Stores/WeChat_Shop_Miniprogram_Interface.html#11 </para>
    /// </summary>
    public class CreateMapPOIAuditInfoEvent : WechatApiEvent, WechatApiEvent.Serialization.IJsonSerializable, WechatApiEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置审核单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_id")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_id")]
        [System.Xml.Serialization.XmlElement("audit_id")]
        public long AuditId { get; set; }

        /// <summary>
        /// 获取或设置审核状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        [System.Xml.Serialization.XmlElement("status")]
        public int AuditStatus { get; set; }

        /// <summary>
        /// 获取或设置腾讯地图的位置点 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("map_poi_id")]
        [System.Text.Json.Serialization.JsonPropertyName("map_poi_id")]
        [System.Xml.Serialization.XmlElement("map_poi_id")]
        public string MapPOIId { get; set; } = default!;

        /// <summary>
        /// 获取或设置门店名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        [System.Xml.Serialization.XmlElement("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 获取或设置门店详细地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address")]
        [System.Text.Json.Serialization.JsonPropertyName("address")]
        [System.Xml.Serialization.XmlElement("address")]
        public string Address { get; set; } = default!;

        /// <summary>
        /// 获取或设置门店位置经度。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("longitude")]
        [System.Text.Json.Serialization.JsonPropertyName("longitude")]
        [System.Xml.Serialization.XmlElement("longitude")]
        public double Longitude { get; set; }

        /// <summary>
        /// 获取或设置门店位置纬度。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("latitude")]
        [System.Text.Json.Serialization.JsonPropertyName("latitude")]
        [System.Xml.Serialization.XmlElement("latitude")]
        public double Latitude { get; set; }

        /// <summary>
        /// 获取或设置备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sh_remark")]
        [System.Text.Json.Serialization.JsonPropertyName("sh_remark")]
        [System.Xml.Serialization.XmlElement("sh_remark")]
        public string Remark { get; set; } = default!;
    }
}
