namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /publisher/stat?action=publisher_cps_general 接口的响应。</para>
    /// </summary>
    public class PublisherStatCpsGeneralResponse : WechatApiResponse
    {
        public static class Types
        {
            public class BaseResponse : PublisherStatSettlementResponse.Types.BaseResponse
            {
            }

            public class Summary
            {
                /// <summary>
                /// 获取或设置拉取量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("req_succ_count")]
                [System.Text.Json.Serialization.JsonPropertyName("req_succ_count")]
                public int RequestSuccessCount { get; set; }

                /// <summary>
                /// 获取或设置曝光量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("exposure_count")]
                [System.Text.Json.Serialization.JsonPropertyName("exposure_count")]
                public int ExposureCount { get; set; }

                /// <summary>
                /// 获取或设置点击量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("click_count")]
                [System.Text.Json.Serialization.JsonPropertyName("click_count")]
                public int ClickCount { get; set; }

                /// <summary>
                /// 获取或设置点击率。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("click_rate")]
                [System.Text.Json.Serialization.JsonPropertyName("click_rate")]
                public double ClickRate { get; set; }

                /// <summary>
                /// 获取或设置下单量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_count")]
                [System.Text.Json.Serialization.JsonPropertyName("order_count")]
                public int OrderCount { get; set; }

                /// <summary>
                /// 获取或设置下单率。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_rate")]
                [System.Text.Json.Serialization.JsonPropertyName("order_rate")]
                public double OrderRate { get; set; }

                /// <summary>
                /// 获取或设置订单总金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_fee")]
                [System.Text.Json.Serialization.JsonPropertyName("total_fee")]
                public long TotalFee { get; set; }

                /// <summary>
                /// 获取或设置总预估收入（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_commission")]
                [System.Text.Json.Serialization.JsonPropertyName("total_commission")]
                public long TotalCommission { get; set; }
            }

            public class Data : Summary
            {
                /// <summary>
                /// 获取或设置数据的日期（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("date")]
                [System.Text.Json.Serialization.JsonPropertyName("date")]
                public string DateString { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置基本响应信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("base_resp")]
        [System.Text.Json.Serialization.JsonPropertyName("base_resp")]
        public Types.BaseResponse BaseResponse { get; set; } = default!;

        /// <summary>
        /// 获取或设置概况数据信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("summary")]
        [System.Text.Json.Serialization.JsonPropertyName("summary")]
        public Types.Summary Summary { get; set; } = default!;

        /// <summary>
        /// 获取或设置数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.Data[] DataList { get; set; } = default!;

        /// <summary>
        /// 获取或设置数据总条数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int Total { get; set; }

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && BaseResponse != null && BaseResponse.ErrorCode == 0;
        }
    }
}
