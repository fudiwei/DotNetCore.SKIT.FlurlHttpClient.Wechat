namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/livedashboard/getlivedata 接口的响应。</para>
    /// </summary>
    public class ChannelsLiveDashboardGetLiveDataResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置直播大屏基础数据 JSON 字符串。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("live_dashboard_data")]
        [System.Text.Json.Serialization.JsonPropertyName("live_dashboard_data")]
        public string LiveDashboardDataJson { get; set; } = default!;

        /// <summary>
        /// 获取或设置直播内容力数据 JSON 字符串。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("live_comparison_index")]
        [System.Text.Json.Serialization.JsonPropertyName("live_comparison_index")]
        public string LiveComparisonIndexJson { get; set; } = default!;

        /// <summary>
        /// 获取或设置电商数据概要数据 JSON 字符串。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("live_ec_data_summary")]
        [System.Text.Json.Serialization.JsonPropertyName("live_ec_data_summary")]
        public string LiveECDataSummaryJson { get; set; } = default!;

        /// <summary>
        /// 获取或设置电商转化力数据 JSON 字符串。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("live_ec_conversion_metric")]
        [System.Text.Json.Serialization.JsonPropertyName("live_ec_conversion_metric")]
        public string LiveECConversionMetricJson { get; set; } = default!;

        /// <summary>
        /// 获取或设置电商画像数据 JSON 字符串。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("live_ec_profile")]
        [System.Text.Json.Serialization.JsonPropertyName("live_ec_profile")]
        public string LiveECProfileJson { get; set; } = default!;

        /// <summary>
        /// 获取或设置电商渠道分布数据 JSON 字符串。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("live_distribution_channel")]
        [System.Text.Json.Serialization.JsonPropertyName("live_distribution_channel")]
        public string LiveDistributionChannelJson { get; set; } = default!;

        /// <summary>
        /// 获取或设置电商商品数据 JSON 字符串。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("single_live_ec_spu_data_page_v2")]
        [System.Text.Json.Serialization.JsonPropertyName("single_live_ec_spu_data_page_v2")]
        public string SingleLiveECSPUDataPageV2Json { get; set; } = default!;

        /// <summary>
        /// 获取或设置追踪 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trace_id")]
        [System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        public string TraceId { get; set; } = default!;
    }
}
