using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/account/modifysignature 接口的请求。</para>
    /// </summary>
    public class CgibinAccountModifySignatureRequest : WechatApiRequest, IMapResponse<CgibinAccountModifySignatureRequest, CgibinAccountModifySignatureResponse>
    {
        /// <summary>
        /// 获取或设置小程序简介。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("signature")]
        [System.Text.Json.Serialization.JsonPropertyName("signature")]
        public string Signature { get; set; } = string.Empty;
    }
}
