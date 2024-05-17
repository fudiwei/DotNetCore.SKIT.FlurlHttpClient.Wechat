namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global.Models
{
    /// <summary>
    /// <para>表示 [PATCH] /merchant/h5/permission/domain/applications/{applyment_id} 接口的响应。</para>
    /// </summary>
    public class UpdateMerchantH5PermissionDomainApplicationResponse : GetMerchantH5PermissionDomainApplicationByApplymentIdResponse
    {
        /// <summary>
        /// 获取或设置申请单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ApplymentId { get; set; } = string.Empty;
    }
}
