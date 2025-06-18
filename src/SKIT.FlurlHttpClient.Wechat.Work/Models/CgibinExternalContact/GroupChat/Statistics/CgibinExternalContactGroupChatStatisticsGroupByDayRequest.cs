namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/groupchat/statistic_group_by_day 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactGroupChatStatisticsGroupByDayRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class OwnerFilter : CgibinExternalContactGroupChatStatisticsRequest.Types.OwnerFilter
            {
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
    }
}
