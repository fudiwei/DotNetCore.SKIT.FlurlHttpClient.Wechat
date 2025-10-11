namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /brand/partner/store/brandstores/{store_id} 接口的响应。</para>
    /// </summary>
    public class GetBrandPartnerStoreByStoreIdResponse : WechatTenpayResponse
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

            public class Recipient
            {
                /// <summary>
                /// 获取或设置门店收款商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mchid")]
                [System.Text.Json.Serialization.JsonPropertyName("mchid")]
                public string? MerchantId { get; set; }

                /// <summary>
                /// 获取或设置门店收款主体。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("company_name")]
                [System.Text.Json.Serialization.JsonPropertyName("company_name")]
                public string? CompanyName { get; set; }

                /// <summary>
                /// 获取或设置收款绑定状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("recipient_state")]
                [System.Text.Json.Serialization.JsonPropertyName("recipient_state")]
                public string? RecipientState { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置门店 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_id")]
        [System.Text.Json.Serialization.JsonPropertyName("store_id")]
        public string StoreId { get; set; } = default!;

        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_id")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
        public string BrandId { get; set; } = default!;

        /// <summary>
        /// 获取或设置门店状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_state")]
        [System.Text.Json.Serialization.JsonPropertyName("store_state")]
        public string StoreState { get; set; } = default!;

        /// <summary>
        /// 获取或设置审核状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_state")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_state")]
        public string AuditState { get; set; } = default!;

        /// <summary>
        /// 获取或设置审核失败原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("review_reject_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("review_reject_reason")]
        public string? ReviewRejectReason { get; set; }

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
