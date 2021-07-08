using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /ecommerce/profitsharing/orders 接口的请求。</para>
    /// </summary>
    public class CreateEcommerceProfitSharingOrderRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Receiver
            {
                /// <summary>
                /// 获取或设置分账接收方类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string Type { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置分账接收方账户。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receiver_account")]
                [System.Text.Json.Serialization.JsonPropertyName("receiver_account")]
                public string Account { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置分账个人姓名（需使用微信支付平台公钥加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receiver_name")]
                [System.Text.Json.Serialization.JsonPropertyName("receiver_name")]
                public string? Name { get; set; }

                /// <summary>
                /// 获取或设置分账金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                public int Amount { get; set; }

                /// <summary>
                /// 获取或设置分账描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string Description { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置微信二级商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置电商平台 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置微信订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户分账单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_order_no")]
        public string OutOrderNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置分账接收方列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("receivers")]
        [System.Text.Json.Serialization.JsonPropertyName("receivers")]
        public IList<Types.Receiver> ReceiverList { get; set; } = new List<Types.Receiver>();

        /// <summary>
        /// 获取或设置是否分账完成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finish")]
        [System.Text.Json.Serialization.JsonPropertyName("finish")]
        public bool IsFinish { get; set; }
    }
}
