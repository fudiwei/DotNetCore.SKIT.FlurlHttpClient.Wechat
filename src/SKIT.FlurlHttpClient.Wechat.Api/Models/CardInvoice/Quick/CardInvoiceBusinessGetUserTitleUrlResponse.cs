using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/invoice/biz/getusertitleurl 接口的响应。</para>
    /// </summary>
    public class CardInvoiceBusinessGetUserTitleUrlResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置授权 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        [System.Text.Json.Serialization.JsonPropertyName("url")]
        public string Url { get; set; } = default!;
    }
}
