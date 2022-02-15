using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/getillegalrecords 接口的请求。</para>
    /// </summary>
    public class WxaGetIllegalRecordsRequest : WechatApiRequest, IMapResponse<WxaGetIllegalRecordsRequest, WxaGetIllegalRecordsResponse>
    {
        /// <summary>
        /// 获取或设置查询时间段的开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_time")]
        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public long? StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置查询时间段的开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long? EndTimestamp { get; set; }
    }
}
