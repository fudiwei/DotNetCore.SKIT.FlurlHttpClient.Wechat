namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/supplier/base/get_supplier_base_info 接口的响应。</para>
    /// </summary>
    public class ChannelsECSupplierBaseGetSupplierBaseInfoResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置供货商名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = default!;
    }
}
