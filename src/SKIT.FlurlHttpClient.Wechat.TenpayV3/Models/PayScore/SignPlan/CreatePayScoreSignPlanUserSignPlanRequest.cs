using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /payscore/sign-plan/user-sign-plans 接口的请求。</para>
    /// </summary>
    public class CreatePayScoreSignPlanUserSignPlanRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class SignPlanDetail
            {
                /// <summary>
                /// 获取或设置计划明细序号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("plan_detail_no")]
                [System.Text.Json.Serialization.JsonPropertyName("plan_detail_no")]
                public int PlanDetailNumber { get; set; }

                /// <summary>
                /// 获取或设置商户计划明细使用订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_plan_detail_no")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_plan_detail_no")]
                public string OutPlanDetailNumber { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置支付分计划 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plan_id")]
        [System.Text.Json.Serialization.JsonPropertyName("plan_id")]
        public string PlanId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置服务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_id")]
        [System.Text.Json.Serialization.JsonPropertyName("service_id")]
        public string ServiceId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户签约计划单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_sign_plan_no")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_sign_plan_no")]
        public string OutSignPlanNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置回调通知地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public string? NotifyUrl { get; set; }

        /// <summary>
        /// 获取或设置签约计划明细列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign_plan_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("sign_plan_detail")]
        public IList<Types.SignPlanDetail>? SignPlanDetailList { get; set; }
    }
}
