using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/pay/closeorder 接口的请求。</para>
    /// </summary>
    public class ShopPayCloseOrderRequest : WechatApiRequest, IInferable<ShopPayCloseOrderRequest, ShopPayCloseOrderResponse>
    {
        public static class Types
        {
            public class SubOrder
            {
                /// <summary>
                /// 获取或设置微信商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mchid")]
                [System.Text.Json.Serialization.JsonPropertyName("mchid")]
                public string MerchantId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置商户订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("trade_no")]
                [System.Text.Json.Serialization.JsonPropertyName("trade_no")]
                public string OutTradeNumber { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置合单商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("combine_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("combine_trade_no")]
        public string CombineOutTradeNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置子订单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_orders")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_orders")]
        public IList<Types.SubOrder> SubOrderList { get; set; } = new List<Types.SubOrder>();
    }
}
