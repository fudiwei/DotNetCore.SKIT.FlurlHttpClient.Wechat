namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/kf/account/del 接口的请求。</para>
    /// </summary>
    public class CgibinKfAccountDeleteRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置客服账号 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_kfid")]
        [System.Text.Json.Serialization.JsonPropertyName("open_kfid")]
        public string OpenKfId { get; set; } = string.Empty;
    }
}
