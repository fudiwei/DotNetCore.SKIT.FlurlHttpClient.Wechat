namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/checkin/update_checkin_option 接口的请求。</para>
    /// </summary>
    public class CgibinCheckinUpdateCheckinOptionRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class CheckinGroup : CgibinCheckinAddCheckinOptionRequest.Types.CheckinGroup
            {
                /// <summary>
                /// 获取或设置打卡规则 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("groupid")]
                [System.Text.Json.Serialization.JsonPropertyName("groupid")]
                public int GroupId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置是否立即生效。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("effective_now")]
        [System.Text.Json.Serialization.JsonPropertyName("effective_now")]
        public bool? IsEffectiveNow { get; set; }

        /// <summary>
        /// 获取或设置打卡规则信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group")]
        [System.Text.Json.Serialization.JsonPropertyName("group")]
        public Types.CheckinGroup CheckinGroup { get; set; } = new Types.CheckinGroup();
    }
}
