namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.ThirdParty
{
    /// <summary>
    /// <para>表示 [POST] /v1/file/upload 接口的响应。</para>
    /// </summary>
    public class FileUploadResponse : WechatOpenAIThirdPartyResponse<FileUploadResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置文件唯一标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("file_key")]
                [System.Text.Json.Serialization.JsonPropertyName("file_key")]
                public string FileKey { get; set; } = default!;
            }
        }
    }
}
