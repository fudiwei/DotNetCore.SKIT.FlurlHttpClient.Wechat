﻿namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/draft/batchget 接口的请求。</para>
    /// </summary>
    public class CgibinDraftBatchGetRequest : WechatApiRequest, IInferable<CgibinDraftBatchGetRequest, CgibinDraftBatchGetResponse>
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
        /// 获取或设置是否不返回内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("no_content")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("no_content")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool? RequireNoContent { get; set; }
    }
}
