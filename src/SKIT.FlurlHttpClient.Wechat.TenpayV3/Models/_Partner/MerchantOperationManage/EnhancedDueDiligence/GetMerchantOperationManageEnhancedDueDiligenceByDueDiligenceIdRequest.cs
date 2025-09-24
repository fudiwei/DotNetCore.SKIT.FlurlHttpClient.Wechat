namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /mch-operation-manage/enhanced-due-diligence/{due_diligence_id} 接口的请求。</para>
    /// </summary>
    public class GetMerchantOperationManageEnhancedDueDiligenceByDueDiligenceIdRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置尽调单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string DueDiligenceId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string SubMerchantId { get; set; } = string.Empty;
    }
}
