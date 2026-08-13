namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/download_ios_settlement_bill 接口的响应。</para>
    /// </summary>
    public class XPayDownloadIOSSettlementBillResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Bill
            {
                /// <summary>
                /// 获取或设置月份字符串（格式：yyyyMM）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("month")]
                [System.Text.Json.Serialization.JsonPropertyName("month")]
                public string MonthString { get; set; } = default!;

                /// <summary>
                /// 获取或设置下载地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bill_url")]
                [System.Text.Json.Serialization.JsonPropertyName("bill_url")]
                public string Url { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置结算单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bill_list")]
        [System.Text.Json.Serialization.JsonPropertyName("bill_list")]
        public Types.Bill[] BillList { get; set; } = default!;
    }
}
