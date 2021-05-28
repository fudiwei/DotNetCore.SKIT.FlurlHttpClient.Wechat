using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/invoice/setbizattr?action=set_pay_mch 接口的请求。</para>
    /// </summary>
    public class CardInvoiceSetPayMerchantRequest : WechatApiRequest
    {
        public static class Types
        {
            public class Merchant
            {
                /// <summary>
                /// 获取或设置微信支付商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mchid")]
                [System.Text.Json.Serialization.JsonPropertyName("mchid")]
                public string MerchantId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置开票平台 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("s_pappid")]
                [System.Text.Json.Serialization.JsonPropertyName("s_pappid")]
                public string SpAppId { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置开票信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("paymch_info")]
        [System.Text.Json.Serialization.JsonPropertyName("paymch_info")]
        public Types.Merchant Merchant { get; set; } = new Types.Merchant();
    }
}
