using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/get_user_behavior_data 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactGetUserBehaviorDataResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置数据统计时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stat_time")]
                [System.Text.Json.Serialization.JsonPropertyName("stat_time")]
                public long StatTimestamp { get; set; }

                /// <summary>
                /// 获取或设置聊天数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("chat_cnt")]
                [System.Text.Json.Serialization.JsonPropertyName("chat_cnt")]
                public int ChatCount { get; set; }

                /// <summary>
                /// 获取或设置发送消息数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("message_cnt")]
                [System.Text.Json.Serialization.JsonPropertyName("message_cnt")]
                public int MessageCount { get; set; }

                /// <summary>
                /// 获取或设置已回复聊天占比。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reply_percentage")]
                [System.Text.Json.Serialization.JsonPropertyName("reply_percentage")]
                public double? ReplyPercentage { get; set; }

                /// <summary>
                /// 获取或设置平均首次回复时长（单位：分钟）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("avg_reply_time")]
                [System.Text.Json.Serialization.JsonPropertyName("avg_reply_time")]
                public int? ReplyAverageTime { get; set; }

                /// <summary>
                /// 获取或设置删除或拉黑成员的客户数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("negative_feedback_cnt")]
                [System.Text.Json.Serialization.JsonPropertyName("negative_feedback_cnt")]
                public int NegativeFeedbackCount { get; set; }

                /// <summary>
                /// 获取或设置新发起申请数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("new_apply_cnt")]
                [System.Text.Json.Serialization.JsonPropertyName("new_apply_cnt")]
                public int NewApplyCount { get; set; }

                /// <summary>
                /// 获取或设置新增客户数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("new_contact_cnt")]
                [System.Text.Json.Serialization.JsonPropertyName("new_contact_cnt")]
                public int NewContactCount { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("behavior_data")]
        [System.Text.Json.Serialization.JsonPropertyName("behavior_data")]
        public Types.Data[] DataList { get; set; } = default!;
    }
}
