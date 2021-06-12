using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Wechat.Ads.Models.Abstractions
{
    public sealed class CommonDateRange
    {
        /// <summary>
        /// 获取或设置开始日期字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_date")]
        [System.Text.Json.Serialization.JsonPropertyName("start_date")]
        public string StartDateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置结束日期字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_date")]
        [System.Text.Json.Serialization.JsonPropertyName("end_date")]
        public string EndDateString { get; set; } = string.Empty;
    }
}
