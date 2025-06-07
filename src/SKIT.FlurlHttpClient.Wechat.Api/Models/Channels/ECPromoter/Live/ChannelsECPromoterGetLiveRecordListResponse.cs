namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_live_record_list 接口的响应。</para>
    /// </summary>
    public class ChannelsECPromoterGetLiveRecordListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class LiveRecord
            {
                /// <summary>
                /// 获取或设置直播 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("export_id")]
                [System.Text.Json.Serialization.JsonPropertyName("export_id")]
                public string ExportId { get; set; } = default!;

                /// <summary>
                /// 获取或设置直播描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string Description { get; set; } = default!;

                /// <summary>
                /// 获取或设置内嵌直播卡片时需要的推广参数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("promoter_share_link")]
                [System.Text.Json.Serialization.JsonPropertyName("promoter_share_link")]
                public string PromoterShareLink { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置直播数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("live_record_list")]
        [System.Text.Json.Serialization.JsonPropertyName("live_record_list")]
        public Types.LiveRecord[] LiveRecordList { get; set; } = default!;
    }
}
