using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/externalcontact/get 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactGetResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class ExternalContact
            {
                public static class Types
                {
                    public class Subscriber
                    {
                        /// <summary>
                        /// 获取或设置学校为家长设置的企业标签 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tag_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("tag_id")]
                        public string[]? TagId { get; set; }

                        /// <summary>
                        /// 获取或设置学校为家长设置的备注。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("remark")]
                        [System.Text.Json.Serialization.JsonPropertyName("remark")]
                        public string? Remark { get; set; }

                        /// <summary>
                        /// 获取或设置学校为家长设置的备注手机号码列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("remark_mobiles")]
                        [System.Text.Json.Serialization.JsonPropertyName("remark_mobiles")]
                        public string[]? RemarkMobileNumberList { get; set; }
                    }

                    public class ExternalProfile : CgibinUserGetResponse.Types.ExternalProfile
                    { 
                    }
                }

                /// <summary>
                /// 获取或设置外部联系人账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("external_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("external_userid")]
                public string ExternalUserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置外部联系人名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置由企业或服务商在导入家长时指定的关键字。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("foreign_key")]
                [System.Text.Json.Serialization.JsonPropertyName("foreign_key")]
                public string? ForeignKey { get; set; }

                /// <summary>
                /// 获取或设置外部联系人 UnionId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("unionid")]
                [System.Text.Json.Serialization.JsonPropertyName("unionid")]
                public string? UnionId { get; set; }

                /// <summary>
                /// 获取或设置头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("avatar")]
                [System.Text.Json.Serialization.JsonPropertyName("avatar")]
                public string? AvatarUrl { get; set; }

                /// <summary>
                /// 获取或设置联系人类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public int Type { get; set; }

                /// <summary>
                /// 获取或设置性别。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("gender")]
                [System.Text.Json.Serialization.JsonPropertyName("gender")]
                public int Gender { get; set; }

                /// <summary>
                /// 获取或设置职位。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("position")]
                [System.Text.Json.Serialization.JsonPropertyName("position")]
                public string? Position { get; set; }

                /// <summary>
                /// 获取或设置所在企业简称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("corp_name")]
                [System.Text.Json.Serialization.JsonPropertyName("corp_name")]
                public string? CorpName { get; set; }

                /// <summary>
                /// 获取或设置所在企业全称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("corp_full_name")]
                [System.Text.Json.Serialization.JsonPropertyName("corp_full_name")]
                public string? CorpFullName { get; set; }

                /// <summary>
                /// 获取或设置是否关注了“学校通知”。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_subscribe")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("is_subscribe")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
                public bool? IsSubscribe { get; set; }

                /// <summary>
                /// 获取或设置学校为家长设置的信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("subscriber_info")]
                [System.Text.Json.Serialization.JsonPropertyName("subscriber_info")]
                public Types.Subscriber? Subscriber { get; set; }

                /// <summary>
                /// 获取或设置对外属性信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("external_profile")]
                [System.Text.Json.Serialization.JsonPropertyName("external_profile")]
                public Types.ExternalProfile? ExternalProfile { get; set; }
            }

            public class FollowUser
            {
                public static class Types
                {
                    public class Tag
                    {
                        /// <summary>
                        /// 获取或设置该成员添加外部联系人所打标签类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public int Type { get; set; }

                        /// <summary>
                        /// 获取或设置该成员添加外部联系人所打企业标签 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tag_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("tag_id")]
                        public string? TagId { get; set; }

                        /// <summary>
                        /// 获取或设置该成员添加外部联系人所打企业标签名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tag_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("tag_name")]
                        public string? TagName { get; set; }

                        /// <summary>
                        /// 获取或设置该成员添加外部联系人所打企业标签分组名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("group_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("group_name")]
                        public string? TagGroupName { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string UserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置该成员对外部联系人的备注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remark")]
                [System.Text.Json.Serialization.JsonPropertyName("remark")]
                public string Remark { get; set; } = default!;

                /// <summary>
                /// 获取或设置该成员对外部联系人的备注企业名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remark_corp_name")]
                [System.Text.Json.Serialization.JsonPropertyName("remark_corp_name")]
                public string? RemarkCorpName { get; set; }

                /// <summary>
                /// 获取或设置该成员对外部联系人的备注手机号码列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remark_mobiles")]
                [System.Text.Json.Serialization.JsonPropertyName("remark_mobiles")]
                public string[]? RemarkMobileNumberList { get; set; }

                /// <summary>
                /// 获取或设置该成员对外部联系人的描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string Description { get; set; } = default!;

                /// <summary>
                /// 获取或设置该成员添加外部联系人所打企业标签列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tags")]
                [System.Text.Json.Serialization.JsonPropertyName("tags")]
                public Types.Tag[]? Tags { get; set; }

                /// <summary>
                /// 获取或设置该成员添加外部联系人的来源。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("add_way")]
                [System.Text.Json.Serialization.JsonPropertyName("add_way")]
                public int AddWay { get; set; }

                /// <summary>
                /// 获取或设置该成员添加外部联系人的时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("createtime")]
                [System.Text.Json.Serialization.JsonPropertyName("createtime")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置企业自定义渠道参数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("state")]
                [System.Text.Json.Serialization.JsonPropertyName("state")]
                public string? State { get; set; }

                /// <summary>
                /// 获取或设置发起添加的成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("oper_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("oper_userid")]
                public string? OperateUserId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置外部联系人信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("external_contact")]
        [System.Text.Json.Serialization.JsonPropertyName("external_contact")]
        public Types.ExternalContact ExternalContact { get; set; } = default!;

        /// <summary>
        /// 获取或设置添加了此外部联系人的企业成员列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("follow_user")]
        [System.Text.Json.Serialization.JsonPropertyName("follow_user")]
        public Types.FollowUser[] FollowUserList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
