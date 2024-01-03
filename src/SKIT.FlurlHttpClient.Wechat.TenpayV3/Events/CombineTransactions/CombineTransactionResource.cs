namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Events
{
    /// <summary>
    /// <para>表示 TRANSACTION.SUCCESS 通知的数据。</para>
    /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/combine-payment/orders/payment-notice.html </para>
    /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/combine-payment/orders/payment-notice.html </para>
    /// </summary>
    public class CombineTransactionResource : WechatTenpayEvent.Types.IDecryptedResource
    {
        public static class Types
        {
            public class SubOrder : Models.GetCombineTransactionByCombineOutTradeNumberResponse.Types.SubOrder
            {
            }

            public class Scene : Models.GetCombineTransactionByCombineOutTradeNumberResponse.Types.Scene
            {
            }

            public class Payer : Models.GetCombineTransactionByCombineOutTradeNumberResponse.Types.Payer
            {
            }
        }

        /// <summary>
        /// 获取或设置合单微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("combine_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("combine_mchid")]
        public string CombineMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置合单微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("combine_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("combine_appid")]
        public string CombineAppId { get; set; } = default!;

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

        /// <summary>
        /// 获取或设置场景信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_info")]
        [System.Text.Json.Serialization.JsonPropertyName("scene_info")]
        public Types.Scene? Scene { get; set; }
    }
}
