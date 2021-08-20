using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat
{
    /// <summary>
    /// SKIT.FlurlHttpClient.Wechat 响应接口。
    /// </summary>
    public interface IWechatResponse : ICommonResponse
    {
        /// <summary>
        /// 获取微信 API 返回的错误描述。
        /// </summary>
        string? ErrorMessage { get; set; }
    }
}
