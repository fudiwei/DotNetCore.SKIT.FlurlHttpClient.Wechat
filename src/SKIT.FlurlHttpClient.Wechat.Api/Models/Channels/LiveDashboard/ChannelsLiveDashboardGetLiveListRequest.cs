namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/livedashboard/getlivelist 接口的请求。</para>
    /// </summary>
    public class ChannelsLiveDashboardGetLiveListRequest : WechatApiRequest, IInferable<ChannelsLiveDashboardGetLiveListRequest, ChannelsLiveDashboardGetLiveListResponse>
    {
        /// <summary>
        /// 获取或设置日期字符串（格式：yyyyMMdd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ds")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalStringConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("ds")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringConverter))]
        public string DateString { get; set; } = string.Empty;
    }
}
