namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/batch/get_by_user 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactBatchGetByUserResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class ExternalContactUser
            {
                public static class Types
                {
                    public class ExternalContact : CgibinExternalContactGetResponse.Types.ExternalContact
                    {
                    }

                    public class FollowUser
                    {
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
                        public string? RemarkCompany { get; set; }

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
                        /// 获取或设置该成员添加外部联系人所打企业标签 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tag_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("tag_id")]
                        public string[] TagIdList { get; set; } = default!;

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
                /// 获取或设置添加了此外部联系人的企业成员信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("follow_info")]
                [System.Text.Json.Serialization.JsonPropertyName("follow_info")]
                public Types.FollowUser FollowUser { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置外部联系人列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("external_contact_list")]
        [System.Text.Json.Serialization.JsonPropertyName("external_contact_list")]
        public Types.ExternalContactUser[] ExternalContactList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
