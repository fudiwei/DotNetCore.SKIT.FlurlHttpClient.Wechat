namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_shop_live_record_list 接口的响应。</para>
    /// </summary>
    public class ChannelsECPromoterGetShopLiveRecordListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class LiveRecord : ChannelsECPromoterGetLiveRecordListResponse.Types.LiveRecord
            {
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
