using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/submerchant/get 接口的请求。</para>
    /// </summary>
    public class CardSubMerchantGetRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置子商户 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_id")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_id")]
        public string MerchantId { get; set; } = string.Empty;
    }
}
