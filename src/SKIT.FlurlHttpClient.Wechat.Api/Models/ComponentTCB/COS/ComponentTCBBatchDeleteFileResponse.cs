namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/batchdeletefile 接口的响应。</para>
    /// </summary>
    public class ComponentTCBBatchDeleteFileResponse : WechatApiResponse
    {
        public static class Types
        {
            public class File : TCBBatchDeleteFileResponse.Types.File
            {
            }
        }

        /// <summary>
        /// 获取或设置文件列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delete_list")]
        [System.Text.Json.Serialization.JsonPropertyName("delete_list")]
        public List<Types.File>? FileList { get; set; }
    }
}
