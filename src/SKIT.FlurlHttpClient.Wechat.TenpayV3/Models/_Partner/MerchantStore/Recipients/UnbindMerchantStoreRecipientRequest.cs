using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant-store/stores/{store_id}/recipients/unbind 接口的请求。</para>
    /// </summary>
    public class UnbindMerchantStoreRecipientRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Recipient : CreateMerchantStoreRequest.Types.Recipient
            {
            }
        }

        /// <summary>
        /// 获取或设置门店 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long StoreId { get; set; }

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置门店收款信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_recipient")]
        [System.Text.Json.Serialization.JsonPropertyName("store_recipient")]
        public IList<Types.Recipient> RecipientList { get; set; } = new List<Types.Recipient>();
    }
}
