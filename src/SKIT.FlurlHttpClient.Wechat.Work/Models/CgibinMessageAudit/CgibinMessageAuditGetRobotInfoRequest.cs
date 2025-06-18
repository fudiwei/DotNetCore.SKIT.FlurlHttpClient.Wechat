namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/msgaudit/get_robot_info 接口的请求。</para>
    /// </summary>
    public class CgibinMessageAuditGetRobotInfoRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置机器人 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string RobotId { get; set; } = string.Empty;
    }
}
