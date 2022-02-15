using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/clear_quota 接口的请求。</para>
    /// </summary>
    public class CgibinClearQuotaRequest : WechatApiRequest, IMapResponse<CgibinClearQuotaRequest, CgibinClearQuotaResponse>
    {
        /// <summary>
        /// 获取或设置微信 AppId。如果不指定将使用构造 <see cref="WechatApiClient"/> 时的 <see cref="WechatApiClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }
    }
}
