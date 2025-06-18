namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/operationams?action=agency_get_settlement 接口的响应。</para>
    /// </summary>
    public class WxaOperationAMSAgencyGetSettlementResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Settlement
            {
                public static class Types
                {
                    public class SlotRevenue
                    {
                        /// <summary>
                        /// 获取或设置广告位类型 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("slot_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("slot_id")]
                        public string AdSlotId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置广告位结算收入（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("slot_settled_revenue")]
                        [System.Text.Json.Serialization.JsonPropertyName("slot_settled_revenue")]
                        public int SettledRevenue { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置日期字符串（格式：yyyyMMdd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("date")]
                [System.Text.Json.Serialization.JsonPropertyName("date")]
                public string DateString { get; set; } = default!;

                /// <summary>
                /// 获取或设置日期区间字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("zone")]
                [System.Text.Json.Serialization.JsonPropertyName("zone")]
                public string ZoneString { get; set; } = default!;

                /// <summary>
                /// 获取或设置收入月份字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("month")]
                [System.Text.Json.Serialization.JsonPropertyName("month")]
                public string MonthString { get; set; } = default!;

                /// <summary>
                /// 获取或设置半月次序。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order")]
                [System.Text.Json.Serialization.JsonPropertyName("order")]
                public int Order { get; set; }

                /// <summary>
                /// 获取或设置结算状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sett_status")]
                [System.Text.Json.Serialization.JsonPropertyName("sett_status")]
                public int SettlementStatus { get; set; }

                /// <summary>
                /// 获取或设置结算单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sett_no")]
                [System.Text.Json.Serialization.JsonPropertyName("sett_no")]
                public string SettlementNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置结算收入（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("settled_revenue")]
                [System.Text.Json.Serialization.JsonPropertyName("settled_revenue")]
                public long SettledRevenue { get; set; }

                /// <summary>
                /// 获取或设置申请补发结算单次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mail_send_cnt")]
                [System.Text.Json.Serialization.JsonPropertyName("mail_send_cnt")]
                public int MailSendCount { get; set; }

                /// <summary>
                /// 获取或设置广告位收入列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("slot_revenue")]
                [System.Text.Json.Serialization.JsonPropertyName("slot_revenue")]
                public Types.SlotRevenue[] SlotRevenueList { get; set; } = default!;
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
        /// 获取或设置累计收入（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("revenue_all")]
        [System.Text.Json.Serialization.JsonPropertyName("revenue_all")]
        public long RevenueAll { get; set; }

        /// <summary>
        /// 获取或设置扣除金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("penalty_all")]
        [System.Text.Json.Serialization.JsonPropertyName("penalty_all")]
        public long PenaltyAll { get; set; }

        /// <summary>
        /// 获取或设置已结算金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settled_revenue_all")]
        [System.Text.Json.Serialization.JsonPropertyName("settled_revenue_all")]
        public long SettledRevenueAll { get; set; }

        /// <summary>
        /// 获取或设置结算数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settlement_list")]
        [System.Text.Json.Serialization.JsonPropertyName("settlement_list")]
        public Types.Settlement[] SettlementList { get; set; } = default!;

        /// <summary>
        /// 获取或设置结算数据总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int TotalCount { get; set; }

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && ReturnCode == 0;
        }
    }
}
