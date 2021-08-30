using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /merchant-service/complaints-v2/{complaint_id}/negotiation-historys 接口的响应。</para>
    /// </summary>
    public class QueryMerchantServiceComplaintNegotiationHistoriesResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class NegotiationHistory
            {
                public static class Types
                {
                    public class ComplaintMedia : GetMerchantServiceComplaintByComplaintIdResponse.Types.ComplaintMedia
                    { 
                    }
                }

                /// <summary>
                /// 获取或设置操作流水号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("log_id")]
                [System.Text.Json.Serialization.JsonPropertyName("log_id")]
                public string LogId { get; set; } = default!;

                /// <summary>
                /// 获取或设置操作人。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("operator")]
                [System.Text.Json.Serialization.JsonPropertyName("operator")]
                public string Operator { get; set; } = default!;

                /// <summary>
                /// 获取或设置操作时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("operate_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("operate_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
                public DateTimeOffset OperateTime { get; set; }

                /// <summary>
                /// 获取或设置操作时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("operate_type")]
                [System.Text.Json.Serialization.JsonPropertyName("operate_type")]
                public string OperateType { get; set; } = default!;

                /// <summary>
                /// 获取或设置操作内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("operate_details")]
                [System.Text.Json.Serialization.JsonPropertyName("operate_details")]
                public string? OperateDetails { get; set; }

                /// <summary>
                /// 获取或设置图片凭证地址列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image_list")]
                [System.Text.Json.Serialization.JsonPropertyName("image_list")]
                public string[]? ImageUrlList { get; set; }

                /// <summary>
                /// 获取或设置投诉资料列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("complaint_media_list")]
                [System.Text.Json.Serialization.JsonPropertyName("complaint_media_list")]
                public Types.ComplaintMedia[]? ComplaintMediaList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置投诉协商历史列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.NegotiationHistory[] NegotiationHistoryList { get; set; } = default!;

        /// <summary>
        /// 获取或设置分页大小。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// 获取或设置分页开始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// 获取或设置投诉协商历史总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int? TotalCount { get; set; }
    }
}
