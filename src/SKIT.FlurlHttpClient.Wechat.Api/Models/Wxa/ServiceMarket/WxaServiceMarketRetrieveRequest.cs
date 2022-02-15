using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/servicemarketretrieve 接口的请求。</para>
    /// </summary>
    public class WxaServiceMarketRetrieveRequest : WechatApiRequest, IMapResponse<WxaServiceMarketRetrieveRequest, WxaServiceMarketRetrieveResponse>
    {
        /// <summary>
        /// 获取或设置异步调用 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("request_id")]
        [System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string RequestId { get; set; } = string.Empty;
    }
}
