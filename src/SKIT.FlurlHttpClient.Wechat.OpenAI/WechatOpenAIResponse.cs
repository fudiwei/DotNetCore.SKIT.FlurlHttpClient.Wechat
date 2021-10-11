using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    /// <summary>
    /// 表示微信智能对话 API 响应的基类。
    /// </summary>
    public abstract class WechatOpenAIResponse : IWechatResponse
    {
        /// <summary>
        /// 获取原始的 HTTP 响应状态码。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int RawStatus { get; internal set; }

        /// <summary>
        /// 获取原始的 HTTP 响应表头集合。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IDictionary<string, string> RawHeaders { get; internal set; } = default!;

        /// <summary>
        /// 获取原始的 HTTP 响应正文。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[] RawBytes { get; internal set; } = default!;

        /// <summary>
        /// 获取微信智能对话 API 返回的请求唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("request_id")]
        [System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public virtual string? RequestId { get; set; }

        /// <summary>
        /// 获取微信智能对话 API 返回的状态码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public virtual int? Code { get; set; }

        /// <summary>
        /// 获取微信智能对话 API 返回的调用信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg")]
        [System.Text.Json.Serialization.JsonPropertyName("msg")]
        public virtual string? Message { get; set; }

        /// <summary>
        /// 获取微信智能对话 API 返回的错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("errcode")]
        [System.Text.Json.Serialization.JsonPropertyName("errcode")]
        public virtual int? ErrorCode { get; set; }

        /// <summary>
        /// 获取微信智能对话 API 返回的错误信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("errmsg")]
        [System.Text.Json.Serialization.JsonPropertyName("errmsg")]
        public virtual string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取微信智能对话 API 返回的错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ret")]
        [System.Text.Json.Serialization.JsonPropertyName("ret")]
        public virtual int? ReturnCode { get; set; }

        /// <summary>
        /// 获取微信智能对话 API 返回的错误信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("error")]
        [System.Text.Json.Serialization.JsonPropertyName("error")]
        public virtual string? ReturnError { get; set; }

        /// <summary>
        /// 获取一个值，该值指示调用微信 API 是否成功（即 HTTP 状态码为 200、且 code/errcode/ret 值都为 0）。
        /// </summary>
        /// <returns></returns>
        public virtual bool IsSuccessful()
        {
            return RawStatus == 200 &&
                Code.GetValueOrDefault() == 0 &&
                ErrorCode.GetValueOrDefault() == 0 &&
                ReturnCode.GetValueOrDefault() == 0 &&
                string.IsNullOrEmpty(ReturnError);
        }
    }

    /// <summary>
    /// 表示微信智能对话 API 响应的泛型基类。
    /// </summary>
    public abstract class WechatOpenAIResponse<TData> : WechatOpenAIResponse
        where TData : class
    {
        /// <summary>
        /// 获取微信智能对话 API 返回的数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public virtual TData? Data { get; set; }
    }
}
