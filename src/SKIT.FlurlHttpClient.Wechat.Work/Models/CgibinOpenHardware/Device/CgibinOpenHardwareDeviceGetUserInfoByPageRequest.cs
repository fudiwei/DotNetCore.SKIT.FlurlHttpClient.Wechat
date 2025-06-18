namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/openhw/device/get_userinfo_by_page 接口的请求。</para>
    /// </summary>
    public class CgibinOpenHardwareDeviceGetUserInfoByPageRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置是否仅获取云端通讯录版本号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("only_perm_version")]
        [System.Text.Json.Serialization.JsonPropertyName("only_perm_version")]
        public bool? RequireOnlyPermVersion { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }
    }
}
