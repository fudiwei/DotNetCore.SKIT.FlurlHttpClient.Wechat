namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalpay/get_payment_info 接口的响应。</para>
    /// </summary>
    public class CgibinExternalPayGetPaymentInfoResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Bill
            {
                /// <summary>
                /// 获取或设置商户单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_trade_no")]
                [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
                public string OutTradeNumber { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置收款单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bill_list")]
        [System.Text.Json.Serialization.JsonPropertyName("bill_list")]
        public Types.Bill[] BillList { get; set; } = default!;
    }
}
