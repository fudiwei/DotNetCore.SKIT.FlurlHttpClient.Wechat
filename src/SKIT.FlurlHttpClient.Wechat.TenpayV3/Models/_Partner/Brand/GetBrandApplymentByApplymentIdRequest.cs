namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /brand/applyments/applyment-id/{applyment_id} 接口的请求。</para>
    /// </summary>
    public class GetBrandApplymentByApplymentIdRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置申请单编号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ApplymentId { get; set; } = string.Empty;
    }
}
