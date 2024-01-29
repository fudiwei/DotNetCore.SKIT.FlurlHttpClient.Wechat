namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /publisher/stat?action=publisher_settlement 接口的响应。</para>
    /// </summary>
    public class PublisherStatSettlementResponse : WechatApiResponse
    {
        public static class Types
        {
            public class BaseResponse
            {
                /// <summary>
                /// 获取或设置错误码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ret")]
                [System.Text.Json.Serialization.JsonPropertyName("ret")]
                public int ErrorCode { get; set; }

                /// <summary>
                /// 获取或设置错误信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("err_msg")]
                [System.Text.Json.Serialization.JsonPropertyName("err_msg")]
                public string ErrorMessage { get; set; } = default!;
            }

            public class SettlementData
            {
                public static class Types
                {
                    public class SlotRevenue
                    {
                        /// <summary>
                        /// 获取或设置产生收入的广告位名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("slot_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("slot_id")]
                        public string AdSlotName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置该广告位结算金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("slot_settled_revenue")]
                        [System.Text.Json.Serialization.JsonPropertyName("slot_settled_revenue")]
                        public long SlotSettledRevenue { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置数据更新时间（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("date")]
                [System.Text.Json.Serialization.JsonPropertyName("date")]
                public string DateString { get; set; } = default!;

                /// <summary>
                /// 获取或设置日期区间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("zone")]
                [System.Text.Json.Serialization.JsonPropertyName("zone")]
                public string ZoneString { get; set; } = default!;

                /// <summary>
                /// 获取或设置收入月份（格式：yyyyMM）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("month")]
                [System.Text.Json.Serialization.JsonPropertyName("month")]
                public string MonthString { get; set; } = default!;

                /// <summary>
                /// 获取或设置收入半月。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order")]
                [System.Text.Json.Serialization.JsonPropertyName("order")]
                public int Order { get; set; }

                /// <summary>
                /// 获取或设置结算状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sett_status")]
                [System.Text.Json.Serialization.JsonPropertyName("sett_status")]
                public int SettleStatus { get; set; }

                /// <summary>
                /// 获取或设置区间内结算收入（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("settled_revenue")]
                [System.Text.Json.Serialization.JsonPropertyName("settled_revenue")]
                public long SettledRevenue { get; set; }

                /// <summary>
                /// 获取或设置结算单编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sett_no")]
                [System.Text.Json.Serialization.JsonPropertyName("sett_no")]
                public string SettleNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置申请补发结算单次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mail_send_cnt")]
                [System.Text.Json.Serialization.JsonPropertyName("mail_send_cnt")]
                public int MailSendCount { get; set; }

                /// <summary>
                /// 获取或设置广告位列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("slot_revenue")]
                [System.Text.Json.Serialization.JsonPropertyName("slot_revenue")]
                public Types.SlotRevenue[] SlotRevenueList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置基本响应信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("base_resp")]
        [System.Text.Json.Serialization.JsonPropertyName("base_resp")]
        public Types.BaseResponse BaseResponse { get; set; } = default!;

        /// <summary>
        /// 获取或设置主体名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("body")]
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public string Body { get; set; } = default!;

        /// <summary>
        /// 获取或设置累计收入（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("revenue_all")]
        [System.Text.Json.Serialization.JsonPropertyName("revenue_all")]
        public long RevenueAmount { get; set; }

        /// <summary>
        /// 获取或设置扣除金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("penalty_all")]
        [System.Text.Json.Serialization.JsonPropertyName("penalty_all")]
        public long PenaltyAmount { get; set; }

        /// <summary>
        /// 获取或设置已结算金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settled_revenue_all")]
        [System.Text.Json.Serialization.JsonPropertyName("settled_revenue_all")]
        public long SettledRevenueAmount { get; set; }

        /// <summary>
        /// 获取或设置结算数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settlement_list")]
        [System.Text.Json.Serialization.JsonPropertyName("settlement_list")]
        public Types.SettlementData[] SettlementList { get; set; } = default!;

        /// <summary>
        /// 获取或设置结算数据总条数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int Total { get; set; }

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && BaseResponse is not null && BaseResponse.ErrorCode == 0;
        }
    }
}
