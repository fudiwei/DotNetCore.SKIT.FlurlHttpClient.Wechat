namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/code/get 接口的响应。</para>
    /// </summary>
    public class CardCodeGetResponse : WechatApiResponse
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
                public string? CardCode { get; set; }

                /// <summary>
                /// 获取或设置卡券编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("card_number")]
                [System.Text.Json.Serialization.JsonPropertyName("card_number")]
                public string? CardNumber { get; set; }

                /// <summary>
                /// 获取或设置起用时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("begin_time")]
                [System.Text.Json.Serialization.JsonPropertyName("begin_time")]
                public long BeginTimestamp { get; set; }

                /// <summary>
                /// 获取或设置过期时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                public long EndTimestamp { get; set; }

                /// <summary>
                /// 获取或设置积分。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bonus")]
                [System.Text.Json.Serialization.JsonPropertyName("bonus")]
                public int? Bonus { get; set; }

                /// <summary>
                /// 获取或设置余额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("balance")]
                [System.Text.Json.Serialization.JsonPropertyName("balance")]
                public int? Balance { get; set; }
            }

            public class MemberUser : CardMemberCardUserInfoGetResponse.Types.MemberUser
            {
            }
        }

        /// <summary>
        /// 获取或设置卡券信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card")]
        [System.Text.Json.Serialization.JsonPropertyName("card")]
        public Types.Card Card { get; set; } = default!;

        /// <summary>
        /// 获取或设置卡券状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_card_status")]
        [System.Text.Json.Serialization.JsonPropertyName("user_card_status")]
        public string CardStatus { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户昵称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nickname")]
        [System.Text.Json.Serialization.JsonPropertyName("nickname")]
        public string Nickname { get; set; } = default!;

        /// <summary>
        /// 获取或设置会员卡编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("membership_number")]
        [System.Text.Json.Serialization.JsonPropertyName("membership_number")]
        public string? MembershipNumber { get; set; }

        /// <summary>
        /// 获取或设置会员信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_info")]
        [System.Text.Json.Serialization.JsonPropertyName("user_info")]
        public Types.MemberUser? MemberUser { get; set; }

        /// <summary>
        /// 获取或设置会员卡积分。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bonus")]
        [System.Text.Json.Serialization.JsonPropertyName("bonus")]
        public int? MemberBonus { get; set; }

        /// <summary>
        /// 获取或设置会员卡余额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("balance")]
        [System.Text.Json.Serialization.JsonPropertyName("balance")]
        public int? MemberBalance { get; set; }

        /// <summary>
        /// 获取或设置订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string? OrderId { get; set; }

        /// <summary>
        /// 获取或设置背景图片 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("background_pic_url")]
        [System.Text.Json.Serialization.JsonPropertyName("background_pic_url")]
        public string? BackgroundPictureUrl { get; set; }

        /// <summary>
        /// 获取或设置是否可以核销。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("can_consume")]
        [System.Text.Json.Serialization.JsonPropertyName("can_consume")]
        public bool? CanConsume { get; set; }

        /// <summary>
        /// 获取或设置商家自定义字符串。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("outer_str")]
        [System.Text.Json.Serialization.JsonPropertyName("outer_str")]
        public string? OuterString { get; set; }
    }
}
