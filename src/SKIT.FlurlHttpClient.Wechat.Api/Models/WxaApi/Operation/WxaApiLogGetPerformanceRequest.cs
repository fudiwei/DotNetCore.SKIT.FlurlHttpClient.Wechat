namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/log/get_performance 接口的请求。</para>
    /// </summary>
    public class WxaApiLogGetPerformanceRequest : WechatApiRequest, IInferable<WxaApiLogGetPerformanceRequest, WxaApiLogGetPerformanceResponse>
    {
        /// <summary>
        /// 获取或设置查询耗时类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cost_time_type")]
        [System.Text.Json.Serialization.JsonPropertyName("cost_time_type")]
        public int CostTimeType { get; set; }

        /// <summary>
        /// 获取或设置开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("default_start_time")]
        [System.Text.Json.Serialization.JsonPropertyName("default_start_time")]
        public long StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("default_end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("default_end_time")]
        public long EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置设备类型。
        /// <para>默认值："@_all"</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device")]
        [System.Text.Json.Serialization.JsonPropertyName("device")]
        public string DeviceType { get; set; } = "@_all";

        /// <summary>
        /// 获取或设置下载代码包类型。
        /// <para>默认值："@_all"</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_download_code")]
        [System.Text.Json.Serialization.JsonPropertyName("is_download_code")]
        public string DownloadCodeType { get; set; } = "@_all";

        /// <summary>
        /// 获取或设置网络环境类型。
        /// <para>默认值："@_all"</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("networktype")]
        [System.Text.Json.Serialization.JsonPropertyName("networktype")]
        public string NetworkType { get; set; } = "@_all";

        /// <summary>
        /// 获取或设置访问来源。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene")]
        [System.Text.Json.Serialization.JsonPropertyName("scene")]
        public string Scene { get; set; } = string.Empty;
    }
}
