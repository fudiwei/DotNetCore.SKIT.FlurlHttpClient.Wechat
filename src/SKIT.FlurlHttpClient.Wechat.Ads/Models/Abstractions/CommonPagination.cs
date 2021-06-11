using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Wechat.Ads.Models.Abstractions
{
    public sealed class CommonPagination
    {
        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_number")]
        [System.Text.Json.Serialization.JsonPropertyName("total_number")]
        public int TotalNumber { get; set; }

        /// <summary>
        /// 获取或设置总页数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_page")]
        [System.Text.Json.Serialization.JsonPropertyName("total_page")]
        public int TotalPage { get; set; }

        /// <summary>
        /// 获取或设置页大小。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int PageSize { get; set; }

        /// <summary>
        /// 获取或设置页码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page")]
        [System.Text.Json.Serialization.JsonPropertyName("page")]
        public int Page { get; set; }
    }
}
