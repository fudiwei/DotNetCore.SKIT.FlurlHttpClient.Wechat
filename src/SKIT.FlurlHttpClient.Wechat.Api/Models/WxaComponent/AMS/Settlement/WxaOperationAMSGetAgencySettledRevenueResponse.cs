namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/operationams?action=get_agency_settled_revenue 接口的响应。</para>
    /// </summary>
    public class WxaOperationAMSGetAgencySettledRevenueResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Settlement : WxaOperationAMSAgencyGetSettlementResponse.Types.Settlement
            {
                public static new class Types
                {
                    public class SlotRevenue : WxaOperationAMSAgencyGetSettlementResponse.Types.Settlement.Types.SlotRevenue
                    {
                    }
                }

                /// <summary>
                /// 获取或设置广告位收入列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("slot_revenue")]
                [System.Text.Json.Serialization.JsonPropertyName("slot_revenue")]
                public new Types.SlotRevenue[] SlotRevenueList { get; set; } = default!;
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
