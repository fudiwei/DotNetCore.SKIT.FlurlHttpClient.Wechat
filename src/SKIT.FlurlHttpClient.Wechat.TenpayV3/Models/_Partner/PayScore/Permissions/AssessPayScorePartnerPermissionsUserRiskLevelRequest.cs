namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /payscore/partner/permissions/assess-user-risk-level 接口的请求。</para>
    /// </summary>
    public class AssessPayScorePartnerPermissionsUserRiskLevelRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class ShoppingInfo
            {
                public static class Types
                {
                    public class Goods : AssessPayScorePermissionsUserRiskLevelRequest.Types.ShoppingInfo.Types.Goods
                    {
                    }
                }

                /// <summary>
                /// 获取或设置商品列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods")]
                [System.Text.Json.Serialization.JsonPropertyName("goods")]
                public List<Types.Goods>? GoodsList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置子商户微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
        public string? SubAppId { get; set; }

        /// <summary>
        /// 获取或设置服务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_id")]
        [System.Text.Json.Serialization.JsonPropertyName("service_id")]
        public string? ServiceId { get; set; }

        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置子商户用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_openid")]
        public string? SubOpenId { get; set; }

        /// <summary>
        /// 获取或设置授权协议号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorization_code")]
        [System.Text.Json.Serialization.JsonPropertyName("authorization_code")]
        public string? AuthorizationCode { get; set; }

        /// <summary>
        /// 获取或设置先用后付商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shopping_info")]
        [System.Text.Json.Serialization.JsonPropertyName("shopping_info")]
        public Types.ShoppingInfo? ShoppingInfo { get; set; }
    }
}
