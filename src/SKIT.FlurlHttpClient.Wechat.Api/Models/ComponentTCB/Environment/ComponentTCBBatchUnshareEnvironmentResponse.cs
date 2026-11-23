namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/batchunshareenv 接口的响应。</para>
    /// </summary>
    public class ComponentTCBBatchUnshareEnvironmentResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Error : ComponentTCBBatchShareEnvironmentResponse.Types.Error
            {
            }
        }

        /// <summary>
        /// 获取或设置错误列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_list")]
        [System.Text.Json.Serialization.JsonPropertyName("err_list")]
        public List<Types.Error>? ErrorList { get; set; }
    }
}
