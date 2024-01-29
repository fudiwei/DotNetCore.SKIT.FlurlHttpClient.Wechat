using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Events
{
    /// <summary>
    /// <para>表示 ECOMMERCE_ENTRUST.SIGN 通知的数据。</para>
    /// <para>表示 ECOMMERCE_ENTRUST.TERMINATE 通知的数据。</para>
    /// </summary>
    public class EcommerceEntrustResource : WechatTenpayEvent.Types.IDecryptedResource
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
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("mchid")]
        public virtual string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public virtual string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户侧签约协议号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_contract_code")]
        [System.Text.Json.Serialization.JsonPropertyName("out_contract_code")]
        public string OutContractCode { get; set; } = default!;

        /// <summary>
        /// 获取或设置委托代扣协议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_id")]
        [System.Text.Json.Serialization.JsonPropertyName("contract_id")]
        public string ContractId { get; set; } = default!;

        /// <summary>
        /// 获取或设置模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plan_id")]
        [System.Text.Json.Serialization.JsonPropertyName("plan_id")]
        public int PlanId { get; set; }

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置操作时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operate_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("operate_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset OperateTime { get; set; }

        /// <summary>
        /// 获取或设置到期时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_expired_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("contract_expired_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? ExpireTime { get; set; }

        /// <summary>
        /// 获取或设置解约方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_termination_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("contract_termination_mode")]
        public string? TerminationMode { get; set; }
    }
}
