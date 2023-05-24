using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    /// <summary>
    /// 表示企业微信 API 响应的基类。
    /// </summary>
    public abstract class WechatWorkResponse : ICommonResponse
    {
        /// <summary>
        ///
        /// </summary>
        int ICommonResponse.RawStatus { get; set; }

        /// <summary>
        ///
        /// </summary>
        IDictionary<string, string> ICommonResponse.RawHeaders { get; set; } = default!;

        /// <summary>
        ///
        /// </summary>
        byte[] ICommonResponse.RawBytes { get; set; } = default!;

        /// <summary>
        /// 获取原始的 HTTP 响应状态码。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int RawStatus
        {
            get { return ((ICommonResponse)this).RawStatus; }
            internal set { ((ICommonResponse)this).RawStatus = value; }
        }

        /// <summary>
        /// 获取原始的 HTTP 响应表头集合。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IDictionary<string, string> RawHeaders
        {
            get { return ((ICommonResponse)this).RawHeaders; }
            internal set { ((ICommonResponse)this).RawHeaders = value; }
        }

        /// <summary>
        /// 获取原始的 HTTP 响应正文。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[] RawBytes
        {
            get { return ((ICommonResponse)this).RawBytes; }
            internal set { ((ICommonResponse)this).RawBytes = value; }
        }

        /// <summary>
        /// 获取企业微信 API 返回的错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("errcode")]
        [System.Text.Json.Serialization.JsonPropertyName("errcode")]
        public virtual int ErrorCode { get; set; }

        /// <summary>
        /// 获取企业微信 API 返回的错误描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("errmsg")]
        [System.Text.Json.Serialization.JsonPropertyName("errmsg")]
        public virtual string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取一个值，该值指示调用企业微信 API 是否成功（即 HTTP 状态码为 200、且 errcode 值为 0）。
        /// </summary>
        /// <returns></returns>
        public virtual bool IsSuccessful()
        {
            return RawStatus == 200 && ErrorCode == 0;
        }
    }
}
