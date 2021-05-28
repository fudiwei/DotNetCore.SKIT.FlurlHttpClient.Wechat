using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /datacube/getcardmembercardinfo 接口的响应。</para>
    /// </summary>
    public class DataCubeGetCardMemberCardInfoResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置数据的日期（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ref_date")]
                [System.Text.Json.Serialization.JsonPropertyName("ref_date")]
                public string RefDateString { get; set; } = default!;

                /// <summary>
                /// 获取或设置浏览次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("view_cnt")]
                [System.Text.Json.Serialization.JsonPropertyName("view_cnt")]
                public int ViewCount { get; set; }

                /// <summary>
                /// 获取或设置浏览人数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("view_user")]
                [System.Text.Json.Serialization.JsonPropertyName("view_user")]
                public int ViewUserCount { get; set; }

                /// <summary>
                /// 获取或设置领取次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receive_cnt")]
                [System.Text.Json.Serialization.JsonPropertyName("receive_cnt")]
                public int ReceiveCount { get; set; }

                /// <summary>
                /// 获取或设置领取人数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receive_user")]
                [System.Text.Json.Serialization.JsonPropertyName("receive_user")]
                public int ReceiveUserCount { get; set; }

                /// <summary>
                /// 获取或设置使用次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("verify_cnt")]
                [System.Text.Json.Serialization.JsonPropertyName("verify_cnt")]
                public int ConsumeCount { get; set; }

                /// <summary>
                /// 获取或设置使用人数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("verify_user")]
                [System.Text.Json.Serialization.JsonPropertyName("verify_user")]
                public int ConsumeUserCount { get; set; }

                /// <summary>
                /// 获取或设置激活次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("active_cnt")]
                [System.Text.Json.Serialization.JsonPropertyName("active_cnt")]
                public int ActiveCount { get; set; }

                /// <summary>
                /// 获取或设置激活人数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("active_user")]
                [System.Text.Json.Serialization.JsonPropertyName("active_user")]
                public int ActiveUserCount { get; set; }

                /// <summary>
                /// 获取或设置有效会员总人数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_user")]
                [System.Text.Json.Serialization.JsonPropertyName("total_user")]
                public int TotalUserCount { get; set; }

                /// <summary>
                /// 获取或设置历史领取会员卡总人数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_receive_user")]
                [System.Text.Json.Serialization.JsonPropertyName("total_receive_user")]
                public int TotalReceiveUserCount { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.Data[] DataList { get; set; } = default!;
    }
}
