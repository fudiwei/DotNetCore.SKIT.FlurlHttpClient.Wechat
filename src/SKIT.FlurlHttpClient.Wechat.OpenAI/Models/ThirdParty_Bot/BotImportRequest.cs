namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.ThirdParty
{
    /// <summary>
    /// <para>表示 [POST] /v1/bot/import 接口的请求。</para>
    /// </summary>
    public class BotImportRequest : WechatOpenAIThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置上传的文件标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_key")]
        [System.Text.Json.Serialization.JsonPropertyName("file_key")]
        public string FileKey { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否覆盖。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cover")]
        [System.Text.Json.Serialization.JsonPropertyName("cover")]
        public bool IsCover { get; set; }
    }
}
