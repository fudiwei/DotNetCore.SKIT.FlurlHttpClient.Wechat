namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/set_sharer_product_commission_info 接口的请求。</para>
    /// </summary>
    public class ChannelsECPromoterSetSharerProductCommissionInfoRequest : WechatApiRequest, IInferable<ChannelsECPromoterSetSharerProductCommissionInfoRequest, ChannelsECPromoterSetSharerProductCommissionInfoResponse>
    {
        /// <summary>
        /// 获取或设置推客的微信电商平台注册的身份标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sharer_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sharer_appid")]
        public string SharerAppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 获取或设置分佣比例（单位：万分数）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("commission_ratio")]
        [System.Text.Json.Serialization.JsonPropertyName("commission_ratio")]
        public int CommissionRatio { get; set; }
    }
}
