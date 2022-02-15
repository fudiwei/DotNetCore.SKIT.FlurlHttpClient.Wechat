using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/batchget 接口的请求。</para>
    /// </summary>
    public class CardBatchGetRequest : WechatApiRequest, IMapResponse<CardBatchGetRequest, CardBatchGetResponse>
    {
        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("count")]
        [System.Text.Json.Serialization.JsonPropertyName("count")]
        public int Limit { get; set; } = 10;

        /// <summary>
        /// 获取或设置指定状态列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status_list")]
        [System.Text.Json.Serialization.JsonPropertyName("status_list")]
        public IList<string>? StatusList { get; set; }
    }
}
