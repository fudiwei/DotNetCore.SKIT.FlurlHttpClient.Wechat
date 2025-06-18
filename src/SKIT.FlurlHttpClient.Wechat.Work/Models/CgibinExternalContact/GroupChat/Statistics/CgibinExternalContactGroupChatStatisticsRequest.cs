using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/groupchat/statistic 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactGroupChatStatisticsRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class OwnerFilter
            {
                /// <summary>
                /// 获取或设置指定成员账号列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid_list")]
                [System.Text.Json.Serialization.JsonPropertyName("userid_list")]
                public IList<string>? UserIdList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置起始日期时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("day_begin_time")]
        [System.Text.Json.Serialization.JsonPropertyName("day_begin_time")]
        public long DayBeginTimestamp { get; set; }

        /// <summary>
        /// 获取或设置结束日期时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("day_end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("day_end_time")]
        public long? DayEndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置指定成员信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("owner_filter")]
        [System.Text.Json.Serialization.JsonPropertyName("owner_filter")]
        public Types.OwnerFilter Owner { get; set; } = new Types.OwnerFilter();

        /// <summary>
        /// 获取或设置排序方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_by")]
        [System.Text.Json.Serialization.JsonPropertyName("order_by")]
        public int? OrderBy { get; set; }

        /// <summary>
        /// 获取或设置是否升序排序。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_asc")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("order_asc")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool? IsAscending { get; set; }

        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }
    }
}
