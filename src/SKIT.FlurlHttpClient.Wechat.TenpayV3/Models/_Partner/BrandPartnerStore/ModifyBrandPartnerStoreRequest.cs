namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [PATCH] /brand/partner/store/brandstores/{store_id} 接口的请求。</para>
    /// </summary>
    public class ModifyBrandPartnerStoreRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Basic : CreateBrandPartnerStoreRequest.Types.Basic
            {
            }

            public class Address : CreateBrandPartnerStoreRequest.Types.Address
            {
            }

            public class Business : CreateBrandPartnerStoreRequest.Types.Business
            {
            }
        }

        /// <summary>
        /// 获取或设置门店 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string StoreId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_id")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
        public string BrandId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置门店基础信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_basics")]
        [System.Text.Json.Serialization.JsonPropertyName("store_basics")]
        public Types.Basic? Basic { get; set; } 

        /// <summary>
        /// 获取或设置门店地址信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_address")]
        [System.Text.Json.Serialization.JsonPropertyName("store_address")]
        public Types.Address? Address { get; set; }

        /// <summary>
        /// 获取或设置门店经营信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_business")]
        [System.Text.Json.Serialization.JsonPropertyName("store_business")]
        public Types.Business? Business { get; set; }
    }
}
