using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.SDK.Finance
{
    /// <summary>
    /// 表示企业微信会话内容存档 API 响应的基类。
    /// </summary>
    public abstract class WechatWorkFinanceResponse : ICommonResponse
    {
        internal protected WechatWorkFinanceResponse()
        {
            _InternalRawBytes = Array.Empty<byte>();
        }

        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        internal byte[] _InternalRawBytes;

        /// <inheritdoc/>
        int ICommonResponse.GetRawStatus()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        HttpHeaderCollection ICommonResponse.GetRawHeaders()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public byte[] GetRawBytes()
        {
            return _InternalRawBytes;
        }

        /// <summary>
        /// 获取企业微信会话内容存档 API 返回的返回值。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int ReturnCode { get; internal set; }

        /// <summary>
        /// 获取一个值，该值指示调用企业微信会话内容存档 API 是否成功。
        /// <para>
        ///（即 <see cref="ReturnCode"/> 值为 0）
        /// </para>
        /// </summary>
        /// <returns></returns>
        public virtual bool IsSuccessful()
        {
            return ReturnCode == 0;
        }
    }
}
