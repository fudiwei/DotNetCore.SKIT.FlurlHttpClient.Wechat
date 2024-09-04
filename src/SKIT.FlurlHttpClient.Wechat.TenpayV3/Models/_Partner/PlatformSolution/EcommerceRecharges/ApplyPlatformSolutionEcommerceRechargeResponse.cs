using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /platsolution/ecommerce/recharges/apply 接口的响应。</para>
    /// </summary>
    public class ApplyPlatformSolutionEcommerceRechargeResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置商户充值单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_recharge_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_recharge_no")]
        public string OutRechargeNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信充值单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("recharge_id")]
        [System.Text.Json.Serialization.JsonPropertyName("recharge_id")]
        public string RechargeId { get; set; } = default!;

        /// <summary>
        /// 获取或设置充值链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("recharge_url")]
        [System.Text.Json.Serialization.JsonPropertyName("recharge_url")]
        public string RechargeUrl { get; set; } = default!;
    }
}
