using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.SDK.Finance
{
    /// <summary>
    /// 表示企业微信会话内容存档 API 响应的基类。
    /// </summary>
    public abstract class WechatWorkFinanceResponse : ICommonResponse
    {
        /// <summary>
        ///
        /// </summary>
        int ICommonResponse.RawStatus
        {
            get { throw new NotSupportedException(); }
            set { throw new NotSupportedException(); }
        }

        /// <summary>
        ///
        /// </summary>
        IDictionary<string, string> ICommonResponse.RawHeaders
        {
            get { throw new NotSupportedException(); }
            set { throw new NotSupportedException(); }
        }

        /// <summary>
        ///
        /// </summary>
        byte[] ICommonResponse.RawBytes { get; set; } = Array.Empty<byte>();

        /// <summary>
        /// 获取原始的响应数据。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[] RawBytes
        {
            get { return ((ICommonResponse)this).RawBytes; }
            internal set { ((ICommonResponse)this).RawBytes = value; }
        }

        /// <summary>
        /// 获取企业微信会话内容存档 API 返回的返回值。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int ReturnCode { get; internal set; }

        /// <summary>
        /// 获取一个值，该值指示调用企业微信会话内容存档 API 是否成功（即 "ret" 值为 0）。
        /// </summary>
        /// <returns></returns>
        public virtual bool IsSuccessful()
        {
            return ReturnCode == 0;
        }
    }
}
