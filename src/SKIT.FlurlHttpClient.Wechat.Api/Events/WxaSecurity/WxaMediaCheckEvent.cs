using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.wxa_media_check 事件的数据。</para>
    /// <para>https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/sec-check/security.mediaCheckAsync.html </para>
    /// <para>https://developers.weixin.qq.com/minigame/dev/api-backend/open-api/sec-check/security.mediaCheckAsync.html </para>
    /// </summary>
    public class WxaMediaCheckEvent : WechatApiEvent, WechatApiEvent.Types.IJsonSerializable
    {
        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("isrisky")]
        [System.Text.Json.Serialization.JsonPropertyName("isrisky")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumberTypedBooleanConverter))]
        public bool IsRisky { get; set; }

        /// <summary>
        /// 获取或设置 JSON 格式附加信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extra_info_json")]
        [System.Text.Json.Serialization.JsonPropertyName("extra_info_json")]
        public string? JsonExt { get; set; }

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
    }
}
