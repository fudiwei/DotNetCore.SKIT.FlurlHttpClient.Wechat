namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /brand/profitsharing/receivers/add 接口的请求。</para>
    /// </summary>
    public class AddBrandProfitSharingReceiverRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置品牌主商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_mchid")]
        public string BrandMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置电商平台 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置子商户 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
        public string? SubAppId { get; set; }

        /// <summary>
        /// 获取或设置接收方类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置接收方账户。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account")]
        [System.Text.Json.Serialization.JsonPropertyName("account")]
        public string Account { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置接收方商户全称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 获取或设置与分账方的关系类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("relation_type")]
        [System.Text.Json.Serialization.JsonPropertyName("relation_type")]
        public string RelationType { get; set; } = string.Empty;
    }
}
