using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/chatdata/getagreestatus/single 接口的请求。</para>
    /// </summary>
    public class CgibinChatDataGetAgreeStatusSingleRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class User
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
        /// 获取或设置成员列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item")]
        [System.Text.Json.Serialization.JsonPropertyName("item")]
        public IList<Types.User> UserList { get; set; } = new List<Types.User>();
    }
}
