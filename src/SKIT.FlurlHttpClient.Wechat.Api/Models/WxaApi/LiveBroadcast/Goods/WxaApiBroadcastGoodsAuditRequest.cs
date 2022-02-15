namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/broadcast/goods/audit 接口的请求。</para>
    /// </summary>
    public class WxaApiBroadcastGoodsAuditRequest : WechatApiRequest, IMapResponse<WxaApiBroadcastGoodsAuditRequest, WxaApiBroadcastGoodsAuditResponse>
    {
        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goodsId")]
        [System.Text.Json.Serialization.JsonPropertyName("goodsId")]
        public int GoodsId { get; set; }
    }
}
