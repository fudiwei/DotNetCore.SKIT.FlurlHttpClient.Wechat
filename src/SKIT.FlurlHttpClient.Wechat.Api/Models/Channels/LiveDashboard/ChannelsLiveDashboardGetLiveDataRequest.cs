namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/livedashboard/getlivedata 接口的请求。</para>
    /// </summary>
    public class ChannelsLiveDashboardGetLiveDataRequest : WechatApiRequest, IInferable<ChannelsLiveDashboardGetLiveDataRequest, ChannelsLiveDashboardGetLiveDataResponse>
    {
        /// <summary>
        /// 获取或设置直播唯一 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("export_id")]
        [System.Text.Json.Serialization.JsonPropertyName("export_id")]
        public string ExportId { get; set; } = string.Empty;
    }
}
