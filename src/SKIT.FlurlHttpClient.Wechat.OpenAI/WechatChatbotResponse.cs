namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    /// <summary>
    /// 表示微信智能对话 API 响应的基类。
    /// </summary>
    public abstract class WechatChatbotResponse : CommonResponseBase, ICommonResponse
    {
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
        /// 获取一个值，该值指示调用微信 API 是否成功。
        /// <para>
        /// （即 HTTP 状态码为 200，且 <see cref="ErrorCode"/>、<see cref="ReturnCode"/> 值都为 0）
        /// </para>
        /// </summary>
        /// <returns></returns>
        public override bool IsSuccessful()
        {
            return GetRawStatus() == 200 && ErrorCode.GetValueOrDefault() == 0 && ReturnCode.GetValueOrDefault() == 0 && string.IsNullOrEmpty(ReturnError);
        }
    }

    /// <summary>
    /// 表示微信智能对话 API 响应的泛型基类。
    /// </summary>
    public abstract class WechatChatbotResponse<TData> : WechatChatbotResponse
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
