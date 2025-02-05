using System;

namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.SpecialApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /spec/gettoken 接口的响应。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2024-06-06 下线。")]
    public class SpecialGetTokenResponse : WechatWorkSpecialApiResponse
    {
        /// <summary>
        /// 获取或设置数据分析专区接口凭证。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        [System.Text.Json.Serialization.JsonPropertyName("access_token")]
        public string AccessToken { get; set; } = default!;

        /// <summary>
        /// 获取或设置接口凭证有效期（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expires_in")]
        [System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; }
    }
}
