using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /customservice/kfsession/getsession 接口的请求。</para>
    /// </summary>
    public class CustomServiceKfSessionGetSessionRequest : WechatApiRequest, IMapResponse<CustomServiceKfSessionGetSessionRequest, CustomServiceKfSessionGetSessionResponse>
    {
        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OpenId { get; set; } = string.Empty;
    }
}
