namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/warehouse/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECWarehouseGetRequest : WechatApiRequest, IInferable<ChannelsECWarehouseGetRequest, ChannelsECWarehouseGetResponse>
    {
        /// <summary>
        /// 获取或设置外部仓库 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_warehouse_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_warehouse_id")]
        public string OutWarehouseId { get; set; } = string.Empty;
    }
}
