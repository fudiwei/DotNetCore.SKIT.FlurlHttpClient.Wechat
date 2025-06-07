namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_live_notice_record_list 接口的响应。</para>
    /// </summary>
    public class ChannelsECPromoterGetLiveNoticeRecordListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class LiveNoticeRecord
            {
                /// <summary>
                /// 获取或设置预约 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("notice_id")]
                [System.Text.Json.Serialization.JsonPropertyName("notice_id")]
                public string NoticeId { get; set; } = default!;

                /// <summary>
                /// 获取或设置预约描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string Description { get; set; } = default!;

                /// <summary>
                /// 获取或设置直播开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_time")]
                [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                public long StartTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置直播预约数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("live_notice_record_list")]
        [System.Text.Json.Serialization.JsonPropertyName("live_notice_record_list")]
        public Types.LiveNoticeRecord[] LiveNoticeRecordList { get; set; } = default!;
    }
}
