namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedrive/space_setting 接口的请求。</para>
    /// </summary>
    public class CgibinWebDriveSpaceSettingRequest : WechatWorkRequest
    {
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
        /// 获取或设置是否启用保密模式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enable_confidential_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("enable_confidential_mode")]
        public bool? EnableConfidentialMode { get; set; }

        /// <summary>
        /// 获取或设置是否通过链接加入空间无需审批。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("share_url_no_approve")]
        [System.Text.Json.Serialization.JsonPropertyName("share_url_no_approve")]
        public bool? IsShareUrlNoApprove { get; set; }

        /// <summary>
        /// 获取或设置邀请链接默认权限类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("share_url_no_approve_default_auth")]
        [System.Text.Json.Serialization.JsonPropertyName("share_url_no_approve_default_auth")]
        public int? ShareUrlNoApproveDefaultAuthType { get; set; }

        /// <summary>
        /// 获取或设置文件默认可查看范围。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("default_file_scope")]
        [System.Text.Json.Serialization.JsonPropertyName("default_file_scope")]
        public int? DefaultFileScope { get; set; }

        /// <summary>
        /// 获取或设置是否禁止文件分享到企业外。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ban_share_external")]
        [System.Text.Json.Serialization.JsonPropertyName("ban_share_external")]
        public bool? IsBanShareExternal { get; set; }
    }
}
