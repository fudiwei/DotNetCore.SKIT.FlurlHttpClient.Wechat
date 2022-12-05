namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/register/register_shop 接口的请求。</para>
    /// </summary>
    public class ProductRegisterRegisterShopRequest : WechatApiRequest, IInferable<ProductRegisterRegisterShopRequest, ProductRegisterRegisterShopResponse>
    {
        /// <summary>
        /// 获取或设置微信号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wx_name")]
        [System.Text.Json.Serialization.JsonPropertyName("wx_name")]
        public string Wxname { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置身份证姓名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id_card_name")]
        [System.Text.Json.Serialization.JsonPropertyName("id_card_name")]
        public string IdCardName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置身份证号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id_card_number")]
        [System.Text.Json.Serialization.JsonPropertyName("id_card_number")]
        public string IdCardNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置渠道号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel_id")]
        [System.Text.Json.Serialization.JsonPropertyName("channel_id")]
        public int? ChannelId { get; set; }

        /// <summary>
        /// 获取或设置开店类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("api_openstore_type")]
        [System.Text.Json.Serialization.JsonPropertyName("api_openstore_type")]
        public int OpenStoreType { get; set; }

        /// <summary>
        /// 获取或设置授权页 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_page_url")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_page_url")]
        public string? AuthPageUrl { get; set; }
    }
}
