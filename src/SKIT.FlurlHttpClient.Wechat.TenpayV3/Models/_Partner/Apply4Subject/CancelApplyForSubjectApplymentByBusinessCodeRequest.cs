namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /apply4subject/applyment/{business_code}/cancel 接口的请求。</para>
    /// </summary>
    public class CancelApplyForSubjectApplymentByBusinessCodeRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置业务申请编号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string BusinessCode { get; set; } = string.Empty;
    }
}
