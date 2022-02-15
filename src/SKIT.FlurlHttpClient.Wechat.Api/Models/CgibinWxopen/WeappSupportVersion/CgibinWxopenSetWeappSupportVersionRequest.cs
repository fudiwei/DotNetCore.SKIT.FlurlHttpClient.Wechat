using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wxopen/setweappsupportversion 接口的请求。</para>
    /// </summary>
    public class CgibinWxopenSetWeappSupportVersionRequest : CgibinOpenCreateRequest, IMapResponse<CgibinWxopenSetWeappSupportVersionRequest, CgibinWxopenSetWeappSupportVersionResponse>
    {
        /// <summary>
        /// 获取或设置基础库版本。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("version")]
        [System.Text.Json.Serialization.JsonPropertyName("version")]
        public string SdkVersion { get; set; } = string.Empty;
    }
}
