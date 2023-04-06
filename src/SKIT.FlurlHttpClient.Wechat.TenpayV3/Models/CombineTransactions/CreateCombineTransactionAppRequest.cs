using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /combine-transactions/app 接口的请求。</para>
    /// </summary>
    public class CreateCombineTransactionAppRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class SubOrder
            {
                public static class Types
                {
                    public class Amount
                    {
                        /// <summary>
                        /// 获取或设置标价金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_amount")]
                        public int Total { get; set; }

                        /// <summary>
                        /// 获取或设置标价币种。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("currency")]
                        [System.Text.Json.Serialization.JsonPropertyName("currency")]
                        public string Currency { get; set; } = "CNY";
                    }

                    public class Settlement
                    {
                        /// <summary>
                        /// 获取或设置是否指定分账。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("profit_sharing")]
                        [System.Text.Json.Serialization.JsonPropertyName("profit_sharing")]
                        public bool? IsProfitSharing { get; set; }

                        /// <summary>
                        /// 获取或设置补差金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("subsidy_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("subsidy_amount")]
                        public long? SubsidyAmount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置子单微信商户号。如果不指定将使用合单微信商户号。
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
                /// 获取或设置子单子商户 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
                public string? SubAppId { get; set; }

                /// <summary>
                /// 获取或设置附加数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("attach")]
                [System.Text.Json.Serialization.JsonPropertyName("attach")]
                public string? Attachment { get; set; }

                /// <summary>
                /// 获取或设置商品描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string Description { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置子单商户订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_trade_no")]
                [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
                public string OutTradeNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置金额信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                public Types.Amount Amount { get; set; } = new Types.Amount();

                /// <summary>
                /// 获取或设置结算信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("settle_info")]
                [System.Text.Json.Serialization.JsonPropertyName("settle_info")]
                public Types.Settlement? Settlement { get; set; }

                /// <summary>
                /// 获取或设置订单优惠标记。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_tag")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_tag")]
                public string? GoodsTag { get; set; }
            }

            public class Payer
            {
                /// <summary>
                /// 获取或设置用户唯一标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string? OpenId { get; set; }

                /// <summary>
                /// 获取或设置用户在子商户下的唯一标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_openid")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_openid")]
                public string? SubOpenId { get; set; }
            }

            public class Scene
            {
                /// <summary>
                /// 获取或设置用户终端 IP。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("payer_client_ip")]
                [System.Text.Json.Serialization.JsonPropertyName("payer_client_ip")]
                public string ClientIp { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置商户端设备号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("device_id")]
                [System.Text.Json.Serialization.JsonPropertyName("device_id")]
                public string? DeviceId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置合单发起方的微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("combine_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("combine_appid")]
        public string CombineAppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置合单发起方的微信商户号。如果不指定将使用构造 <see cref="WechatTenpayClient"/> 时的 <see cref="WechatTenpayClientOptions.MerchantId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("combine_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("combine_mchid")]
        public string? CombineMerchantId { get; set; }

        /// <summary>
        /// 获取或设置合单商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("combine_out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("combine_out_trade_no")]
        public string CombineOutTradeNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置交易起始时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time_start")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("time_start")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        public DateTimeOffset? StartTime { get; set; }

        /// <summary>
        /// 获取或设置交易结束时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time_expire")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("time_expire")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        public DateTimeOffset? ExpireTime { get; set; }

        /// <summary>
        /// 获取或设置回调通知地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public string? NotifyUrl { get; set; }

        /// <summary>
        /// 获取或设置子单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_orders")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_orders")]
        public IList<Types.SubOrder> SubOrderList { get; set; } = new List<Types.SubOrder>();

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
