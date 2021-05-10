using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat
{
    /// <summary>
    /// SKIT.FlurlHttpClient.Wechat 响应接口。
    /// </summary>
    public interface IWechatResponse
    {
        /// <summary>
        /// 获取原始的 HTTP 响应状态码。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int RawStatus { get; }

        /// <summary>
        /// 获取原始的 HTTP 响应表头集合。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IDictionary<string, string> RawHeaders { get; }

        /// <summary>
        /// 获取原始的 HTTP 响应正文。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[] RawBytes { get; }

        /// <summary>
        /// 获取一个值，该值指示调用 API 是否成功。
        /// </summary>
        /// <returns></returns>
        bool IsSuccessful();
    }
}
