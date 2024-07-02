using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /payscore/permissions/assess-user-risk-level 接口的请求。</para>
    /// </summary>
    public class AssessPayScorePermissionsUserRiskLevelRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class ShoppingInfo
            {
                public static class Types
                {
                    public class Goods
                    {
                        /// <summary>
                        /// 获取或设置商品名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置商品图片链接。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("picture")]
                        [System.Text.Json.Serialization.JsonPropertyName("picture")]
                        public string PictureUrl { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置商品单价（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("amount")]
                        public int Amount { get; set; }

                        /// <summary>
                        /// 获取或设置商品数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("count")]
                        [System.Text.Json.Serialization.JsonPropertyName("count")]
                        public int Count { get; set; }

                        /// <summary>
                        /// 获取或设置商品品类 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("category_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("category_id")]
                        public IList<string>? CategoryIdList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商品列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods")]
                [System.Text.Json.Serialization.JsonPropertyName("goods")]
                public IList<Types.Goods>? GoodsList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置服务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_id")]
        [System.Text.Json.Serialization.JsonPropertyName("service_id")]
        public string ServiceId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

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
