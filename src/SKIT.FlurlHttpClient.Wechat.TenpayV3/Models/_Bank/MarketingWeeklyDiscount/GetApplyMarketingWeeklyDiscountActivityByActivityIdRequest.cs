namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /marketing/weekly-discount/activities/{activity_id} 接口的请求。</para>
    /// </summary>
    public class GetApplyMarketingWeeklyDiscountActivityByActivityIdRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置活动 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ActivityId { get; set; } = string.Empty;
    }
}
