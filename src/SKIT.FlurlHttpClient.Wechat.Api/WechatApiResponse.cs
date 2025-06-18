namespace SKIT.FlurlHttpClient.Wechat.Api
{
    /// <summary>
    /// 表示微信 API 响应的基类。
    /// </summary>
    public abstract class WechatApiResponse : CommonResponseBase, ICommonResponse
    {
        /// <summary>
        /// 获取微信 API 返回的错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("errcode")]
        [System.Text.Json.Serialization.JsonPropertyName("errcode")]
        public virtual int ErrorCode { get; set; }

        /// <summary>
        /// 获取微信 API 返回的错误描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("errmsg")]
        [System.Text.Json.Serialization.JsonPropertyName("errmsg")]
        public virtual string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取一个值，该值指示调用微信 API 是否成功。
        /// <para>
        /// （即 HTTP 状态码为 200，且 <see cref="ErrorCode"/> 值为 0）
        /// </para>
        /// </summary>
        /// <returns></returns>
        public override bool IsSuccessful()
        {
            return GetRawStatus() == 200 && ErrorCode == 0;
        }
    }
}
