using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [POST] /mse-pay/profit-allocations 接口的请求。</para>
    /// </summary>
    public class CreateProfitAllocationRequest : WechatTenpayBusinessRequest
    {
        public static class Types
        {
            public class AllocationDetail
            {
                /// <summary>
                /// 获取或设置平台分账明细单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_allocation_detail_id")]
                [System.Text.Json.Serialization.JsonPropertyName("out_allocation_detail_id")]
                public string OutAllocationDetailId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置接收方账户 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receiver_acct_id")]
                [System.Text.Json.Serialization.JsonPropertyName("receiver_acct_id")]
                public string ReceiverAccountId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置商户名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_name")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_name")]
                public string MerchantName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置分账金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                public int Amount { get; set; }

                /// <summary>
                /// 获取或设置分账场景。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("scenario")]
                [System.Text.Json.Serialization.JsonPropertyName("scenario")]
                public string Scene { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置分账场景补充。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("detail")]
                [System.Text.Json.Serialization.JsonPropertyName("detail")]
                public string? Detail { get; set; }

                /// <summary>
                /// 获取或设置分账原因描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("desc")]
                [System.Text.Json.Serialization.JsonPropertyName("desc")]
                public string? Description { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置企业商户 ID。如果不指定将使用构造 <see cref="WechatTenpayBusinessClient"/> 时的 <see cref="WechatTenpayBusinessClientOptions.EnterpriseId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ent_id")]
        [System.Text.Json.Serialization.JsonPropertyName("ent_id")]
        public string? EnterpriseId { get; set; }

        /// <summary>
        /// 获取或设置微企付支付单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payment_id")]
        [System.Text.Json.Serialization.JsonPropertyName("payment_id")]
        public string PaymentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置平台分账单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_allocation_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_allocation_id")]
        public string OutAllocationId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置分账结果通知 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("server_notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("server_notify_url")]
        public string ServerNotifyUrl { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否解冻剩余未分资金。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finish")]
        [System.Text.Json.Serialization.JsonPropertyName("finish")]
        public bool IsFinish { get; set; }

        /// <summary>
        /// 获取或设置分账明细列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("allocations")]
        [System.Text.Json.Serialization.JsonPropertyName("allocations")]
        public IList<Types.AllocationDetail> AllocationDetailList { get; set; } = new List<Types.AllocationDetail>();
    }
}
