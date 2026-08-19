using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/item/batchadd 接口的响应。</para>
    /// </summary>
    public class ChannelsECLeagueItemBatchAddResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Result
            {
                /// <summary>
                /// 获取或设置错误码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errcode")]
                [System.Text.Json.Serialization.JsonPropertyName("errcode")]
                public int ErrorCode { get; set; }

                /// <summary>
                /// 获取或设置错误信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errmsg")]
                [System.Text.Json.Serialization.JsonPropertyName("errmsg")]
                public string? ErrorMessage { get; set; }

                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long ProductId { get; set; }

                /// <summary>
                /// 获取或设置推广计划 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("promotion_plan_id")]
                [System.Text.Json.Serialization.JsonPropertyName("promotion_plan_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long? PromotionPlanId { get; set; }

                /// <summary>
                /// 获取或设置特殊推广商品计划 ID。
                /// </summary>
                [Obsolete("相关接口或字段于 2026-06-18 下线。")]
                [Newtonsoft.Json.JsonProperty("info_id")]
                [System.Text.Json.Serialization.JsonPropertyName("info_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long? InfoId { get; set; }

                /// <summary>
                /// 获取或设置失败的视频号 ID 列表。
                /// </summary>
                [Obsolete("相关接口或字段于 2026-06-18 下线。")]
                [Newtonsoft.Json.JsonProperty("fail_finder_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("fail_finder_ids")]
                public string[]? FailedFinderIdList { get; set; }

                /// <summary>
                /// 获取或设置失败的带货达人 AppId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fail_talent_appids")]
                [System.Text.Json.Serialization.JsonPropertyName("fail_talent_appids")]
                public string[]? FailedTalentAppIdList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result_info_list")]
        [System.Text.Json.Serialization.JsonPropertyName("result_info_list")]
        public Types.Result[] ResultList { get; set; } = default!;
    }
}
