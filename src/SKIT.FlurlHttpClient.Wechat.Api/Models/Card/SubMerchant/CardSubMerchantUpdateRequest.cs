namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/submerchant/update 接口的请求。</para>
    /// </summary>
    public class CardSubMerchantUpdateRequest : WechatApiRequest
    {
        public static class Types
        {
            public class SubMerchant : CardSubMerchantSubmitRequest.Types.SubMerchant
            {
                /// <summary>
                /// 获取或设置子商户 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_id")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_id")]
                public string MerchantId { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置子商户信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("info")]
        [System.Text.Json.Serialization.JsonPropertyName("info")]
        public Types.SubMerchant SubMerchant { get; set; } = new Types.SubMerchant();
    }
}
