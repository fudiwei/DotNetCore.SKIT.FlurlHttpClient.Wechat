namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/create_funds_bill 接口的请求。</para>
    /// </summary>
    public class XPayCreateFundsBillRequest : XPayRequestBase, IInferable<XPayCreateFundsBillRequest, XPayCreateFundsBillResponse>
    {
        /// <summary>
        /// 获取或设置充值账户 UID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_account_uid")]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_account_uid")]
        public int TransferAccountUID { get; set; }

        /// <summary>
        /// 获取或设置充值账户名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_account_name")]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_account_name")]
        public string TransferAccountName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置充值账户服务商账号 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_account_agency_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_account_agency_id")]
        public int? TransferAccountAgencyId { get; set; }

        /// <summary>
        /// 获取或设置充值金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_amount")]
        public int TransferAmount { get; set; }

        /// <summary>
        /// 获取或设置请求唯一 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("request_id")]
        [System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string RequestId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置结算周期开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settle_begin")]
        [System.Text.Json.Serialization.JsonPropertyName("settle_begin")]
        public long SettleBeginTimestamp { get; set; }

        /// <summary>
        /// 获取或设置结算周期结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settle_end")]
        [System.Text.Json.Serialization.JsonPropertyName("settle_end")]
        public long SettleEndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置广告金类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fund_type")]
        [System.Text.Json.Serialization.JsonPropertyName("fund_type")]
        public int FundsType { get; set; }

        /// <summary>
        /// 获取或设置是否授权广告数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorize_advertise")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("authorize_advertise")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
        public bool IsAdvertiseAuthorized { get; set; }

        protected internal override string GetRequestPath()
        {
            return "/xpay/create_funds_bill";
        }
    }
}
