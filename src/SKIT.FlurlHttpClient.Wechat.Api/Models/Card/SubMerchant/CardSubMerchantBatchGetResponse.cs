using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/submerchant/batchget 接口的响应。</para>
    /// </summary>
    public class CardSubMerchantBatchGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class SubMerchant : CardSubMerchantGetResponse.Types.SubMerchant
            {
            }
        }

        /// <summary>
        /// 获取或设置子商户列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("info_list")]
        [System.Text.Json.Serialization.JsonPropertyName("info_list")]
        public Types.SubMerchant[] SubMerchantList { get; set; } = default!;

        /// <summary>
        /// 获取或设置列表中最后一个子商户 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_begin_id")]
        [System.Text.Json.Serialization.JsonPropertyName("next_begin_id")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumberTypedStringConverter))]
        public string? NextMerchantId { get; set; }
    }
}
