namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/logistics/ewaybill/biz/account/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECLogisticsEWaybillAccountGetRequest : WechatApiRequest, IInferable<ChannelsECLogisticsEWaybillAccountGetRequest, ChannelsECLogisticsEWaybillAccountGetResponse>
    {
        /// <summary>
        /// 获取或设置快递公司 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_id")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
        public string? DeliveryId { get; set; }

        /// <summary>
        /// 获取或设置电子面单账号 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acct_id")]
        [System.Text.Json.Serialization.JsonPropertyName("acct_id")]
        public string? AccountId { get; set; }

        /// <summary>
        /// 获取或设置状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// 获取或设置是否需要查询库存。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_balance")]
        [System.Text.Json.Serialization.JsonPropertyName("need_balance")]
        public bool RequireBalance { get; set; }

        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int Limit { get; set; } = 10;
    }
}
