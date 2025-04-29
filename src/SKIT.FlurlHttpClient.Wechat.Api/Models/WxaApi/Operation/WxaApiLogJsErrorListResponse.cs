namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/log/jserr_list 接口的响应。</para>
    /// </summary>
    public class WxaApiLogJsErrorListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class JsError
            {
                /// <summary>
                /// 获取或设置错误信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errorMsg")]
                [System.Text.Json.Serialization.JsonPropertyName("errorMsg")]
                public string ErrorMessage { get; set; } = default!;

                /// <summary>
                /// 获取或设置错误信息 MD5 值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errorMsgMd5")]
                [System.Text.Json.Serialization.JsonPropertyName("errorMsgMd5")]
                public string ErrorMessageMd5 { get; set; } = default!;

                /// <summary>
                /// 获取或设置错误堆栈信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errorStack")]
                [System.Text.Json.Serialization.JsonPropertyName("errorStack")]
                public string ErrorStack { get; set; } = default!;

                /// <summary>
                /// 获取或设置错误堆栈信息 MD5 值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errorStackMd5")]
                [System.Text.Json.Serialization.JsonPropertyName("errorStackMd5")]
                public string ErrorStackMd5 { get; set; } = default!;

                /// <summary>
                /// 获取或设置发生错误用户数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("uv")]
                [System.Text.Json.Serialization.JsonPropertyName("uv")]
                public int UV { get; set; }

                /// <summary>
                /// 获取或设置发生错误用户百分比。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("uvPercent")]
                [System.Text.Json.Serialization.JsonPropertyName("uvPercent")]
                public string UVPercentageString { get; set; } = default!;

                /// <summary>
                /// 获取或设置发生错误次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pv")]
                [System.Text.Json.Serialization.JsonPropertyName("pv")]
                public int PV { get; set; }

                /// <summary>
                /// 获取或设置发生错误百分比。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pvPercent")]
                [System.Text.Json.Serialization.JsonPropertyName("pvPercent")]
                public string PVPercentageString { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置错误列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.JsError[] JsErrorList { get; set; } = default!;

        /// <summary>
        /// 获取或设置错误总条数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("totalCount")]
        [System.Text.Json.Serialization.JsonPropertyName("totalCount")]
        public int TotalCount { get; set; }
    }
}
