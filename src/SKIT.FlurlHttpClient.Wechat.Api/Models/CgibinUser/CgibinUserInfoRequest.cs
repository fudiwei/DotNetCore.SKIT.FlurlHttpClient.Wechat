using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/user/info 接口的请求。</para>
    /// </summary>
    public class CgibinUserInfoRequest : WechatApiRequest, IMapResponse<CgibinUserInfoRequest, CgibinUserInfoResponse>
    {
        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置返回国家地区语言版本。
        /// <para>默认值：zh_CN</para>
        /// </summary>
        public string Language { get; set; } = "zh_CN";
    }
}
