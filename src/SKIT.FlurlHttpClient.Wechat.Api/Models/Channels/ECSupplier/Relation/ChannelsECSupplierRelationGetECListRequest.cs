namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/supplier/relation/get_ec_list 接口的请求。</para>
    /// </summary>
    public class ChannelsECSupplierRelationGetECListRequest : WechatApiRequest, IInferable<ChannelsECSupplierRelationGetECListRequest, ChannelsECSupplierRelationGetECListResponse>
    {
        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }
    }
}
