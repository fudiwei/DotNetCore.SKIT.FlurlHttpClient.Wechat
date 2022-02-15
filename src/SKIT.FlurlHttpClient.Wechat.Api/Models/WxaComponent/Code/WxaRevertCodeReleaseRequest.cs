using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/revertcoderelease 接口的请求。</para>
    /// </summary>
    public class WxaRevertCodeReleaseRequest : WechatApiRequest, IMapResponse<WxaRevertCodeReleaseRequest, WxaRevertCodeReleaseResponse>
    {
        /// <summary>
        /// 获取或设置操作类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? Action { get; set; }

        /// <summary>
        /// 获取或设置指定回退到的小程序版本。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? AppVersion { get; set; }
    }
}
