using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/log/jserr_detail 接口的响应。</para>
    /// </summary>
    public class WxaApiLogJsErrorDetailResponse : WechatApiResponse
    {
        public static class Types
        {
            public class JsError
            {
                /// <summary>
                /// 获取或设置微信 UIN。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Uin")]
                [System.Text.Json.Serialization.JsonPropertyName("Uin")]
                public string UIN { get; set; } = default!;

                /// <summary>
                /// 获取或设置微信 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appId")]
                [System.Text.Json.Serialization.JsonPropertyName("appId")]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户唯一标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openId")]
                [System.Text.Json.Serialization.JsonPropertyName("openId")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nickname")]
                [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                public string Nickname { get; set; } = default!;

                /// <summary>
                /// 获取或设置错误来源。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("source")]
                [System.Text.Json.Serialization.JsonPropertyName("source")]
                public string Source { get; set; } = default!;

                /// <summary>
                /// 获取或设置错误页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("route")]
                [System.Text.Json.Serialization.JsonPropertyName("route")]
                public string Route { get; set; } = default!;

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
                /// 获取或设置小程序版本。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appVersion")]
                [System.Text.Json.Serialization.JsonPropertyName("appVersion")]
                public string AppVersion { get; set; } = default!;

                /// <summary>
                /// 获取或设置基础库版本。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sdkVersion")]
                [System.Text.Json.Serialization.JsonPropertyName("sdkVersion")]
                public string SdkVersion { get; set; } = default!;

                /// <summary>
                /// 获取或设置系统类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("osName")]
                [System.Text.Json.Serialization.JsonPropertyName("osName")]
                public string OSName { get; set; } = default!;

                /// <summary>
                /// 获取或设置客户端版本。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("clientVersion")]
                [System.Text.Json.Serialization.JsonPropertyName("clientVersion")]
                public string ClientVersion { get; set; } = default!;

                /// <summary>
                /// 获取或设置插件版本。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pluginversion")]
                [System.Text.Json.Serialization.JsonPropertyName("pluginversion")]
                public string? PluginVersion { get; set; }

                /// <summary>
                /// 获取或设置设备型号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("DeviceModel")]
                [System.Text.Json.Serialization.JsonPropertyName("DeviceModel")]
                public string DeviceModel { get; set; } = default!;

                /// <summary>
                /// 获取或设置错误次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Count")]
                [System.Text.Json.Serialization.JsonPropertyName("Count")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int Count { get; set; }

                /// <summary>
                /// 获取或设置错误发生日期（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Ds")]
                [System.Text.Json.Serialization.JsonPropertyName("Ds")]
                public string DateString { get; set; } = default!;

                /// <summary>
                /// 获取或设置错误发生时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("TimeStamp")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("TimeStamp")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                public DateTimeOffset Time { get; set; }
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
        public int Total { get; set; }
    }
}
