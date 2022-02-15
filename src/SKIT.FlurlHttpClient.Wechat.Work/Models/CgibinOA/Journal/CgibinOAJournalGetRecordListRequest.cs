using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/journal/get_record_list 接口的请求。</para>
    /// </summary>
    public class CgibinOAJournalGetRecordListRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Filter : CgibinOAGetApprovalInfoRequest.Types.Filter
            {
            }
        }

        /// <summary>
        /// 获取或设置指定开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("starttime")]
        [System.Text.Json.Serialization.JsonPropertyName("starttime")]
        public long StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置指定开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endtime")]
        [System.Text.Json.Serialization.JsonPropertyName("endtime")]
        public long EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public int NextCursor { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int Limit { get; set; } = 100;

        /// <summary>
        /// 获取或设置筛选条件列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("filters")]
        [System.Text.Json.Serialization.JsonPropertyName("filters")]
        public IList<Types.Filter>? FilterList { get; set; }
    }
}
