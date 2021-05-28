using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /datacube/getinterfacesummary 接口的响应。</para>
    /// </summary>
    public class DataCubeGetInterfaceSummaryResponse : WechatApiResponse
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
                /// 获取或设置被动回复用户消息的次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("callback_count")]
                [System.Text.Json.Serialization.JsonPropertyName("callback_count")]
                public int CallbackCount { get; set; }

                /// <summary>
                /// 获取或设置被动回复用户消息失败的次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fail_count")]
                [System.Text.Json.Serialization.JsonPropertyName("fail_count")]
                public int CallbackFailCount { get; set; }

                /// <summary>
                /// 获取或设置总耗时（单位：毫秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_time_cost")]
                [System.Text.Json.Serialization.JsonPropertyName("total_time_cost")]
                public int TotalTimeCost { get; set; }

                /// <summary>
                /// 获取或设置最大耗时（单位：毫秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("max_time_cost")]
                [System.Text.Json.Serialization.JsonPropertyName("max_time_cost")]
                public int MaxTimeCost { get; set; }
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
