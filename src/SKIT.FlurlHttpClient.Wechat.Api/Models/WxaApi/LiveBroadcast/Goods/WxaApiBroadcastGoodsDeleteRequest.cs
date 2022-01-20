namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/broadcast/goods/delete 接口的请求。</para>
    /// </summary>
    public class WxaApiBroadcastGoodsDeleteRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goodsId")]
        [System.Text.Json.Serialization.JsonPropertyName("goodsId")]
        public int GoodsId { get; set; }
    }
}
