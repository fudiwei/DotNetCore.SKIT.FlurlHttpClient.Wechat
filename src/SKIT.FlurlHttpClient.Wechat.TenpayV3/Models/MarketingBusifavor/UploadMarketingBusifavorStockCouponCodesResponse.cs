using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/busifavor/stocks/{stock_id}/couponcodes 接口的响应。</para>
    /// </summary>
    public class UploadMarketingBusifavorStockCouponCodesResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class FailCode
            {
                /// <summary>
                /// 获取或设置上传失败的券 Code。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_code")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_code")]
                public string CouponCode { get; set; } = default!;

                /// <summary>
                /// 获取或设置上传失败错误码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("code")]
                [System.Text.Json.Serialization.JsonPropertyName("code")]
                public string ErrorCode { get; set; } = default!;

                /// <summary>
                /// 获取或设置上传失败错误信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("message")]
                [System.Text.Json.Serialization.JsonPropertyName("message")]
                public string ErrorMessage { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置批次号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_id")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_id")]
        public string StockId { get; set; } = default!;

        /// <summary>
        /// 获取或设置去重后上传 Code 总数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; }

        /// <summary>
        /// 获取或设置上传成功的 Code 总数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("success_count")]
        [System.Text.Json.Serialization.JsonPropertyName("success_count")]
        public int SuccessCount { get; set; }

        /// <summary>
        /// 获取或设置上传成功的 Code 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("success_codes")]
        [System.Text.Json.Serialization.JsonPropertyName("success_codes")]
        public string[]? SuccessCodeList { get; set; }

        /// <summary>
        /// 获取或设置上传成功时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("success_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("success_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        public DateTimeOffset? SuccessTime { get; set; }

        /// <summary>
        /// 获取或设置上传失败的 Code 总数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_count")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_count")]
        public int? FailCount { get; set; }

        /// <summary>
        /// 获取或设置上传失败的 Code 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_codes")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_codes")]
        public Types.FailCode[]? FailCodeList { get; set; }

        /// <summary>
        /// 获取或设置已存在的 Code 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("exist_codes")]
        [System.Text.Json.Serialization.JsonPropertyName("exist_codes")]
        public string[]? ExistedCodeList { get; set; }

        /// <summary>
        /// 获取或设置本次请求中重复的 Code 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("duplicate_codes")]
        [System.Text.Json.Serialization.JsonPropertyName("duplicate_codes")]
        public string[]? DuplicateCodeList { get; set; }
    }
}
