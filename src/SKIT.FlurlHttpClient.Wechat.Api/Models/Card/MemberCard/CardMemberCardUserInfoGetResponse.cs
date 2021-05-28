using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/membercard/userinfo/get 接口的响应。</para>
    /// </summary>
    public class CardMemberCardUserInfoGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class MemberUser
            {
                public static class Types
                {
                    public class CommonField
                    {
                        /// <summary>
                        /// 获取或设置会员信息类目名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置会员信息类目值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("value")]
                        [System.Text.Json.Serialization.JsonPropertyName("value")]
                        public string Value { get; set; } = default!;
                    }

                    public class CustomField : CommonField
                    {
                    }
                }

                /// <summary>
                /// 获取或设置内置会员信息类目列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("common_field_list")]
                [System.Text.Json.Serialization.JsonPropertyName("common_field_list")]
                public Types.CommonField[] CommonFieldList { get; set; } = default!;

                /// <summary>
                /// 获取或设置自定义会员信息类目列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("custom_field_list")]
                [System.Text.Json.Serialization.JsonPropertyName("custom_field_list")]
                public Types.CustomField[] CustomFieldList { get; set; } = default!;
            }

        }
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
        public string MembershipNumber { get; set; } = default!;

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
        public int MemberBonus { get; set; }

        /// <summary>
        /// 获取或设置会员卡余额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("balance")]
        [System.Text.Json.Serialization.JsonPropertyName("balance")]
        public int MemberBalance { get; set; }

        /// <summary>
        /// 获取或设置卡券状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_card_status")]
        [System.Text.Json.Serialization.JsonPropertyName("user_card_status")]
        public string CardStatus { get; set; } = default!;
    }
}
