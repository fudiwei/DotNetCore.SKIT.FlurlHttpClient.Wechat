using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /intp/marketcode/applycodedownload 接口的响应。</para>
    /// </summary>
    public class IntpMarketCodeApplyCodeDownloadResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置文件 Buffer（已经 Base64 编码）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("buffer")]
        [System.Text.Json.Serialization.JsonPropertyName("buffer")]
        public string FileBuffer { get; set; } = default!;
    }
}
