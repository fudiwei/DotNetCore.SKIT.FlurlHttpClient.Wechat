using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/item/upd 接口的请求。</para>
    /// </summary>
    public class ChannelsECLeagueItemUpdateRequest : WechatApiRequest, IInferable<ChannelsECLeagueItemUpdateRequest, ChannelsECLeagueItemUpdateResponse>
    {
        public static class Types
        {
            public class ExclusiveInfo
            {
                /// <summary>
                /// 获取或设置新增的视频号 ID 列表。
                /// </summary>
                [Obsolete("相关接口或字段于 2026-06-18 下线。")]
                [Newtonsoft.Json.JsonProperty("add_finder_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("add_finder_ids")]
                public IList<string>? AddFinderIdList { get; set; }

                /// <summary>
                /// 获取或设置删除的视频号 ID 列表。
                /// </summary>
                [Obsolete("相关接口或字段于 2026-06-18 下线。")]
                [Newtonsoft.Json.JsonProperty("del_finder_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("del_finder_ids")]
                public IList<string>? DeleteFinderIdList { get; set; }

                /// <summary>
                /// 获取或设置新增的带货达人 AppId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("add_talent_appids")]
                [System.Text.Json.Serialization.JsonPropertyName("add_talent_appids")]
                public IList<string>? AddTalentAppIdList { get; set; }

                /// <summary>
                /// 获取或设置删除的带货达人 AppId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("del_talent_appids")]
                [System.Text.Json.Serialization.JsonPropertyName("del_talent_appids")]
                public IList<string>? DeleteTalentAppIdList { get; set; }

                /// <summary>
                /// 获取或设置推广开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("begin_time")]
                [System.Text.Json.Serialization.JsonPropertyName("begin_time")]
                public long? BeginTimestamp { get; set; }

                /// <summary>
                /// 获取或设置推广开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                public long? EndTimestamp { get; set; }

                /// <summary>
                /// 获取或设置是否永久推广。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_forerver")]
                [System.Text.Json.Serialization.JsonPropertyName("is_forerver")]
                public bool? IsForerver { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置操作类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operate_type")]
        [System.Text.Json.Serialization.JsonPropertyName("operate_type")]
        public int OperateType { get; set; }

        /// <summary>
        /// 获取或设置商品推广类别。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int Type { get; set; }

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

        /// <summary>
        /// 获取或设置佣金率（范围：0～100）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ratio")]
        [System.Text.Json.Serialization.JsonPropertyName("ratio")]
        public int? CommissionRatio { get; set; }

        /// <summary>
        /// 获取或设置特殊推广信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("exclusive_info")]
        [System.Text.Json.Serialization.JsonPropertyName("exclusive_info")]
        public Types.ExclusiveInfo? ExclusiveInfo { get; set; }
    }
}
