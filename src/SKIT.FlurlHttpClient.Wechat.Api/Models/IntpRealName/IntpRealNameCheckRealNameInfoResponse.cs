using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /intp/realname/checkrealnameinfo 接口的响应。</para>
    /// </summary>
    public class IntpRealNameCheckRealNameInfoResponse : IntpMarketCodeActiveCodeQueryResponse
    {
        /// <summary>
        /// 获取或设置 OpenId 验证结果，使用分号分隔。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("verify_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("verify_openid")]
        public string VerifyOpenIdResults { get; set; } = default!;

        /// <summary>
        /// 获取或设置实名验证结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("verify_real_name")]
        [System.Text.Json.Serialization.JsonPropertyName("verify_real_name")]
        public string? VerifyRealNameResult { get; set; }
    }
}
