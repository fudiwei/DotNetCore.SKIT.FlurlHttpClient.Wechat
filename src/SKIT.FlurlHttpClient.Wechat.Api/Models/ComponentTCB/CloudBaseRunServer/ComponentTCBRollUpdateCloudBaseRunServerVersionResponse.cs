namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/rollupdatecloudbaserunserverversion 接口的响应。</para>
    /// </summary>
    public class ComponentTCBRollUpdateCloudBaseRunServerVersionResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置操作记录 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("run_id")]
        [System.Text.Json.Serialization.JsonPropertyName("run_id")]
        public string RunId { get; set; } = default!;

        /// <summary>
        /// 获取或设置创建结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        public string Result { get; set; } = default!;
    }
}
