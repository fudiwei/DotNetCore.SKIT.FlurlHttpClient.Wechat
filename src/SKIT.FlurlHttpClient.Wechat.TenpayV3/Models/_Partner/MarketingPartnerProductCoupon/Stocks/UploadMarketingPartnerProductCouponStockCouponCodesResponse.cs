namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/partner/product-coupon/product-coupons/{product_coupon_id}/stocks/{stock_id}/upload-coupon-codes 接口的响应。</para>
    /// </summary>
    public class UploadMarketingPartnerProductCouponStockCouponCodesResponse : WechatTenpayResponse
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
        /// 获取或设置去重后上传 Code 总数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; }

        /// <summary>
        /// 获取或设置上传成功的 Code 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("success_code_list")]
        [System.Text.Json.Serialization.JsonPropertyName("success_code_list")]
        public string[]? SuccessCodeList { get; set; }

        /// <summary>
        /// 获取或设置上传失败的 Code 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("failed_code_list")]
        [System.Text.Json.Serialization.JsonPropertyName("failed_code_list")]
        public Types.FailCode[]? FailCodeList { get; set; }

        /// <summary>
        /// 获取或设置已存在的 Code 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("already_exist_code_list")]
        [System.Text.Json.Serialization.JsonPropertyName("already_exist_code_list")]
        public string[]? AlreadyExistedCodeList { get; set; }

        /// <summary>
        /// 获取或设置本次请求中重复的 Code 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("duplicate_code_list")]
        [System.Text.Json.Serialization.JsonPropertyName("duplicate_code_list")]
        public string[]? DuplicateCodeList { get; set; }
    }
}
