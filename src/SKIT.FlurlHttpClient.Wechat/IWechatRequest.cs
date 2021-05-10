using System;

namespace SKIT.FlurlHttpClient.Wechat
{
    /// <summary>
    /// SKIT.FlurlHttpClient.Wechat 请求接口。
    /// </summary>
    public interface IWechatRequest
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? Timeout { get; set; }
    }
}
