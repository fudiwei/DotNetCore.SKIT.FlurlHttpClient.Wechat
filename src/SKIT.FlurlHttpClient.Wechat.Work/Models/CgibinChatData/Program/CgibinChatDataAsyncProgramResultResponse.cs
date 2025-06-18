namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/chatdata/async_program_result 接口的响应。</para>
    /// </summary>
    public class CgibinChatDataAsyncProgramResultResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置专区程序的错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("response_errcode")]
        [System.Text.Json.Serialization.JsonPropertyName("response_errcode")]
        public int ResponseErrorCode { get; set; }

        /// <summary>
        /// 获取或设置专区程序的输出 JSON。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("response_data")]
        [System.Text.Json.Serialization.JsonPropertyName("response_data")]
        public string? ResponseDataJson { get; set; }
    }
}
