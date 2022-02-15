using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/getmpadminauth 接口的请求。</para>
    /// </summary>
    public class WxaGetMpAdminAuthRequest : WechatApiRequest, IMapResponse<WxaGetMpAdminAuthRequest, WxaGetMpAdminAuthResponse>
    {
        /// <summary>
        /// 获取或设置公众号的 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mp_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("mp_appid")]
        public string MediaPlatformAppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置公众号的 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("same_admin")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("same_admin")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
        public bool IsSameAdmin { get; set; }
    }
}
