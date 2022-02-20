using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/draft/switch 接口的响应。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2022-02-25 下线。")]
    public class CgibinDraftSwitchResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置是否开启草稿箱功能。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_open")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("is_open")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
        public bool IsOpen { get; set; }
    }
}
