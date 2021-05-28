using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/user/getcardlist 接口的响应。</para>
    /// </summary>
    public class CardUserGetCardListResponse : WechatApiResponse
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
                public string CardId { get; set; } = default!;

                /// <summary>
                /// 获取或设置卡券 Code。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("code")]
                [System.Text.Json.Serialization.JsonPropertyName("code")]
                public string CardCode { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置卡券列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_list")]
        [System.Text.Json.Serialization.JsonPropertyName("card_list")]
        public Types.Card[] CardList { get; set; } = default!;

        /// <summary>
        /// 获取或设置是否有可用的朋友的券。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_share_card")]
        [System.Text.Json.Serialization.JsonPropertyName("has_share_card")]
        public bool HasSharableCard { get; set; }
    }
}
