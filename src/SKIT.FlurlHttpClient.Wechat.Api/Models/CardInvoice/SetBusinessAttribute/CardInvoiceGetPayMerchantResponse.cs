namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/invoice/setbizattr?action=get_pay_mch 接口的响应。</para>
    /// </summary>
    public class CardInvoiceGetPayMerchantResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Merchant : CardInvoiceSetPayMerchantRequest.Types.Merchant
            {
            }
        }

        /// <summary>
        /// 获取或设置开票信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("paymch_info")]
        [System.Text.Json.Serialization.JsonPropertyName("paymch_info")]
        public Types.Merchant? Merchant { get; set; }
    }
}
