using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/corpgroup/import_chain_contact 接口的请求。</para>
    /// </summary>
    public class CgibinCorpGroupImportChainContactRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class ChainContact
            {
                public static class Types
                {
                    public class Contact
                    {
                        /// <summary>
                        /// 获取或设置联系人姓名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置联系人身份类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("identity_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("identity_type")]
                        public int IdentityType { get; set; }

                        /// <summary>
                        /// 获取或设置联系人手机号码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mobile")]
                        [System.Text.Json.Serialization.JsonPropertyName("mobile")]
                        public string? MobileNumber { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置企业名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("corp_name")]
                [System.Text.Json.Serialization.JsonPropertyName("corp_name")]
                public string CorpName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置导入后企业所在分组。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("group_path")]
                [System.Text.Json.Serialization.JsonPropertyName("group_path")]
                public string? GroupPath { get; set; }

                /// <summary>
                /// 获取或设置自定义 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("custom_id")]
                [System.Text.Json.Serialization.JsonPropertyName("custom_id")]
                public string? CustomId { get; set; }

                /// <summary>
                /// 获取或设置联系人列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact_info_list")]
                [System.Text.Json.Serialization.JsonPropertyName("contact_info_list")]
                public IList<Types.Contact> ContactList { get; set; } = new List<Types.Contact>();
            }
        }

        /// <summary>
        /// 获取或设置上下游 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chain_id")]
        [System.Text.Json.Serialization.JsonPropertyName("chain_id")]
        public string ChainId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置联系人列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contact_list")]
        [System.Text.Json.Serialization.JsonPropertyName("contact_list")]
        public IList<Types.ChainContact> ChainContactList { get; set; } = new List<Types.ChainContact>();
    }
}
