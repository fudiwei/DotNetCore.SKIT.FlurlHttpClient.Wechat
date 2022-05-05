﻿namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/open/get 接口的请求。</para>
    /// </summary>
    public class CgibinOpenGetRequest : WechatApiRequest, IInferable<CgibinOpenGetRequest, CgibinOpenGetResponse>
    {
        /// <summary>
        /// 获取或设置授权方的 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AuthorizerAppId { get; set; } = string.Empty;
    }
}
