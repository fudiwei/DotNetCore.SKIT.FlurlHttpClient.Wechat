using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /union/promoter/open_account/get 接口的响应。</para>
    /// </summary>
    public class UnionPromoterOpenAccountGetResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置开放平台账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openAccount")]
        [System.Text.Json.Serialization.JsonPropertyName("openAccount")]
        public string OpenAccount { get; set; } = default!;
    }
}
