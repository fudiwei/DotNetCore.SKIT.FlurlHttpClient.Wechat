namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/msgaudit/get_robot_info 接口的响应。</para>
    /// </summary>
    public class CgibinMessageAuditGetRobotInfoResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Robot
            {
                /// <summary>
                /// 获取或设置机器人 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("robot_id")]
                [System.Text.Json.Serialization.JsonPropertyName("robot_id")]
                public string RobotId { get; set; } = default!;

                /// <summary>
                /// 获取或设置机器人名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置创建者的成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("creator_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("creator_userid")]
                public string CreatorUserId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置机器人信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Robot Robot { get; set; } = default!;
    }
}
