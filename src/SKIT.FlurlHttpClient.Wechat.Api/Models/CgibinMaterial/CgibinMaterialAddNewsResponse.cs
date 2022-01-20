﻿namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/material/add_news 接口的响应。</para>
    /// </summary>
    public class CgibinMaterialAddNewsResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置媒体文件标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_id")]
        [System.Text.Json.Serialization.JsonPropertyName("media_id")]
        public string MediaId { get; set; } = default!;
    }
}
