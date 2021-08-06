using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/staticuploadfile 接口的响应。</para>
    /// </summary>
    public class ComponentTcbStaticUploadFileResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置上传 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("signed_url")]
        [System.Text.Json.Serialization.JsonPropertyName("signed_url")]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 获取或设置上传凭证。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("token")]
        [System.Text.Json.Serialization.JsonPropertyName("token")]
        public string Token { get; set; } = default!;
    }
}
