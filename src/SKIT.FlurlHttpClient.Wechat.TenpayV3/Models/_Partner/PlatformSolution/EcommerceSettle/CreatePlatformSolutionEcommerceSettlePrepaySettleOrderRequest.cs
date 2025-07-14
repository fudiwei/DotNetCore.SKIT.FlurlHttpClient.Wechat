using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /platsolution/ecommerce/settle/prepay-settle-orders 接口的请求。</para>
    /// </summary>
    public class CreatePlatformSolutionEcommerceSettlePrepaySettleOrderRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class SettleInfo
            {
                /// <summary>
                /// 获取或设置微信支付订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("transaction_id")]
                [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
                public string TransactionId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置商户结算单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_settle_no")]
                [System.Text.Json.Serialization.JsonPropertyName("out_settle_no")]
                public string OutSettleNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置结算明细单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("settle_detail_info_list")]
                [System.Text.Json.Serialization.JsonPropertyName("settle_detail_info_list")]
                public IList<SettleDetailInfo> SettleDetailInfoList { get; set; } = new List<SettleDetailInfo>();
            }

            public class SettleDetailInfo
            {
                public static class Types
                {
                    public class Amount
                    {
                        /// <summary>
                        /// 获取或设置结算金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("amount")]
                        public int Total { get; set; }

                        /// <summary>
                        /// 获取或设置结算币种。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("currency")]
                        [System.Text.Json.Serialization.JsonPropertyName("currency")]
                        public string? Currency { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商户结算明细单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_settle_detail_no")]
                [System.Text.Json.Serialization.JsonPropertyName("out_settle_detail_no")]
                public string OutSettleDetailNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置结算类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("settle_type")]
                [System.Text.Json.Serialization.JsonPropertyName("settle_type")]
                public string SettleType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置接收方类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receiver_type")]
                [System.Text.Json.Serialization.JsonPropertyName("receiver_type")]
                public string? ReceiverType { get; set; }

                /// <summary>
                /// 获取或设置接收方账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receiver_account")]
                [System.Text.Json.Serialization.JsonPropertyName("receiver_account")]
                public string? ReceiverAccount { get; set; }

                /// <summary>
                /// 获取或设置金额信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                public Types.Amount Amount { get; set; } = new Types.Amount();
            }
        }

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置个人收款方受理授权 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("individual_auth_id")]
        [System.Text.Json.Serialization.JsonPropertyName("individual_auth_id")]
        public string? IndividualAuthId { get; set; }

        /// <summary>
        /// 获取或设置商户结算批次单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_settle_batch_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_settle_batch_no")]
        public string OutSettleBatchNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置结算信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settle_info_list")]
        [System.Text.Json.Serialization.JsonPropertyName("settle_info_list")]
        public IList<Types.SettleInfo> SettleInfoList { get; set; } = new List<Types.SettleInfo>();

        /// <summary>
        /// 获取或设置回调通知地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public string? NotifyUrl { get; set; }

        /// <summary>
        /// 获取或设置收款方描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置交易场景。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_scenario")]
        [System.Text.Json.Serialization.JsonPropertyName("trade_scenario")]
        public string? TradeScenario { get; set; }
    }
}
