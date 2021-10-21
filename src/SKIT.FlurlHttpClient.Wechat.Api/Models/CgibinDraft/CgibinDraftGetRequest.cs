using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/draft/get 接口的请求。</para>
    /// </summary>
    public class CgibinDraftGetRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置图文消息的 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_id")]
        [System.Text.Json.Serialization.JsonPropertyName("media_id")]
        public string Media { get; set; } = string.Empty;
    }
}
