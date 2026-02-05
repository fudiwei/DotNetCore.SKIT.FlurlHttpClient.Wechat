namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/supplier/relation/invite_supplier 接口的请求。</para>
    /// </summary>
    public class ChannelsECSupplierRelationInviteSupplierRequest : WechatApiRequest, IInferable<ChannelsECSupplierRelationInviteSupplierRequest, ChannelsECSupplierRelationInviteSupplierResponse>
    {
        /// <summary>
        /// 获取或设置供货商 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("supplier_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("supplier_appid")]
        public string SupplierAppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置第三方服务商 ServiceId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_id")]
        [System.Text.Json.Serialization.JsonPropertyName("service_id")]
        public int? ServiceId { get; set; }

        /// <summary>
        /// 获取或设置备注信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        [System.Text.Json.Serialization.JsonPropertyName("remark")]
        public string? Remark { get; set; }
    }
}
