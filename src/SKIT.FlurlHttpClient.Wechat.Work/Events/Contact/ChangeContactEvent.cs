namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.change_contact 或 INFO.change_contact 事件的数据。</para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90970 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90971 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90972 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90240 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/92654 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/92655 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/92656 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90639 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90640 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90641 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90376 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90796 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90797 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90798 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90858 </para>
    /// </summary>
    public class ChangeContactEvent : WechatWorkEvent, WechatWorkEvent.Serialization.IXmlSerializable
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
                        [System.Xml.Serialization.XmlElement("Type")]
                        public int Type { get; set; }

                        /// <summary>
                        /// 获取或设置属性名称。
                        /// </summary>
                        [System.Xml.Serialization.XmlElement("Name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置文本属性值。
                        /// </summary>
                        [System.Xml.Serialization.XmlElement("Text", IsNullable = true)]
                        public TextAttribute? Text { get; set; }

                        /// <summary>
                        /// 获取或设置网页属性值。
                        /// </summary>
                        [System.Xml.Serialization.XmlElement("Web", IsNullable = true)]
                        public WebAttribute? Web { get; set; }
                    }

                    public class TextAttribute
                    {
                        /// <summary>
                        /// 获取或设置文本内容。
                        /// </summary>
                        [System.Xml.Serialization.XmlElement("Value")]
                        public string Value { get; set; } = default!;
                    }

                    public class WebAttribute
                    {
                        /// <summary>
                        /// 获取或设置网页标题。
                        /// </summary>
                        [System.Xml.Serialization.XmlElement("Title")]
                        public string Title { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置网页 URL。
                        /// </summary>
                        [System.Xml.Serialization.XmlElement("Url")]
                        public string Url { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置自定义字段列表。
                /// </summary>
                [System.Xml.Serialization.XmlArrayItem("Item", Type = typeof(Types.Attribute))]
                public Types.Attribute[] AttributeList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置第三方应用的 SuiteId。
        /// </summary>
        [System.Xml.Serialization.XmlElement("SuiteId", IsNullable = true)]
        public string? SuiteId { get; set; }

        /// <summary>
        /// 获取或设置授权方的 CorpId。
        /// </summary>
        [System.Xml.Serialization.XmlElement("AuthCorpId", IsNullable = true)]
        public string? AuthorizerCorpId { get; set; }

        /// <summary>
        /// 获取或设置操作类型。
        /// </summary>
        [System.Xml.Serialization.XmlElement("ChangeType")]
        public string ActionType { get; set; } = default!;

        /// <summary>
        /// 获取或设置成员、部门或标签名称。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户成员账号。
        /// </summary>
        [System.Xml.Serialization.XmlElement("UserID", IsNullable = true)]
        public string? UserId { get; set; }

        /// <summary>
        /// 获取或设置新的用户成员账号。
        /// </summary>
        [System.Xml.Serialization.XmlElement("NewUserID", IsNullable = true)]
        public string? NewUserId { get; set; }

        /// <summary>
        /// 获取或设置用户成员别名。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Alias", IsNullable = true)]
        public string? UserAlias { get; set; }

        /// <summary>
        /// 获取或设置用户所在部门 ID（以逗号分割）。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Department", IsNullable = true)]
        public string? UserDepartmentIds { get; set; }

        /// <summary>
        /// 获取或设置用户的部门领导状态（以逗号分割）。
        /// </summary>
        [System.Xml.Serialization.XmlElement("IsLeaderInDept", IsNullable = true)]
        public string? UserDepartmentLeaderStatus { get; set; }

        /// <summary>
        /// 获取或设置用户的主部门 ID。
        /// </summary>
        [System.Xml.Serialization.XmlElement("MainDepartment", IsNullable = true)]
        public int? UserMainDepartmentId { get; set; }

        /// <summary>
        /// 获取或设置用户邮箱。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Email", IsNullable = true)]
        public string? UserEmail { get; set; }

        /// <summary>
        /// 获取或设置用户企业邮箱。
        /// </summary>
        [System.Xml.Serialization.XmlElement("BizMail", IsNullable = true)]
        public string? UserBusinessEmail { get; set; }

        /// <summary>
        /// 获取或设置用户手机号码。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Mobile", IsNullable = true)]
        public string? UserMobileNumber { get; set; }

        /// <summary>
        /// 获取或设置用户座机号码。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Telephone", IsNullable = true)]
        public string? UserTeleNumber { get; set; }

        /// <summary>
        /// 获取或设置用户性别。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Gender", IsNullable = true)]
        public int? UserGender { get; set; }

        /// <summary>
        /// 获取或设置用户地址。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Address", IsNullable = true)]
        public string? UserAddress { get; set; }

        /// <summary>
        /// 获取或设置用户职务。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Position", IsNullable = true)]
        public string? UserPosition { get; set; }

        /// <summary>
        /// 获取或设置用户头像 URL。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Avatar", IsNullable = true)]
        public string? UserAvatarUrl { get; set; }

        /// <summary>
        /// 获取或设置用户激活状态。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Status", IsNullable = true)]
        public int? UserStatus { get; set; }

        /// <summary>
        /// 获取或设置用户自定义字段信息。
        /// </summary>
        [System.Xml.Serialization.XmlElement("ExtAttr", IsNullable = true)]
        public Types.ExtendedAttribute? UserExtendedAttribute { get; set; }

        /// <summary>
        /// 获取或设置部门 ID。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Id", IsNullable = true)]
        public int? DepartmentId { get; set; }

        /// <summary>
        /// 获取或设置上级部门 ID。
        /// </summary>
        [System.Xml.Serialization.XmlElement("ParentId", IsNullable = true)]
        public string? DepartmentParentId { get; set; }

        /// <summary>
        /// 获取或设置部门次序值。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Order", IsNullable = true)]
        public long? DepartmentOrder { get; set; }

        /// <summary>
        /// 获取或设置标签 ID。
        /// </summary>
        [System.Xml.Serialization.XmlElement("TagId", IsNullable = true)]
        public int? TagId { get; set; }

        /// <summary>
        /// 获取或设置标签中新增的成员账号（以逗号分隔）。
        /// </summary>
        [System.Xml.Serialization.XmlElement("AddUserItems", IsNullable = true)]
        public string? TagAddedUserIds { get; set; }

        /// <summary>
        /// 获取或设置标签中删除的成员账号（以逗号分隔）。
        /// </summary>
        [System.Xml.Serialization.XmlElement("DelUserItems", IsNullable = true)]
        public string? TagRemovedUserIds { get; set; }

        /// <summary>
        /// 获取或设置标签中新增的部门 ID（以逗号分隔）。
        /// </summary>
        [System.Xml.Serialization.XmlElement("AddPartyItems", IsNullable = true)]
        public string? TagAddedDepartmentIds { get; set; }

        /// <summary>
        /// 获取或设置标签中删除的部门 ID（以逗号分隔）。
        /// </summary>
        [System.Xml.Serialization.XmlElement("DelPartyItems", IsNullable = true)]
        public string? TagRemovedDepartmentIds { get; set; }
    }
}
