namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/operationams?action=agency_get_adpos_genenral 接口的响应。</para>
    /// </summary>
    public class WxaOperationAMSAgencyGetAdPositionGenenralResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Record : Summary
            {
                /// <summary>
                /// 获取或设置广告位类型 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("slot_id")]
                [System.Text.Json.Serialization.JsonPropertyName("slot_id")]
                public long AdSlotId { get; set; }

                /// <summary>
                /// 获取或设置广告位类型名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ad_slot")]
                [System.Text.Json.Serialization.JsonPropertyName("ad_slot")]
                public string AdSlot { get; set; } = default!;

                /// <summary>
                /// 获取或设置日期字符串（格式：yyyyMMdd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("date")]
                [System.Text.Json.Serialization.JsonPropertyName("date")]
                public string DateString { get; set; } = default!;
            }

            public class Summary
            {
                /// <summary>
                /// 获取或设置拉取数。
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
                /// 获取或设置曝光率（范围：0～1）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("exposure_rate")]
                [System.Text.Json.Serialization.JsonPropertyName("exposure_rate")]
                public double ExposureRate { get; set; }

                /// <summary>
                /// 获取或设置点击量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("click_count")]
                [System.Text.Json.Serialization.JsonPropertyName("click_count")]
                public int ClickCount { get; set; }

                /// <summary>
                /// 获取或设置点击率（范围：0～1）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("click_rate")]
                [System.Text.Json.Serialization.JsonPropertyName("click_rate")]
                public double ClickRate { get; set; }

                /// <summary>
                /// 获取或设置收入（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("income")]
                [System.Text.Json.Serialization.JsonPropertyName("income")]
                public double Income { get; set; }

                /// <summary>
                /// 获取或设置广告千次曝光收益（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ecpm")]
                [System.Text.Json.Serialization.JsonPropertyName("ecpm")]
                public double ECPM { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置返回错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ret")]
        [System.Text.Json.Serialization.JsonPropertyName("ret")]
        public int ReturnCode { get; set; }

        /// <summary>
        /// 获取或设置返回错误信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("err_msg")]
        public string? ReturnMessage { get; set; }

        /// <summary>
        /// 获取或设置汇总数据信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("summary")]
        [System.Text.Json.Serialization.JsonPropertyName("summary")]
        public Types.Summary Summary { get; set; } = default!;

        /// <summary>
        /// 获取或设置每日数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.Record[] RecordList { get; set; } = default!;

        /// <summary>
        /// 获取或设置数据总数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int TotalCount { get; set; } = default!;

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && ReturnCode == 0;
        }
    }
}
