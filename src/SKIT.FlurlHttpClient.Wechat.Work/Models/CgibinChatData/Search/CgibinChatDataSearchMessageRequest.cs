using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/chatdata/search_msg 接口的请求。</para>
    /// </summary>
    public class CgibinChatDataSearchMessageRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class ChatInfo
            {
                public static class Types
                {
                    public class IdInfo
                    {
                        /// <summary>
                        /// 获取或设置成员的密文 UserId。与字段 <see cref="ExteranalUserId"/> 二选一。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("open_userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("open_userid")]
                        public string? OpenUserId { get; set; }

                        /// <summary>
                        /// 获取或设置外部成员 UserId。与字段 <see cref="OpenUserId"/> 二选一。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("external_userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("external_userid")]
                        public string? ExteranalUserId { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置会话类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("chat_type")]
                [System.Text.Json.Serialization.JsonPropertyName("chat_type")]
                public int ChatType { get; set; }

                /// <summary>
                /// 获取或设置 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_list")]
                [System.Text.Json.Serialization.JsonPropertyName("id_list")]
                public IList<Types.IdInfo> IdList { get; set; } = new List<Types.IdInfo>();
            }
        }

        /// <summary>
        /// 获取或设置搜索词。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("query_word")]
        [System.Text.Json.Serialization.JsonPropertyName("query_word")]
        public string QueryWord { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置搜索的客户会话信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chat_info")]
        [System.Text.Json.Serialization.JsonPropertyName("chat_info")]
        public Types.ChatInfo? ChatInfo { get; set; }

        /// <summary>
        /// 获取或设置搜索会话范围的起始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_time")]
        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public long? StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置搜索会话范围的结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置分页游标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }
    }
}
