namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /rate-activity/applications/id/{application_id} 接口的请求。</para>
    /// </summary>
    public class GetRateActivityApplicationByApplicationIdRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置申请单编号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ApplicationId { get; set; } = string.Empty;
    }
}
