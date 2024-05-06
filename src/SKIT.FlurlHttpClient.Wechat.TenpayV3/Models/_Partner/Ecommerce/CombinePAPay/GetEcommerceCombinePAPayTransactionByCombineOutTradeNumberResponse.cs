namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /ecommerce/combine-papay/transactions/{combine_out_trade_no} 接口的响应。</para>
    /// </summary>
    public class GetEcommerceCombinePAPayTransactionByCombineOutTradeNumberResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class SubOrder : GetCombineTransactionByCombineOutTradeNumberResponse.Types.SubOrder
            {
                public static new class Types
                {
                    public class Amount : GetCombineTransactionByCombineOutTradeNumberResponse.Types.SubOrder.Types.Amount
                    {
                    }
                }

                /// <summary>
                /// 获取或设置金额信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                public new Types.Amount Amount { get; set; } = default!;
            }

            public class Payer : GetCombineTransactionByCombineOutTradeNumberResponse.Types.Payer
            {
            }
        }

        /// <summary>
        /// 获取或设置合单发起方的微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("combine_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("combine_appid")]
        public string CombineAppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置合单发起方的微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("combine_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("combine_mchid")]
        public string CombineMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置合单商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("combine_out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("combine_out_trade_no")]
        public string CombineOutTradeNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置子单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_orders")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_orders")]
        public Types.SubOrder[]? SubOrderList { get; set; } = default!;

        /// <summary>
        /// 获取或设置支付者信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("combine_payer_info")]
        [System.Text.Json.Serialization.JsonPropertyName("combine_payer_info")]
        public Types.Payer? CombinePayer { get; set; }
    }
}
