namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/operationams?action=agency_get_adunit_general 接口的响应。</para>
    /// </summary>
    public class WxaOperationAMSAgencyGetAdUnitGenenralResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Record
            {
                public static class Types
                {
                    public class Statistics : WxaOperationAMSAgencyGetAdPositionGenenralResponse.Types.Summary
                    {
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
                }

                /// <summary>
                /// 获取或设置广告单元 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ad_unit_id")]
                [System.Text.Json.Serialization.JsonPropertyName("ad_unit_id")]
                public string AdUnitId { get; set; } = default!;

                /// <summary>
                /// 获取或设置广告单元名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ad_unit_name")]
                [System.Text.Json.Serialization.JsonPropertyName("ad_unit_name")]
                public string AdUnitName { get; set; } = default!;

                /// <summary>
                /// 获取或设置统计数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stat_item")]
                [System.Text.Json.Serialization.JsonPropertyName("stat_item")]
                public Types.Statistics[] StatisticsList { get; set; } = default!;
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
