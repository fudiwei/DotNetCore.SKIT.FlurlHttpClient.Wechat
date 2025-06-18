namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/voucher/codes/upload 接口的响应。</para>
    /// </summary>
    public class ChannelsECVoucherCodesUploadResponse : WechatApiResponse
    {
        public static class Types
        {
            public class FailedCode
            {
                /// <summary>
                /// 获取或设置券码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("code")]
                [System.Text.Json.Serialization.JsonPropertyName("code")]
                public string Code { get; set; } = default!;

                /// <summary>
                /// 获取或设置错误码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errcode")]
                [System.Text.Json.Serialization.JsonPropertyName("errcode")]
                public int ErrorCode { get; set; }

                /// <summary>
                /// 获取或设置错误信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errmsg")]
                [System.Text.Json.Serialization.JsonPropertyName("errmsg")]
                public string? ErrorMessage { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public long ProductId { get; set; }

        /// <summary>
        /// 获取或设置上传总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; }

        /// <summary>
        /// 获取或设置上传成功的券码列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("success_codes")]
        [System.Text.Json.Serialization.JsonPropertyName("success_codes")]
        public string[]? SucceededCodeList { get; set; }

        /// <summary>
        /// 获取或设置上传成功的数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("success_count")]
        [System.Text.Json.Serialization.JsonPropertyName("success_count")]
        public int SucceededCount { get; set; }

        /// <summary>
        /// 获取或设置上传失败的券码列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_codes")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_codes")]
        public Types.FailedCode[]? FailedCodeList { get; set; }

        /// <summary>
        /// 获取或设置上传失败的数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_count")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_count")]
        public int FailedCount { get; set; }
    }
}
