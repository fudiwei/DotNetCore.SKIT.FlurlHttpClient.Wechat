using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedrive/space_setting 接口的请求。</para>
    /// </summary>
    public class CgibinWebDriveSpaceSettingRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置操作者成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置空间 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spaceid")]
        [System.Text.Json.Serialization.JsonPropertyName("spaceid")]
        public string SpaceId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否启用水印。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enable_watermark")]
        [System.Text.Json.Serialization.JsonPropertyName("enable_watermark")]
        public bool? EnableWatermark { get; set; }

        /// <summary>
        /// 获取或设置启用成员邀请链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enable_share_url")]
        [System.Text.Json.Serialization.JsonPropertyName("enable_share_url")]
        public bool? EnableShareUrl { get; set; }

        /// <summary>
        /// 获取或设置是否仅管理员可增减空间成员和修改文件分享设置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("add_member_only_admin")]
        [System.Text.Json.Serialization.JsonPropertyName("add_member_only_admin")]
        public bool? IsOnlyAdminCanAddMember { get; set; }

        /// <summary>
        /// 获取或设置是否通过链接加入空间无需审批。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("share_url_no_approve")]
        [System.Text.Json.Serialization.JsonPropertyName("share_url_no_approve")]
        public bool? IsShareUrlNoApprove { get; set; }

        /// <summary>
        /// 获取或设置邀请链接默认权限。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("share_url_no_approve_default_auth")]
        [System.Text.Json.Serialization.JsonPropertyName("share_url_no_approve_default_auth")]
        public int? ShareUrlNoApproveDefaultAuthority { get; set; }
    }
}
