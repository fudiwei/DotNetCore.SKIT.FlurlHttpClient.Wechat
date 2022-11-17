namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /businesscircle/users/{openid}/points/commit_status 接口的响应。</para>
    /// </summary>
    public class GetBusinessCircleUserPointsCommitStatusByOpenIdResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置商圈会员待积分状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("points_commit_status")]
        [System.Text.Json.Serialization.JsonPropertyName("points_commit_status")]
        public string PointsCommitStatus { get; set; } = default!;
    }
}
