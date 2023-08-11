namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /merchant-store/stores/{store_id} 接口的响应。</para>
    /// </summary>
    public class GetMerchantStoreByStoreIdResponse : WechatTenpayResponse
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
        /// 获取或设置门店基础信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_basics")]
        [System.Text.Json.Serialization.JsonPropertyName("store_basics")]
        public Types.Basic Basic { get; set; } = default!;

        /// <summary>
        /// 获取或设置门店地址信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_address")]
        [System.Text.Json.Serialization.JsonPropertyName("store_address")]
        public Types.Address Address { get; set; } = default!;

        /// <summary>
        /// 获取或设置门店经营信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_business")]
        [System.Text.Json.Serialization.JsonPropertyName("store_business")]
        public Types.Business Business { get; set; } = default!;

        /// <summary>
        /// 获取或设置门店收款信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_recipient")]
        [System.Text.Json.Serialization.JsonPropertyName("store_recipient")]
        public Types.Recipient[] RecipientList { get; set; } = default!;
    }
}
