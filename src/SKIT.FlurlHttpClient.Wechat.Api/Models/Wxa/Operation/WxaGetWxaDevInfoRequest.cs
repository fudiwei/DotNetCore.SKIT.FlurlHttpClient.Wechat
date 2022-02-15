using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/getwxadevinfo 接口的请求。</para>
    /// </summary>
    public class WxaGetWxaDevInfoRequest : WechatApiRequest, IMapResponse<WxaGetWxaDevInfoRequest, WxaGetWxaDevInfoResponse>
    {
        /// <summary>
        /// 获取或设置查询配置域名的类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? Action { get; set; }
    }
}
