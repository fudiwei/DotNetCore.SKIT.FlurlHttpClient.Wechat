using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wxopen/qrcodejumpdelete 接口的请求。</para>
    /// </summary>
    public class CgibinWxopenQrcodeJumpDeleteRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置匹配前缀。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prefix")]
        [System.Text.Json.Serialization.JsonPropertyName("prefix")]
        public string Prefix { get; set; } = string.Empty;
    }
}
