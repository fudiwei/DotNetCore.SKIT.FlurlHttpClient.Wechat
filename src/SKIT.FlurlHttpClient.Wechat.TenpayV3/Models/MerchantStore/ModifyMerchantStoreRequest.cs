using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [PATCH] /merchant-store/stores/{store_id} 接口的请求。</para>
    /// </summary>
    public class ModifyMerchantStoreRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Basic : CreateMerchantStoreRequest.Types.Basic
            {
            }

            public class Address : CreateMerchantStoreRequest.Types.Address
            {
            }

            public class Business : CreateMerchantStoreRequest.Types.Business
            {
            }

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
        /// 获取或设置门店基础信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_basics")]
        [System.Text.Json.Serialization.JsonPropertyName("store_basics")]
        public Types.Basic Basic { get; set; } = new Types.Basic();

        /// <summary>
        /// 获取或设置门店地址信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_address")]
        [System.Text.Json.Serialization.JsonPropertyName("store_address")]
        public Types.Address Address { get; set; } = new Types.Address();

        /// <summary>
        /// 获取或设置门店经营信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_business")]
        [System.Text.Json.Serialization.JsonPropertyName("store_business")]
        public Types.Business Business { get; set; } = new Types.Business();

        /// <summary>
        /// 获取或设置门店收款信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_recipient")]
        [System.Text.Json.Serialization.JsonPropertyName("store_recipient")]
        public IList<Types.Recipient>? RecipientList { get; set; }
    }
}
