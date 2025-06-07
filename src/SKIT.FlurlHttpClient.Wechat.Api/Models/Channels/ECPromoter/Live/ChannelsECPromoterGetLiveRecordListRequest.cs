namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_live_record_list 接口的请求。</para>
    /// </summary>
    public class ChannelsECPromoterGetLiveRecordListRequest : WechatApiRequest, IInferable<ChannelsECPromoterGetLiveRecordListRequest, ChannelsECPromoterGetLiveRecordListResponse>
    {
        /// <summary>
        /// 获取或设置达人平台 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("talent_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("talent_appid")]
        public string TalentAppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置推客 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sharer_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sharer_appid")]
        public string? SharerAppId { get; set; }

        /// <summary>
        /// 获取或设置小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mini_program_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("mini_program_appid")]
        public string MiniProgramAppId { get; set; } = string.Empty;
    }
}
