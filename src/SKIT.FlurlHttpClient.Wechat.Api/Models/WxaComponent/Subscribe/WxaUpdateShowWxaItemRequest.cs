using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/updateshowwxaitem 接口的请求。</para>
    /// </summary>
    public class WxaUpdateShowWxaItemRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置是否打开扫码关注组件。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wxa_subscribe_biz_flag")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("wxa_subscribe_biz_flag")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
        public bool IsOpen { get; set; }

        /// <summary>
        /// 获取或设置展示的公众号 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? MediaPlatformAppId { get; set; }
    }
}
