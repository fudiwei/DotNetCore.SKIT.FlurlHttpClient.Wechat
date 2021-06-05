using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/report/patrol/get_order_list 接口的请求。</para>
    /// </summary>
    public class CgibinReportPatrolGetOrderListRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置指定时间后创建的时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("begin_create_time")]
        [System.Text.Json.Serialization.JsonPropertyName("begin_create_time")]
        public long? CreateBeginTimestamp { get; set; }

        /// <summary>
        /// 获取或设置指定时间后修改的时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("begin_modify_time")]
        [System.Text.Json.Serialization.JsonPropertyName("begin_modify_time")]
        public long? ModifyBeginTimestamp { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }
    }
}
