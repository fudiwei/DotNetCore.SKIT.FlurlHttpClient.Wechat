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

            public class State
            {
                /// <summary>
                /// 获取或设置门店状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("store_state_value")]
                [System.Text.Json.Serialization.JsonPropertyName("store_state_value")]
                public string StateValue { get; set; } = default!;

                /// <summary>
                /// 获取或设置门店状态描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("store_state_message")]
                [System.Text.Json.Serialization.JsonPropertyName("store_state_message")]
                public string? StateMessage { get; set; }

                /// <summary>
                /// 获取或设置地址核实失败原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address_failed_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("address_failed_reason")]
                public string? AddressFailedReason { get; set; }
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

        /// <summary>
        /// 获取或设置门店状态信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_state")]
        [System.Text.Json.Serialization.JsonPropertyName("store_state")]
        public Types.State State { get; set; } = default!;
    }
}
