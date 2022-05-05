namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/kf/servicer/list 接口的响应。</para>
    /// </summary>
    public class CgibinKfServicerListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Servicer
            {
                /// <summary>
                /// 获取或设置接待人员的 UserId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string? UserId { get; set; }

                /// <summary>
                /// 获取或设置接待状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int? Status { get; set; }

                /// <summary>
                /// 获取或设置接待人员的部门 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("department_id")]
                [System.Text.Json.Serialization.JsonPropertyName("department_id")]
                public long? DepartmentId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置接待人员列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("servicer_list")]
        [System.Text.Json.Serialization.JsonPropertyName("servicer_list")]
        public Types.Servicer[] ServicerList { get; set; } = default!;
    }
}
