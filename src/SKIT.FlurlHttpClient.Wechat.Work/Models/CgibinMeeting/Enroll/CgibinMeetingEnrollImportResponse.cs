namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/enroll/import 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingEnrollImportResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Enroll
            {
                /// <summary>
                /// 获取或设置报名 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enroll_id")]
                [System.Text.Json.Serialization.JsonPropertyName("enroll_id")]
                public string EnrollId { get; set; } = default!;

                /// <summary>
                /// 获取或设置成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string? UserId { get; set; }

                /// <summary>
                /// 获取或设置国家地区代码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("area")]
                [System.Text.Json.Serialization.JsonPropertyName("area")]
                public string? AreaCode { get; set; }

                /// <summary>
                /// 获取或设置电话号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("phone_number")]
                [System.Text.Json.Serialization.JsonPropertyName("phone_number")]
                public string? PhoneNumber { get; set; }

                /// <summary>
                /// 获取或设置昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nick_name")]
                [System.Text.Json.Serialization.JsonPropertyName("nick_name")]
                public string? Nickname { get; set; }

                /// <summary>
                /// 获取或设置报名码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enroll_code")]
                [System.Text.Json.Serialization.JsonPropertyName("enroll_code")]
                public string? EnrollCode { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置成功导入的报名信息条数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; }

        /// <summary>
        /// 获取或设置报名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enroll_list")]
        [System.Text.Json.Serialization.JsonPropertyName("enroll_list")]
        public Types.Enroll[] EnrollList { get; set; } = default!;
    }
}
