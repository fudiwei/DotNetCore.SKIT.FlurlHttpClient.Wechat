using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cityservice/sendmsgdata 接口的响应。</para>
    /// </summary>
    public class CityServiceSendMessageDataResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置结果页 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result_page_url")]
        [System.Text.Json.Serialization.JsonPropertyName("result_page_url")]
        public string? ResultPageUrl { get; set; }
    }
}
