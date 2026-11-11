namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /ecommerce/bill/fundflowbill 接口的响应。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class GetEcommerceBillFundflowBillResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Bill : GetBillSubMerchantFundflowBillResponse.Types.Bill
            {
            }
        }

        /// <summary>
        /// 获取或设置下载信息明细列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("download_bill_list")]
        [System.Text.Json.Serialization.JsonPropertyName("download_bill_list")]
        public List<Types.Bill>? BillList { get; set; }

        /// <summary>
        /// 获取或设置下载信息总数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("download_bill_count")]
        [System.Text.Json.Serialization.JsonPropertyName("download_bill_count")]
        public int BillCount { get; set; }
    }
}
