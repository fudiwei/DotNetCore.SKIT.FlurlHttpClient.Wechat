namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/deletecloudbaserunserverversion 接口的响应。</para>
    /// </summary>
    public class ComponentTCBDeleteCloudBaseRunServerVersionResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置创建结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        public string Result { get; set; } = default!;
    }
}
