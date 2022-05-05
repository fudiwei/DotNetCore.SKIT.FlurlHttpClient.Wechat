﻿namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/open/get 接口的响应。</para>
    /// </summary>
    public class CgibinOpenGetResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置开放平台的 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("open_appid")]
        public string OpenAppId { get; set; } = default!;
    }
}
