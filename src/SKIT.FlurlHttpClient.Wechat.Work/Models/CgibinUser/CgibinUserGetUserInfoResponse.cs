using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/user/getuserinfo 接口的响应。</para>
    /// </summary>
    public class CgibinUserGetUserInfoResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Parent
            {
                /// <summary>
                /// 获取或设置家长所在学校的 CorpId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("corpid")]
                [System.Text.Json.Serialization.JsonPropertyName("corpid")]
                public string CorpId { get; set; } = default!;

                /// <summary>
                /// 获取或设置家长账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("parent_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("parent_userid")]
                public string ParentUserId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("UserId")]
        [System.Text.Json.Serialization.JsonPropertyName("UserId")]
        public string? UserId { get; set; }

        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("OpenId")]
        [System.Text.Json.Serialization.JsonPropertyName("OpenId")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置外部联系人 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("external_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("external_userid")]
        public string? ExternalUserId { get; set; }

        /// <summary>
        /// 获取或设置设备号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("DeviceId")]
        [System.Text.Json.Serialization.JsonPropertyName("DeviceId")]
        public string? DeviceId { get; set; }

        /// <summary>
        /// 获取或设置家长列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parents")]
        [System.Text.Json.Serialization.JsonPropertyName("parents")]
        public Types.Parent[]? ParentList { get; set; }
    }
}
