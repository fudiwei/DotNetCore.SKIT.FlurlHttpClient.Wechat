using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/wxpaylist 接口的响应。</para>
    /// </summary>
    public class TcbWxpayListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Merchant
            {
                /// <summary>
                /// 获取或设置商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_code")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_code")]
                public string MerchantId { get; set; } = default!;

                /// <summary>
                /// 获取或设置商户名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_name")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_name")]
                public string MerchantName { get; set; } = default!;

                /// <summary>
                /// 获取或设置主体名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("company_name")]
                [System.Text.Json.Serialization.JsonPropertyName("company_name")]
                public string CompanyName { get; set; } = default!;

                /// <summary>
                /// 获取或设置绑定关系。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mch_relation_state")]
                [System.Text.Json.Serialization.JsonPropertyName("mch_relation_state")]
                public string RelationState { get; set; } = default!;

                /// <summary>
                /// 获取或设置 JS-API 授权状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("jsapi_auth_state")]
                [System.Text.Json.Serialization.JsonPropertyName("jsapi_auth_state")]
                public string JsapiAuthState { get; set; } = default!;

                /// <summary>
                /// 获取或设置退款授权状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_auth_state")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_auth_state")]
                public string RefundAuthState { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置商户列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.Merchant[] MerchantList { get; set; } = default!;
    }
}
