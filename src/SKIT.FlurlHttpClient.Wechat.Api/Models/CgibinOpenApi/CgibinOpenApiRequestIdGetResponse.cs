using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/openapi/rid/get 接口的响应。</para>
    /// </summary>
    public class CgibinOpenApiRequestIdGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Request
            {
                /// <summary>
                /// 获取或设置请求 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("request_url")]
                [System.Text.Json.Serialization.JsonPropertyName("request_url")]
                public string RequestUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置请求参数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("request_body")]
                [System.Text.Json.Serialization.JsonPropertyName("request_body")]
                public string RequestBody { get; set; } = default!;

                /// <summary>
                /// 获取或设置返回参数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("response_body")]
                [System.Text.Json.Serialization.JsonPropertyName("response_body")]
                public string ResponseBody { get; set; } = default!;

                /// <summary>
                /// 获取或设置发起请求的时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("invoke_time")]
                [System.Text.Json.Serialization.JsonPropertyName("invoke_time")]
                public long InvokeTimestamp { get; set; }

                /// <summary>
                /// 获取或设置请求耗时（单位：毫秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cost_in_ms")]
                [System.Text.Json.Serialization.JsonPropertyName("cost_in_ms")]
                public int CostTime { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置请求信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("request")]
        [System.Text.Json.Serialization.JsonPropertyName("request")]
        public Types.Request Request { get; set; } = default!;
    }
}
