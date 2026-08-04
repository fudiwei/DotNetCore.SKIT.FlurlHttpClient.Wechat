namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/todo/get 接口的请求。</para>
    /// </summary>
    public class CgibinTodoGetRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置待办 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("todo_id")]
        [System.Text.Json.Serialization.JsonPropertyName("todo_id")]
        public string TodoId { get; set; } = string.Empty;
    }
}
