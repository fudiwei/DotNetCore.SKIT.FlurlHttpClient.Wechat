namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/vacation/getuservacationquota 接口的响应。</para>
    /// </summary>
    public class CgibinOAVacationGetUserVacationQuotaResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class VacationQuota
            {
                /// <summary>
                /// 获取或设置假期类型标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public int VacationId { get; set; }

                /// <summary>
                /// 获取或设置假期名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("vacationname")]
                [System.Text.Json.Serialization.JsonPropertyName("vacationname")]
                public string VacationName { get; set; } = default!;

                /// <summary>
                /// 获取或设置发放时长（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("assignduration")]
                [System.Text.Json.Serialization.JsonPropertyName("assignduration")]
                public int AssignDuration { get; set; }

                /// <summary>
                /// 获取或设置使用时长（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("usedduration")]
                [System.Text.Json.Serialization.JsonPropertyName("usedduration")]
                public int UsedDuration { get; set; }

                /// <summary>
                /// 获取或设置剩余时长（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("leftduration")]
                [System.Text.Json.Serialization.JsonPropertyName("leftduration")]
                public int LeftDuration { get; set; }

                /// <summary>
                /// 获取或设置假期的实际发放时长（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("real_assignduration")]
                [System.Text.Json.Serialization.JsonPropertyName("real_assignduration")]
                public int RealAssignDuration { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置假期余额列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lists")]
        [System.Text.Json.Serialization.JsonPropertyName("lists")]
        public Types.VacationQuota[] VacationQuotaList { get; set; } = default!;
    }
}
