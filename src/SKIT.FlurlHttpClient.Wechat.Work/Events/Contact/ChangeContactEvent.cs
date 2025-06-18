using System;

namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.change_contact 或 INFO.change_contact 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90970 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90971 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90972 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90240 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/92654 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/92655 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/92656 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90639 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90640 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90641 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90376 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90796 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90797 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90798 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90858 ]]>
    /// </para>
    /// </summary>
    public class ChangeContactEvent : WechatWorkEvent
    {
        public static class Types
        {
            public class ExtendedAttribute
            {
                public static class Types
                {
                    public class Attribute
                    {
                        /// <summary>
                        /// 获取或设置属性类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("Type")]
                        [System.Text.Json.Serialization.JsonPropertyName("Type")]
                        [System.Xml.Serialization.XmlElement("Type")]
                        public int Type { get; set; }

                        /// <summary>
                        /// 获取或设置属性名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("Name")]
                        [System.Text.Json.Serialization.JsonPropertyName("Name")]
                        [System.Xml.Serialization.XmlElement("Name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置文本属性值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("Text")]
                        [System.Text.Json.Serialization.JsonPropertyName("Text")]
                        [System.Xml.Serialization.XmlElement("Text", IsNullable = true)]
                        public TextAttribute? Text { get; set; }

                        /// <summary>
                        /// 获取或设置网页属性值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("Web")]
                        [System.Text.Json.Serialization.JsonPropertyName("Web")]
                        [System.Xml.Serialization.XmlElement("Web", IsNullable = true)]
                        public WebAttribute? Web { get; set; }
                    }

                    public class TextAttribute
                    {
                        /// <summary>
                        /// 获取或设置文本内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("Value")]
                        [System.Text.Json.Serialization.JsonPropertyName("Value")]
                        [System.Xml.Serialization.XmlElement("Value")]
                        public string Value { get; set; } = default!;
                    }

                    public class WebAttribute
                    {
                        /// <summary>
                        /// 获取或设置网页标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("Title")]
                        [System.Text.Json.Serialization.JsonPropertyName("Title")]
                        [System.Xml.Serialization.XmlElement("Title")]
                        public string Title { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置网页 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("Url")]
                        [System.Text.Json.Serialization.JsonPropertyName("Url")]
                        [System.Xml.Serialization.XmlElement("Url")]
                        public string Url { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置自定义字段列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Item")]
                [System.Text.Json.Serialization.JsonPropertyName("Item")]
                [System.Xml.Serialization.XmlElement("Item", Type = typeof(Types.Attribute))]
                public Types.Attribute[] AttributeList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置第三方应用的 SuiteId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("SuiteId")]
        [System.Text.Json.Serialization.JsonPropertyName("SuiteId")]
        [System.Xml.Serialization.XmlElement("SuiteId", IsNullable = true)]
        public string? SuiteId { get; set; }

        /// <summary>
        /// 获取或设置授权方的 CorpId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AuthCorpId")]
        [System.Text.Json.Serialization.JsonPropertyName("AuthCorpId")]
        [System.Xml.Serialization.XmlElement("AuthCorpId", IsNullable = true)]
        public string? AuthorizerCorpId { get; set; }

        /// <summary>
        /// 获取或设置变更类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ChangeType")]
        [System.Text.Json.Serialization.JsonPropertyName("ChangeType")]
        [System.Xml.Serialization.XmlElement("ChangeType")]
        public string ChangeType { get; set; } = default!;

        /// <summary>
        /// 获取或设置成员、部门或标签名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Name")]
        [System.Text.Json.Serialization.JsonPropertyName("Name")]
        [System.Xml.Serialization.XmlElement("Name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("UserID")]
        [System.Text.Json.Serialization.JsonPropertyName("UserID")]
        [System.Xml.Serialization.XmlElement("UserID", IsNullable = true)]
        public string? UserId { get; set; }

        /// <summary>
        /// 获取或设置新的用户成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("NewUserID")]
        [System.Text.Json.Serialization.JsonPropertyName("NewUserID")]
        [System.Xml.Serialization.XmlElement("NewUserID", IsNullable = true)]
        public string? NewUserId { get; set; }

        /// <summary>
        /// 获取或设置用户成员别名。
        /// </summary>
        [Obsolete("相关接口或字段于 2022-08-15 下线。")]
        [Newtonsoft.Json.JsonProperty("Alias")]
        [System.Text.Json.Serialization.JsonPropertyName("Alias")]
        [System.Xml.Serialization.XmlElement("Alias", IsNullable = true)]
        public string? UserAlias { get; set; }

        /// <summary>
        /// 获取或设置用户所在部门 ID（以逗号分割）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Department")]
        [System.Text.Json.Serialization.JsonPropertyName("Department")]
        [System.Xml.Serialization.XmlElement("Department", IsNullable = true)]
        public string? UserDepartmentIds { get; set; }

        /// <summary>
        /// 获取或设置用户的部门领导状态（以逗号分割）。
        /// </summary>
        [Obsolete("相关接口或字段于 2022-08-15 下线。")]
        [Newtonsoft.Json.JsonProperty("IsLeaderInDept")]
        [System.Text.Json.Serialization.JsonPropertyName("IsLeaderInDept")]
        [System.Xml.Serialization.XmlElement("IsLeaderInDept", IsNullable = true)]
        public string? UserDepartmentLeaderStatus { get; set; }

        /// <summary>
        /// 获取或设置用户的主部门 ID。
        /// </summary>
        [Obsolete("相关接口或字段于 2022-08-15 下线。")]
        [Newtonsoft.Json.JsonProperty("MainDepartment")]
        [System.Text.Json.Serialization.JsonPropertyName("MainDepartment")]
        [System.Xml.Serialization.XmlElement("MainDepartment", IsNullable = true)]
        public long? UserMainDepartmentId { get; set; }

        /// <summary>
        /// 获取或设置用户邮箱。
        /// </summary>
        [Obsolete("相关接口或字段于 2022-08-15 下线。")]
        [Newtonsoft.Json.JsonProperty("Email")]
        [System.Text.Json.Serialization.JsonPropertyName("Email")]
        [System.Xml.Serialization.XmlElement("Email", IsNullable = true)]
        public string? UserEmail { get; set; }

        /// <summary>
        /// 获取或设置用户企业邮箱。
        /// </summary>
        [Obsolete("相关接口或字段于 2022-08-15 下线。")]
        [Newtonsoft.Json.JsonProperty("BizMail")]
        [System.Text.Json.Serialization.JsonPropertyName("BizMail")]
        [System.Xml.Serialization.XmlElement("BizMail", IsNullable = true)]
        public string? UserBusinessEmail { get; set; }

        /// <summary>
        /// 获取或设置用户手机号码。
        /// </summary>
        [Obsolete("相关接口或字段于 2022-08-15 下线。")]
        [Newtonsoft.Json.JsonProperty("Mobile")]
        [System.Text.Json.Serialization.JsonPropertyName("Mobile")]
        [System.Xml.Serialization.XmlElement("Mobile", IsNullable = true)]
        public string? UserMobileNumber { get; set; }

        /// <summary>
        /// 获取或设置用户座机号码。
        /// </summary>
        [Obsolete("相关接口或字段于 2022-08-15 下线。")]
        [Newtonsoft.Json.JsonProperty("Telephone")]
        [System.Text.Json.Serialization.JsonPropertyName("Telephone")]
        [System.Xml.Serialization.XmlElement("Telephone", IsNullable = true)]
        public string? UserTeleNumber { get; set; }

        /// <summary>
        /// 获取或设置用户性别。
        /// </summary>
        [Obsolete("相关接口或字段于 2022-08-15 下线。")]
        [Newtonsoft.Json.JsonProperty("Gender")]
        [System.Text.Json.Serialization.JsonPropertyName("Gender")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
        [System.Xml.Serialization.XmlElement("Gender", IsNullable = true)]
        public int? UserGender { get; set; }

        /// <summary>
        /// 获取或设置用户地址。
        /// </summary>
        [Obsolete("相关接口或字段于 2022-08-15 下线。")]
        [Newtonsoft.Json.JsonProperty("Address")]
        [System.Text.Json.Serialization.JsonPropertyName("Address")]
        [System.Xml.Serialization.XmlElement("Address", IsNullable = true)]
        public string? UserAddress { get; set; }

        /// <summary>
        /// 获取或设置用户职务。
        /// </summary>
        [Obsolete("相关接口或字段于 2022-08-15 下线。")]
        [Newtonsoft.Json.JsonProperty("Position")]
        [System.Text.Json.Serialization.JsonPropertyName("Position")]
        [System.Xml.Serialization.XmlElement("Position", IsNullable = true)]
        public string? UserPosition { get; set; }

        /// <summary>
        /// 获取或设置用户头像 URL。
        /// </summary>
        [Obsolete("相关接口或字段于 2022-08-15 下线。")]
        [Newtonsoft.Json.JsonProperty("Avatar")]
        [System.Text.Json.Serialization.JsonPropertyName("Avatar")]
        [System.Xml.Serialization.XmlElement("Avatar", IsNullable = true)]
        public string? UserAvatarUrl { get; set; }

        /// <summary>
        /// 获取或设置用户激活状态。
        /// </summary>
        [Obsolete("相关接口或字段于 2022-08-15 下线。")]
        [Newtonsoft.Json.JsonProperty("Status")]
        [System.Text.Json.Serialization.JsonPropertyName("Status")]
        [System.Xml.Serialization.XmlElement("Status", IsNullable = true)]
        public int? UserStatus { get; set; }

        /// <summary>
        /// 获取或设置用户自定义字段信息。
        /// </summary>
        [Obsolete("相关接口或字段于 2022-08-15 下线。")]
        [Newtonsoft.Json.JsonProperty("ExtAttr")]
        [System.Text.Json.Serialization.JsonPropertyName("ExtAttr")]
        [System.Xml.Serialization.XmlElement("ExtAttr", IsNullable = true)]
        public Types.ExtendedAttribute? UserExtendedAttribute { get; set; }

        /// <summary>
        /// 获取或设置部门 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Id")]
        [System.Text.Json.Serialization.JsonPropertyName("Id")]
        [System.Xml.Serialization.XmlElement("Id", IsNullable = true)]
        public long? DepartmentId { get; set; }

        /// <summary>
        /// 获取或设置上级部门 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ParentId")]
        [System.Text.Json.Serialization.JsonPropertyName("ParentId")]
        [System.Xml.Serialization.XmlElement("ParentId", IsNullable = true)]
        public string? DepartmentParentId { get; set; }

        /// <summary>
        /// 获取或设置部门次序值。
        /// </summary>
        [Obsolete("相关接口或字段于 2022-08-15 下线。")]
        [Newtonsoft.Json.JsonProperty("Order")]
        [System.Text.Json.Serialization.JsonPropertyName("Order")]
        [System.Xml.Serialization.XmlElement("Order", IsNullable = true)]
        public long? DepartmentOrder { get; set; }

        /// <summary>
        /// 获取或设置标签 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("TagId")]
        [System.Text.Json.Serialization.JsonPropertyName("TagId")]
        [System.Xml.Serialization.XmlElement("TagId", IsNullable = true)]
        public int? TagId { get; set; }

        /// <summary>
        /// 获取或设置标签中新增的成员账号（以逗号分隔）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AddUserItems")]
        [System.Text.Json.Serialization.JsonPropertyName("AddUserItems")]
        [System.Xml.Serialization.XmlElement("AddUserItems", IsNullable = true)]
        public string? TagAddedUserIds { get; set; }

        /// <summary>
        /// 获取或设置标签中删除的成员账号（以逗号分隔）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("DelUserItems")]
        [System.Text.Json.Serialization.JsonPropertyName("DelUserItems")]
        [System.Xml.Serialization.XmlElement("DelUserItems", IsNullable = true)]
        public string? TagRemovedUserIds { get; set; }

        /// <summary>
        /// 获取或设置标签中新增的部门 ID（以逗号分隔）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AddPartyItems")]
        [System.Text.Json.Serialization.JsonPropertyName("AddPartyItems")]
        [System.Xml.Serialization.XmlElement("AddPartyItems", IsNullable = true)]
        public string? TagAddedDepartmentIds { get; set; }

        /// <summary>
        /// 获取或设置标签中删除的部门 ID（以逗号分隔）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("DelPartyItems")]
        [System.Text.Json.Serialization.JsonPropertyName("DelPartyItems")]
        [System.Xml.Serialization.XmlElement("DelPartyItems", IsNullable = true)]
        public string? TagRemovedDepartmentIds { get; set; }
    }
}
