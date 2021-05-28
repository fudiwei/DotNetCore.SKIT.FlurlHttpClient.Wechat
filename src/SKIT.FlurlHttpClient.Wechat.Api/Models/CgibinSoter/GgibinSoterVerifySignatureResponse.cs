using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/soter/verify_signature 接口的响应。</para>
    /// </summary>
    public class GgibinSoterVerifySignatureResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置验证结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_ok")]
        [System.Text.Json.Serialization.JsonPropertyName("is_ok")]
        public bool IsOk { get; set; }
    }
}
