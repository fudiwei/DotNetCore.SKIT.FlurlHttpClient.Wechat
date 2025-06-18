namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global.Models
{
    /// <summary>
    /// <para>表示 [GET] /merchant/h5/permission/domain/applications/{applyment_id} 接口的请求。</para>
    /// </summary>
    public class GetMerchantH5PermissionDomainApplicationByApplymentIdRequest : WechatTenpayGlobalRequest
    {
        /// <summary>
        /// 获取或设置申请单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long ApplymentId { get; set; }
    }
}
