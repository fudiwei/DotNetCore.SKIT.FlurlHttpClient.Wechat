using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/groupchat/list 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactGroupChatListRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class OwnerFilter
            {
                /// <summary>
                /// 获取或设置群主成员账号列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid_list")]
                [System.Text.Json.Serialization.JsonPropertyName("userid_list")]
                public IList<string>? UserIdList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置指定跟进状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status_filter")]
        [System.Text.Json.Serialization.JsonPropertyName("status_filter")]
        public int? Status { get; set; }

        /// <summary>
        /// 获取或设置指定群主信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("owner_filter")]
        [System.Text.Json.Serialization.JsonPropertyName("owner_filter")]
        public Types.OwnerFilter? Owner { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int Limit { get; set; } = 10;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? NextCursor { get; set; }
    }
}
