using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/groupchat/statistic 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactGroupChatStatisticResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Statistic
                    {
                        /// <summary>
                        /// 获取或设置新增客户群数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("new_chat_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("new_chat_cnt")]
                        public int NewChatCount { get; set; }

                        /// <summary>
                        /// 获取或设置客户群总数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("chat_total")]
                        [System.Text.Json.Serialization.JsonPropertyName("chat_total")]
                        public int ChatTotalCount { get; set; }

                        /// <summary>
                        /// 获取或设置有发过消息的客户群数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("chat_has_msg")]
                        [System.Text.Json.Serialization.JsonPropertyName("chat_has_msg")]
                        public int ChatHasMessageCount { get; set; }

                        /// <summary>
                        /// 获取或设置客户群新增群人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("new_member_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("new_member_cnt")]
                        public int NewMemberCount { get; set; }

                        /// <summary>
                        /// 获取或设置客户群总人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("member_total")]
                        [System.Text.Json.Serialization.JsonPropertyName("member_total")]
                        public int MemberTotalCount { get; set; }

                        /// <summary>
                        /// 获取或设置有发过消息的群成员数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("member_has_msg")]
                        [System.Text.Json.Serialization.JsonPropertyName("member_has_msg")]
                        public int MemberHasMessageCount { get; set; }

                        /// <summary>
                        /// 获取或设置客户群消息总数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("msg_total")]
                        [System.Text.Json.Serialization.JsonPropertyName("msg_total")]
                        public int MessageTotalCount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置群主成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("owner")]
                [System.Text.Json.Serialization.JsonPropertyName("owner")]
                public string OwnerUserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置统计数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("data")]
                [System.Text.Json.Serialization.JsonPropertyName("data")]
                public Types.Statistic Statistic { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("items")]
        [System.Text.Json.Serialization.JsonPropertyName("items")]
        public Types.Data[] DataList { get; set; } = default!;

        /// <summary>
        /// 获取或设置数据总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total")]
        [System.Text.Json.Serialization.JsonPropertyName("total")]
        public int Total { get; set; }

        /// <summary>
        /// 获取或设置下一页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_offset")]
        [System.Text.Json.Serialization.JsonPropertyName("next_offset")]
        public int? NextOffset { get; set; }
    }
}
