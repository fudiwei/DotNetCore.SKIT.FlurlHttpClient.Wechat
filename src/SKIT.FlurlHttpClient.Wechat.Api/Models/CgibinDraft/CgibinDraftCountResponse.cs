using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/draft/count 接口的响应。</para>
    /// </summary>
    public class CgibinDraftCountResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置草稿总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; } 
    }
}
