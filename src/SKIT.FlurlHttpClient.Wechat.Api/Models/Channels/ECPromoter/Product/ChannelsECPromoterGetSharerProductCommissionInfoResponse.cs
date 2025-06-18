namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_sharer_product_commission_info 接口的响应。</para>
    /// </summary>
    public class ChannelsECPromoterGetSharerProductCommissionInfoResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置是否设置过分佣比例。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_set")]
        [System.Text.Json.Serialization.JsonPropertyName("is_set")]
        public bool IsSet { get; set; }

        /// <summary>
        /// 获取或设置分佣比例（单位：万分数）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("commission_ratio")]
        [System.Text.Json.Serialization.JsonPropertyName("commission_ratio")]
        public int CommissionRatio { get; set; }
    }
}
