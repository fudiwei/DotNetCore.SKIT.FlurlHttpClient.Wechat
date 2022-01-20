﻿using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedrive/file_acl_del 接口的请求。</para>
    /// </summary>
    public class CgibinWebDriveFileACLDeleteRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class UnauthorizedUser : CgibinWebDriveSpaceACLDeleteRequest.Types.UnauthorizedUser
            {
            }
        }

        /// <summary>
        /// 获取或设置操作者成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置文件 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fileid")]
        [System.Text.Json.Serialization.JsonPropertyName("fileid")]
        public string FileId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置文件解除授权成员列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_info")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_info")]
        public IList<Types.UnauthorizedUser> UnauthorizedUserList { get; set; } = new List<Types.UnauthorizedUser>();
    }
}
