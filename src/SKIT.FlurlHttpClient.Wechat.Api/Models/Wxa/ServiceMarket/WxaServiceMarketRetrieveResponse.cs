using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/servicemarketretrieve 接口的响应。</para>
    /// </summary>
    public class WxaServiceMarketRetrieveResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置回包 JSON 格式信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public string JsonData { get; set; } = default!;
    }
}
