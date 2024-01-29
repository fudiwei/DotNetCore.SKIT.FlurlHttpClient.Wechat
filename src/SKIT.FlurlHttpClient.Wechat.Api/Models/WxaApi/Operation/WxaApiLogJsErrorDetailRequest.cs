namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/log/jserr_detail 接口的请求。</para>
    /// </summary>
    public class WxaApiLogJsErrorDetailRequest : WechatApiRequest, IInferable<WxaApiLogJsErrorDetailRequest, WxaApiLogJsErrorDetailResponse>
    {
        /// <summary>
        /// 获取或设置开始日期（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("startTime")]
        [System.Text.Json.Serialization.JsonPropertyName("startTime")]
        public string StartDateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置结束日期（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endTime")]
        [System.Text.Json.Serialization.JsonPropertyName("endTime")]
        public string EndDateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置错误信息 MD5 值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("errorMsgMd5")]
        [System.Text.Json.Serialization.JsonPropertyName("errorMsgMd5")]
        public string ErrorMessageMd5 { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置错误堆栈信息 MD5 值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("errorStackMd5")]
        [System.Text.Json.Serialization.JsonPropertyName("errorStackMd5")]
        public string ErrorStackMd5 { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置小程序版本。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appVersion")]
        [System.Text.Json.Serialization.JsonPropertyName("appVersion")]
        public string AppVersion { get; set; } = "0";

        /// <summary>
        /// 获取或设置基础库版本。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sdkVersion")]
        [System.Text.Json.Serialization.JsonPropertyName("sdkVersion")]
        public string SdkVersion { get; set; } = "0";

        /// <summary>
        /// 获取或设置系统类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("osName")]
        [System.Text.Json.Serialization.JsonPropertyName("osName")]
        public string OSName { get; set; } = "0";

        /// <summary>
        /// 获取或设置客户端版本。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("clientVersion")]
        [System.Text.Json.Serialization.JsonPropertyName("clientVersion")]
        public string ClientVersion { get; set; } = "0";

        /// <summary>
        /// 获取或设置发生错误的用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否降序排序。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("desc")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool IsDescending { get; set; }

        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int Limit { get; set; } = 10;
    }
}
