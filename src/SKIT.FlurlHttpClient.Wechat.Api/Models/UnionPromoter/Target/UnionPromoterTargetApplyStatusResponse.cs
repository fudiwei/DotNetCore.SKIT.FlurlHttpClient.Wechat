using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /union/promoter/target/apply_status 接口的响应。</para>
    /// </summary>
    public class UnionPromoterTargetApplyStatusResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置定向计划 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("planId")]
                [System.Text.Json.Serialization.JsonPropertyName("planId")]
                public string PlanId { get; set; } = default!;

                /// <summary>
                /// 获取或设置申请状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("promoterStatus")]
                [System.Text.Json.Serialization.JsonPropertyName("promoterStatus")]
                public int PromoterStatus { get; set; }

                /// <summary>
                /// 获取或设置申请原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("applyReason")]
                [System.Text.Json.Serialization.JsonPropertyName("applyReason")]
                public string? ApplyReason { get; set; }

                /// <summary>
                /// 获取或设置申请时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("applyTime")]
                [System.Text.Json.Serialization.JsonPropertyName("applyTime")]
                public long? ApplyTimestamp { get; set; }

                /// <summary>
                /// 获取或设置加入时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("joinTime")]
                [System.Text.Json.Serialization.JsonPropertyName("joinTime")]
                public long? JoinTimestamp { get; set; }

                /// <summary>
                /// 获取或设置拒绝时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("rejectTime")]
                [System.Text.Json.Serialization.JsonPropertyName("rejectTime")]
                public long? RejectTimestamp { get; set; }

                /// <summary>
                /// 获取或设置移除时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("removeTime")]
                [System.Text.Json.Serialization.JsonPropertyName("removeTime")]
                public long? RemoveTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
