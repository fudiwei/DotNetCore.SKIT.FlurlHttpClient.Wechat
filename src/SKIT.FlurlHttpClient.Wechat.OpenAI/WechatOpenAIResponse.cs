namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    /// <summary>
    /// 表示微信智能对话 API 响应的基类。
    /// </summary>
    public abstract class WechatOpenAIResponse : CommonResponseBase, ICommonResponse
    {
        /// <summary>
        /// 获取微信智能对话 API 返回的返回码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public virtual int? Code { get; set; }

        /// <summary>
        /// 获取微信智能对话 API 返回的返回信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg")]
        [System.Text.Json.Serialization.JsonPropertyName("msg")]
        public virtual string? Message { get; set; }

        /// <summary>
        /// 获取微信智能对话 API 返回的请求唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("request_id")]
        [System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public virtual string? RequestId { get; set; }

        /// <summary>
        /// 获取一个值，该值指示调用微信 API 是否成功。
        /// <para>
        /// （即 HTTP 状态码为 200，且 <see cref="Code"/> 值都为 0）
        /// </para>
        /// </summary>
        /// <returns></returns>
        public override bool IsSuccessful()
        {
            return GetRawStatus() == 200 && Code.GetValueOrDefault() == 0;
        }
    }

    /// <summary>
    /// 表示微信智能对话 API 响应的泛型基类。
    /// </summary>
    public abstract class WechatOpenAIResponse<TData> : WechatOpenAIResponse
        where TData : WechatOpenAIResponseData
    {
        /// <summary>
        /// 获取微信智能对话 API 返回的数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public virtual TData? Data { get; set; }
    }

    /// <summary>
    /// 表示微信智能对话 API 响应的返回数据基类。
    /// </summary>
    public abstract class WechatOpenAIResponseData
    {
        /// <summary>
        /// 获取或设置错误详情。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("err_detail")]
        public virtual string? ErrorDetail { get; set; }
    }
}
