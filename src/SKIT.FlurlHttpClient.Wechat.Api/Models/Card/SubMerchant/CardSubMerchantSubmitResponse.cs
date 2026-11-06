namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/submerchant/submit 接口的响应。</para>
    /// </summary>
    public class CardSubMerchantSubmitResponse : WechatApiResponse
    {
        public static class Types
        {
            public class SubMerchant : CardSubMerchantGetResponse.Types.SubMerchant
            {
            }
        }

        /// <summary>
        /// 获取或设置子商户信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("info")]
        [System.Text.Json.Serialization.JsonPropertyName("info")]
        public Types.SubMerchant? SubMerchant { get; set; }
    }
}
