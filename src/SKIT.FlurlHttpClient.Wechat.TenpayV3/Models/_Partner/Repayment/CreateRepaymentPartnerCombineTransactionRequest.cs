using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /repayment/combine-transactions/partner/prepay 接口的请求。</para>
    /// </summary>
    public class CreateRepaymentPartnerCombineTransactionRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class SubOrder
            {
                public static class Types
                {
                    public class Amount : CreateCombineTransactionAppRequest.Types.SubOrder.Types.Amount
                    {
                    }

                    public class Settlement : CreateCombineTransactionAppRequest.Types.SubOrder.Types.Settlement
                    {
                    }
                }

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
            }

            public class AppInfo
            {
                /// <summary>
                /// 获取或设置还款商户 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("combine_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("combine_appid")]
                public string CombineAppId { get; set; } = string.Empty;
            }

            public class H5Info : CreateCombineTransactionH5Request.Types.Scene.Types.H5Info
            {
                /// <summary>
                /// 获取或设置还款商户 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("combine_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("combine_appid")]
                public string CombineAppId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置用户终端 IP。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("payer_client_ip")]
                [System.Text.Json.Serialization.JsonPropertyName("payer_client_ip")]
                public string ClientIp { get; set; } = string.Empty;
            }

            public class MiniProgramInfo
            {
                /// <summary>
                /// 获取或设置还款商户 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("combine_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("combine_appid")]
                public string CombineAppId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置用户 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置还款单发起方的微信商户号。如果不指定将使用构造 <see cref="WechatTenpayClient"/> 时的 <see cref="WechatTenpayClientOptions.MerchantId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("combine_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("combine_mchid")]
        public string? CombineMerchantId { get; set; }

        /// <summary>
        /// 获取或设置还款商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("combine_out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("combine_out_trade_no")]
        public string CombineOutTradeNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置交易结束时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time_expire")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("time_expire")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
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
        /// 获取或设置 App 支付场景信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_info")]
        [System.Text.Json.Serialization.JsonPropertyName("app_info")]
        public Types.AppInfo? AppInfo { get; set; }

        /// <summary>
        /// 获取或设置 H5 支付场景信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("h5_info")]
        [System.Text.Json.Serialization.JsonPropertyName("h5_info")]
        public Types.H5Info? H5Info { get; set; }

        /// <summary>
        /// 获取或设置小程序支付场景信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("miniprogram_info")]
        [System.Text.Json.Serialization.JsonPropertyName("miniprogram_info")]
        public Types.MiniProgramInfo? MiniProgramInfo { get; set; }
    }
}
