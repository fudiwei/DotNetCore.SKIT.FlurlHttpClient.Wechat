using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /ecommerce/individual-contracts/{openid} 接口的响应。</para>
    /// </summary>
    public class GetEcommerceIndividualContractByOpenIdResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置个人收款方受理授权 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("individual_auth_id")]
        [System.Text.Json.Serialization.JsonPropertyName("individual_auth_id")]
        public string IndividualAuthId { get; set; } = default!;

        /// <summary>
        /// 获取或设置操作时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operation_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("operation_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset OperateTime { get; set; }

        /// <summary>
        /// 获取或设置授权状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_state")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_state")]
        public string AuthState { get; set; } = default!;
    }
}
