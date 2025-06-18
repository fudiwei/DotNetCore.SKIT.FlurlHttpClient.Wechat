namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/batchupdatetriggers 接口的响应。</para>
    /// </summary>
    public class ComponentTCBBatchUpdateTriggersResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Failure : ComponentTCBBatchUploadSCFResponse.Types.Failure
            {
            }
        }

        /// <summary>
        /// 获取或设置失败项列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_list")]
        [System.Text.Json.Serialization.JsonPropertyName("err_list")]
        public Types.Failure[]? FailureList { get; set; }
    }
}
