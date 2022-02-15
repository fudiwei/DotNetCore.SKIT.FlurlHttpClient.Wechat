using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /semantic/semproxy/search 接口的请求。</para>
    /// </summary>
    public class SemanticSemproxySearchRequest : WechatApiRequest, IMapResponse<SemanticSemproxySearchRequest, SemanticSemproxySearchResponse>
    {
        /// <summary>
        /// 获取或设置输入文本串。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("query")]
        [System.Text.Json.Serialization.JsonPropertyName("query")]
        public string Query { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置需要使用的服务类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Category { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置纬度坐标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("latitude")]
        [System.Text.Json.Serialization.JsonPropertyName("latitude")]
        public double? Latitude { get; set; }

        /// <summary>
        /// 获取或设置经度坐标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("longitude")]
        [System.Text.Json.Serialization.JsonPropertyName("longitude")]
        public double? Longitude { get; set; }

        /// <summary>
        /// 获取或设置城市名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city")]
        [System.Text.Json.Serialization.JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// 获取或设置区域名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("region")]
        [System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// 获取或设置公众号 AppId。如果不指定将使用构造 <see cref="WechatApiClient"/> 时的 <see cref="WechatApiClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置开发者侧用户标识，建议填入用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("uid")]
        [System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string? UserId { get; set; }
    }
}
