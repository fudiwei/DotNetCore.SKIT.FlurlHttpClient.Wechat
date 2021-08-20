using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.wxa_media_check 事件的数据。</para>
    /// <para>https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/sec-check/security.mediaCheckAsync.html </para>
    /// <para>https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/sec-check/security.mediaCheckAsync-v1.html </para>
    /// <para>https://developers.weixin.qq.com/minigame/dev/api-backend/open-api/sec-check/security.mediaCheckAsync.html </para>
    /// <para>https://developers.weixin.qq.com/minigame/dev/api-backend/open-api/sec-check/security.mediaCheckAsync-v1.html </para>
    /// </summary>
    public class WxaMediaCheckEvent : WechatApiEvent, WechatApiEvent.Types.IJsonSerializable
    {
        public new static class Types
        {
            public class Result
            {
                /// <summary>
                /// 获取或设置建议类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("suggest")]
                [System.Text.Json.Serialization.JsonPropertyName("suggest")]
                public string SuggestType { get; set; } = default!;

                /// <summary>
                /// 获取或设置命中标签枚举值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("label")]
                [System.Text.Json.Serialization.JsonPropertyName("label")]
                public int Label { get; set; }
            }

            public class Detail
            {
                /// <summary>
                /// 获取或设置错误码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errcode")]
                [System.Text.Json.Serialization.JsonPropertyName("errcode")]
                public int ErrorCode { get; set; }

                /// <summary>
                /// 获取或设置策略类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("strategy")]
                [System.Text.Json.Serialization.JsonPropertyName("strategy")]
                public string Strategy { get; set; } = default!;

                /// <summary>
                /// 获取或设置建议类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("suggest")]
                [System.Text.Json.Serialization.JsonPropertyName("suggest")]
                public string? SuggestType { get; set; }

                /// <summary>
                /// 获取或设置命中标签枚举值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("label")]
                [System.Text.Json.Serialization.JsonPropertyName("label")]
                public int? Label { get; set; }

                /// <summary>
                /// 获取或设置置信度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("prob")]
                [System.Text.Json.Serialization.JsonPropertyName("prob")]
                public int? Probability { get; set; }
            }
        }


        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("isrisky")]
        [System.Text.Json.Serialization.JsonPropertyName("isrisky")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
        public bool IsRisky { get; set; }

        /// <summary>
        /// 获取或设置 JSON 格式附加信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extra_info_json")]
        [System.Text.Json.Serialization.JsonPropertyName("extra_info_json")]
        public string? JsonExtra { get; set; }

        /// <summary>
        /// 获取或设置小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trace_id")]
        [System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        public string TraceId { get; set; } = default!;

        /// <summary>
        /// 获取或设置任务状态码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status_code")]
        [System.Text.Json.Serialization.JsonPropertyName("status_code")]
        public int StatusCode { get; set; }

        /// <summary>
        /// 获取或设置版本号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("version")]
        [System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// 获取或设置综合结果信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        public Types.Result? Result { get; set; }

        /// <summary>
        /// 获取或设置详细结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detail")]
        [System.Text.Json.Serialization.JsonPropertyName("detail")]
        public Types.Detail[]? DetailList { get; set; }
    }
}
