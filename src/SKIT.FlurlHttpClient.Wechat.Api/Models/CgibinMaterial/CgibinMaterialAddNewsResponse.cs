using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/material/add_news 接口的响应。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2022-02-25 下线。")]
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
