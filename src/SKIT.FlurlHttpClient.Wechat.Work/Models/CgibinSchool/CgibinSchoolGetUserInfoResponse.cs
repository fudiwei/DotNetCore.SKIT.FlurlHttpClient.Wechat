namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/school/getuserinfo 接口的响应。</para>
    /// </summary>
    public class CgibinSchoolGetUserInfoResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置手机设备号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("DeviceId")]
        [System.Text.Json.Serialization.JsonPropertyName("DeviceId")]
        public string? DeviceId { get; set; }

        /// <summary>
        /// 获取或设置家长账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parent_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("parent_userid")]
        public string? ParentUserId{ get; set; }

        /// <summary>
        /// 获取或设置学生账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("student_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("student_userid")]
        public string? StudentUserId{ get; set; }
    }
}
