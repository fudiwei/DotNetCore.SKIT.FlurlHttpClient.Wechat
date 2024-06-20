namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/fetchdatasetting 接口的请求。</para>
    /// </summary>
    public class WxaFetchDataSettingRequest : WechatApiRequest, IInferable<WxaFetchDataSettingRequest, WxaFetchDataSettingResponse>
    {
        /// <summary>
        /// 获取或设置操作类型。
        /// <para>默认值："get"</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action")]
        [System.Text.Json.Serialization.JsonPropertyName("action")]
        public string Action { get; set; } = "get";

        /// <summary>
        /// 获取或设置是否开启数据预拉取。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_pre_fetch_open")]
        [System.Text.Json.Serialization.JsonPropertyName("is_pre_fetch_open")]
        public bool? IsPreFetchOpen { get; set; }

        /// <summary>
        /// 获取或设置数据预拉取数据来源。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pre_fetch_type")]
        [System.Text.Json.Serialization.JsonPropertyName("pre_fetch_type")]
        public int? PreFetchType { get; set; }

        /// <summary>
        /// 获取或设置数据预拉取数据来源 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pre_fetch_url")]
        [System.Text.Json.Serialization.JsonPropertyName("pre_fetch_url")]
        public string? PreFetchUrl { get; set; }

        /// <summary>
        /// 获取或设置数据预拉取云环境 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pre_env")]
        [System.Text.Json.Serialization.JsonPropertyName("pre_env")]
        public string? PreFetchEnvironmentId { get; set; }

        /// <summary>
        /// 获取或设置数据预拉取云函数名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pre_function_name")]
        [System.Text.Json.Serialization.JsonPropertyName("pre_function_name")]
        public string? PreFetchFunctionName { get; set; }

        /// <summary>
        /// 获取或设置是否开启数据周期性拉取。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_period_fetch_open")]
        [System.Text.Json.Serialization.JsonPropertyName("is_period_fetch_open")]
        public bool? IsPeriodFetchOpen { get; set; }

        /// <summary>
        /// 获取或设置数据周期性拉取数据来源。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("period_fetch_type")]
        [System.Text.Json.Serialization.JsonPropertyName("period_fetch_type")]
        public int? PeriodFetchType { get; set; }

        /// <summary>
        /// 获取或设置数据周期性拉取数据来源 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("period_fetch_url")]
        [System.Text.Json.Serialization.JsonPropertyName("period_fetch_url")]
        public string? PeriodFetchUrl { get; set; }

        /// <summary>
        /// 获取或设置数据周期性拉取云环境 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("period_env")]
        [System.Text.Json.Serialization.JsonPropertyName("period_env")]
        public string? PeriodFetchEnvironmentId { get; set; }

        /// <summary>
        /// 获取或设置数据周期性拉取云函数名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("period_function_name")]
        [System.Text.Json.Serialization.JsonPropertyName("period_function_name")]
        public string? PeriodFetchFunctionName { get; set; }
    }
}
