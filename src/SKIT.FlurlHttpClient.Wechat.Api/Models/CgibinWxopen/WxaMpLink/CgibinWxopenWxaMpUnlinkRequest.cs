using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wxopen/wxampunlink 接口的请求。</para>
    /// </summary>
    public class CgibinWxopenWxaMpUnlinkRequest : WechatApiRequest, IMapResponse<CgibinWxopenWxaMpUnlinkRequest, CgibinWxopenWxaMpUnlinkResponse>
    {
        /// <summary>
        /// 获取或设置小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string MiniProgramAppId { get; set; } = string.Empty;
    }
}
