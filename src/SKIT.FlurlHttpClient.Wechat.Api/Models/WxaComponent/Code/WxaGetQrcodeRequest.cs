using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/get_qrcode 接口的请求。</para>
    /// </summary>
    public class WxaGetQrcodeRequest : WechatApiRequest, IMapResponse<WxaGetQrcodeRequest, WxaGetQrcodeResponse>
    {
        /// <summary>
        /// 获取或设置页面路径。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? PagePath { get; set; }
    }
}
