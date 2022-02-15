using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/account/fastregister 接口的请求。</para>
    /// </summary>
    public class CgibinAccountFastRegisterRequest : WechatApiRequest, IMapResponse<CgibinAccountFastRegisterRequest, CgibinAccountFastRegisterResponse>
    {
        /// <summary>
        /// 获取或设置公众号扫码授权的凭证。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ticket")]
        [System.Text.Json.Serialization.JsonPropertyName("ticket")]
        public string Ticket { get; set; } = string.Empty;
    }
}
