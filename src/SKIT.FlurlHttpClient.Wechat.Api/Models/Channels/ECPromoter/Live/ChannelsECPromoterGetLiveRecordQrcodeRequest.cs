namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_live_record_qr_code 接口的请求。</para>
    /// </summary>
    public class ChannelsECPromoterGetLiveRecordQrcodeRequest : WechatApiRequest, IInferable<ChannelsECPromoterGetLiveRecordQrcodeRequest, ChannelsECPromoterGetLiveRecordQrcodeResponse>
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
        /// 获取或设置直播 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("export_id")]
        [System.Text.Json.Serialization.JsonPropertyName("export_id")]
        public string ExportId { get; set; } = string.Empty;
    }
}
