using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/groupchat/statistic_group_by_day 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactGroupChatStatisticsGroupByDayResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Statistics : CgibinExternalContactGroupChatStatisticsResponse.Types.Data.Types.Statistics
                    {
                    }
                }

                /// <summary>
                /// 获取或设置数据统计时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stat_time")]
                [System.Text.Json.Serialization.JsonPropertyName("stat_time")]
                public long StatisticsTimestamp { get; set; }

                /// <summary>
                /// 获取或设置统计数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("data")]
                [System.Text.Json.Serialization.JsonPropertyName("data")]
                public Types.Statistics Statistics { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("items")]
        [System.Text.Json.Serialization.JsonPropertyName("items")]
        public Types.Data[] DataList { get; set; } = default!;
    }
}
