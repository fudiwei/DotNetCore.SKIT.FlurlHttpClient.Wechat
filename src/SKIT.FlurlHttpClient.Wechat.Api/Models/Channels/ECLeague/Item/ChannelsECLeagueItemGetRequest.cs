using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/item/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECLeagueItemGetRequest : WechatApiRequest, IInferable<ChannelsECLeagueItemGetRequest, ChannelsECLeagueItemGetResponse>
    {
        /// <summary>
        /// 获取或设置商品推广类别。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int? Type { get; set; }

        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public long? ProductId { get; set; }

        /// <summary>
        /// 获取或设置特殊推广商品计划 ID。
        /// </summary>
        [Obsolete("相关接口或字段于 2026-06-18 下线。")]
        [Newtonsoft.Json.JsonProperty("info_id")]
        [System.Text.Json.Serialization.JsonPropertyName("info_id")]
        public long? InfoId { get; set; }

        /// <summary>
        /// 获取或设置推广计划 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promotion_plan_id")]
        [System.Text.Json.Serialization.JsonPropertyName("promotion_plan_id")]
        public long? PromotionPlanId { get; set; }
    }
}
