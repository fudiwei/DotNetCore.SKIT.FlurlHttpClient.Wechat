using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /transaction-block/transaction-block-records/sub-mchid/{sub_mchid} 接口的响应。</para>
    /// </summary>
    public class QueryTransactionBlockRecordsResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Record
            {
                /// <summary>
                /// 获取或设置交易拦截记录 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("block_record_id")]
                [System.Text.Json.Serialization.JsonPropertyName("block_record_id")]
                public string BlockRecordId { get; set; } = default!;

                /// <summary>
                /// 获取或设置拦截时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("block_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("block_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset BlockTime { get; set; }

                /// <summary>
                /// 获取或设置拦截原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("block_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("block_reason")]
                public string BlockReason { get; set; } = default!;

                /// <summary>
                /// 获取或设置拦截笔数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("number_of_block")]
                [System.Text.Json.Serialization.JsonPropertyName("number_of_block")]
                public string? NumberOfBlock { get; set; }

                /// <summary>
                /// 获取或设置解除管控方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("recover_way")]
                [System.Text.Json.Serialization.JsonPropertyName("recover_way")]
                public string? RecoverWay { get; set; }

                /// <summary>
                /// 获取或设置要求提交的资料（JSON 格式）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("requested_item_info")]
                [System.Text.Json.Serialization.JsonPropertyName("requested_item_info")]
                public string? RequestedData { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置交易拦截记录列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Record[] RecordList { get; set; } = default!;

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
        /// 获取或设置券总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; }
    }
}
