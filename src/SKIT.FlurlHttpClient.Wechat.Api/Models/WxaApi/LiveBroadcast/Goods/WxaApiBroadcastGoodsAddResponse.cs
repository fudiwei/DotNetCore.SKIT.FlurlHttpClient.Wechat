namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/broadcast/goods/add 接口的响应。</para>
    /// </summary>
    public class WxaApiBroadcastGoodsAddResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goodsId")]
        [System.Text.Json.Serialization.JsonPropertyName("goodsId")]
        public int GoodsId { get; set; }

        /// <summary>
        /// 获取或设置审核单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auditId")]
        [System.Text.Json.Serialization.JsonPropertyName("auditId")]
        public long AuditId { get; set; }
    }
}
