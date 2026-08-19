using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/item/upd 接口的响应。</para>
    /// </summary>
    public class ChannelsECLeagueItemUpdateResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置特殊推广商品计划 ID。
        /// </summary>
        [Obsolete("相关接口或字段于 2026-06-18 下线。")]
        [Newtonsoft.Json.JsonProperty("info_id")]
        [System.Text.Json.Serialization.JsonPropertyName("info_id")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public long? InfoId { get; set; }

        /// <summary>
        /// 获取或设置推广计划 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promotion_plan_id")]
        [System.Text.Json.Serialization.JsonPropertyName("promotion_plan_id")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public long? PromotionPlanId { get; set; }
    }
}
