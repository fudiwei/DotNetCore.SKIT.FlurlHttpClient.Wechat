using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/openapi/rid/get 接口的请求。</para>
    /// </summary>
    public class CgibinOpenApiRequestIdGetRequest : WechatApiRequest, IMapResponse<CgibinOpenApiRequestIdGetRequest, CgibinOpenApiRequestIdGetResponse>
    {
        /// <summary>
        /// 获取或设置调用接口报错返回的 rid。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rid")]
        [System.Text.Json.Serialization.JsonPropertyName("rid")]
        public string RequestId { get; set; } = string.Empty;
    }
}
