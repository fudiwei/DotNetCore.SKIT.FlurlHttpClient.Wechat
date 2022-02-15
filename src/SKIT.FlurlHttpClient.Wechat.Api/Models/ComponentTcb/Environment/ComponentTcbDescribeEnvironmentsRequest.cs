using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/describeenvs 接口的请求。</para>
    /// </summary>
    public class ComponentTcbDescribeEnvironmentsRequest : WechatApiRequest, IMapResponse<ComponentTcbDescribeEnvironmentsRequest, ComponentTcbDescribeEnvironmentsResponse>
    {
        /// <summary>
        /// 获取或设置第三方平台 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ComponentAccessToken { get; set; } = string.Empty;
    }
}
