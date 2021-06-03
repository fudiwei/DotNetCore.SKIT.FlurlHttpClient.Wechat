using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedrive/file_download 接口的响应。</para>
    /// </summary>
    public class CgibinWebDriveFileDownloadResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置文件下载 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("download_url")]
        [System.Text.Json.Serialization.JsonPropertyName("download_url")]
        public string DownloadUrl { get; set; } = default!;

        /// <summary>
        /// 获取或设置下载请求时携带的 Cookie 的 Key。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cookie_name")]
        [System.Text.Json.Serialization.JsonPropertyName("cookie_name")]
        public string? CookieKey { get; set; }

        /// <summary>
        /// 获取或设置下载请求时携带的 Cookie 的值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cookie_value")]
        [System.Text.Json.Serialization.JsonPropertyName("cookie_value")]
        public string? CookieValue { get; set; } = default!;
    }
}
