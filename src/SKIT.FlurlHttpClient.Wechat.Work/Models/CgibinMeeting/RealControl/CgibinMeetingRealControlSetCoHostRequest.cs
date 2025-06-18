namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/realcontrol/set_cohost 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingRealControlSetCoHostRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class OperatedUser
            {
                /// <summary>
                /// 获取或设置参与者临时 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tmp_openid")]
                [System.Text.Json.Serialization.JsonPropertyName("tmp_openid")]
                public string TempOpenId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置终端设备类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("instance_id")]
                [System.Text.Json.Serialization.JsonPropertyName("instance_id")]
                public int InstanceId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        public string MeetingId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否设置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action")]
        [System.Text.Json.Serialization.JsonPropertyName("action")]
        public bool ActionState { get; set; }

        /// <summary>
        /// 获取或设置被操作成员信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operated_user")]
        [System.Text.Json.Serialization.JsonPropertyName("operated_user")]
        public Types.OperatedUser OperatedUser { get; set; } = new Types.OperatedUser();
    }
}
