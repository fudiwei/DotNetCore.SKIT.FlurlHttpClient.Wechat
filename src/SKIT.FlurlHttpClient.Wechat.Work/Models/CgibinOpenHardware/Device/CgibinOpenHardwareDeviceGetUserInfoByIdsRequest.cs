using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/openhw/device/get_userinfo_by_ids 接口的请求。</para>
    /// </summary>
    public class CgibinOpenHardwareDeviceGetUserInfoByIdsRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class User
            {
                /// <summary>
                /// 获取或设置成员的 OpenUserId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("open_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("open_userid")]
                public string OpenUserId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置成员类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_type")]
                [System.Text.Json.Serialization.JsonPropertyName("user_type")]
                public int UserType { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置成员列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_item")]
        [System.Text.Json.Serialization.JsonPropertyName("user_item")]
        public IList<Types.User> Items { get; set; } = new List<Types.User>();
    }
}
