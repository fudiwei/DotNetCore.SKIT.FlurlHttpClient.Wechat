namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /apply4subject/applyment 接口的请求。</para>
    /// </summary>
    public class GetApplyForSubjectApplymentByApplymentIdRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置微信支付申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long ApplymentId { get; set; }
    }
}
