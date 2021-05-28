using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/qrcode/create 接口的请求。</para>
    /// </summary>
    public class CardQrcodeCreateRequest : WechatApiRequest
    {
        public static class Types
        {
            public class Action
            {
                public static class Types
                {
                    public class Card
                    {
                        /// <summary>
                        /// 获取或设置卡券模板编号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("card_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
                        public string CardId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置卡券 Code。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("code")]
                        [System.Text.Json.Serialization.JsonPropertyName("code")]
                        public string? CardCode { get; set; }

                        /// <summary>
                        /// 获取或设置指定领取者的 OpenId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("openid")]
                        [System.Text.Json.Serialization.JsonPropertyName("openid")]
                        public string? OpenId { get; set; }

                        /// <summary>
                        /// 获取或设置二维码是否领取后不可再次扫描。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_unique_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_unique_code")]
                        public bool? IsUnique { get; set; }

                        /// <summary>
                        /// 获取或设置商家自定义数值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("outer_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("outer_id")]
                        public int? OuterId { get; set; }

                        /// <summary>
                        /// 获取或设置商家自定义字符串。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("outer_str")]
                        [System.Text.Json.Serialization.JsonPropertyName("outer_str")]
                        public string? OuterString { get; set; }
                    }

                    public class MultipleCard
                    {
                        /// <summary>
                        /// 获取或设置卡券列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("card_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("card_list")]
                        public IList<Card> CardList { get; set; } = new List<Card>();
                    }
                }

                /// <summary>
                /// 获取或设置单张卡券信息。与字段 <see cref="MultipleCard"/> 二选一。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("card")]
                [System.Text.Json.Serialization.JsonPropertyName("card")]
                public Types.Card? Card { get; set; }

                /// <summary>
                /// 获取或设置多张卡券信息。与字段 <see cref="Card"/> 二选一。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("multiple_card")]
                [System.Text.Json.Serialization.JsonPropertyName("multiple_card")]
                public Types.MultipleCard? MultipleCard { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置二维码有效时间（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expire_seconds")]
        [System.Text.Json.Serialization.JsonPropertyName("expire_seconds")]
        public int? ExpiresIn { get; set; }

        /// <summary>
        /// 获取或设置二维码类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action_name")]
        [System.Text.Json.Serialization.JsonPropertyName("action_name")]
        public string ActionType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置二维码详细信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action_info")]
        [System.Text.Json.Serialization.JsonPropertyName("action_info")]
        public Types.Action Action { get; set; } = new Types.Action();
    }
}
