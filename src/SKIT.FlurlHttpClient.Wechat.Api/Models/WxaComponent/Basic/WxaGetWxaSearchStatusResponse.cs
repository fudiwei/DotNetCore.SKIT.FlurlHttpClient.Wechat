using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/getwxasearchstatus 接口的响应。</para>
    /// </summary>
    public class WxaGetWxaSearchStatusResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置搜索状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int SearchStatus { get; set; }
    }
}
