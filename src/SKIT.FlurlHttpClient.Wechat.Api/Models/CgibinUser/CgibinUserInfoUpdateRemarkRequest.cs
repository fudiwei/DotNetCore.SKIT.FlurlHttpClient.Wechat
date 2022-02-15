using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/user/info/updateremark 接口的请求。</para>
    /// </summary>
    public class CgibinUserInfoUpdateRemarkRequest : WechatApiRequest, IMapResponse<CgibinUserInfoUpdateRemarkRequest, CgibinUserInfoUpdateRemarkResponse>
    {
        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置新的备注名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        [System.Text.Json.Serialization.JsonPropertyName("remark")]
        public string Remark { get; set; } = string.Empty;
    }
}
