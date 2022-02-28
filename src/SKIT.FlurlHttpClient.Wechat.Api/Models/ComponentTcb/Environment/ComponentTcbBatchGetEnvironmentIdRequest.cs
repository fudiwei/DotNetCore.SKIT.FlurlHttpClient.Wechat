using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/batchgetenvid 接口的请求。</para>
    /// </summary>
    public class ComponentTcbBatchGetEnvironmentIdRequest : WechatApiRequest, IMapResponse<ComponentTcbBatchGetEnvironmentIdRequest, ComponentTcbBatchGetEnvironmentIdResponse>
    {
        /// <summary>
        /// 获取或设置第三方平台 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ComponentAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置 AppId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appids")]
        [System.Text.Json.Serialization.JsonPropertyName("appids")]
        public IList<string> AppIdList { get; set; } = new List<string>();
    }
}
