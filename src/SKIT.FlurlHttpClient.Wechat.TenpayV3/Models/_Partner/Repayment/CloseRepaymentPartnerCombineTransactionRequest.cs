using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /repayment/combine-transactions/partner/out-trade-no/{combine_out_trade_no}/close 接口的请求。</para>
    /// </summary>
    public class CloseRepaymentPartnerCombineTransactionRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class SubOrder
            {
                /// <summary>
                /// 获取或设置子单微信商户号。如果不指定将使用还款单微信商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mchid")]
                [System.Text.Json.Serialization.JsonPropertyName("mchid")]
                public string? MerchantId { get; set; }

                /// <summary>
                /// 获取或设置子单子商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_mchid")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
                public string? SubMerchantId { get; set; }

                /// <summary>
                /// 获取或设置子单商户订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_trade_no")]
                [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
                public string OutTradeNumber { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置还款单商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string CombineOutTradeNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置子单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_orders")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_orders")]
        public IList<Types.SubOrder> SubOrderList { get; set; } = new List<Types.SubOrder>();
    }
}
