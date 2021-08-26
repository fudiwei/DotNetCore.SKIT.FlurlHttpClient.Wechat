using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wxverify/checkwxverifynickname 接口的响应。</para>
    /// </summary>
    public class CgibinWxverifyCheckWxverifyNicknameResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置是否命中关键字策略。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hit_condition")]
        [System.Text.Json.Serialization.JsonPropertyName("hit_condition")]
        public bool IsHit { get; set; }

        /// <summary>
        /// 获取或设置命中关键字的说明描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wording")]
        [System.Text.Json.Serialization.JsonPropertyName("wording")]
        public string? Wording { get; set; }
    }
}
