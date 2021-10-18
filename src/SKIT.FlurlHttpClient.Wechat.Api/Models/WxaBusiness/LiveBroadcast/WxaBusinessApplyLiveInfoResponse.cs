using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/applyliveinfo 接口的响应。</para>
    /// </summary>
    public class WxaBusinessApplyLiveInfoResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置执行动作。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action")]
        [System.Text.Json.Serialization.JsonPropertyName("action")]
        public string Action { get; set; } = default!;
    }
}
