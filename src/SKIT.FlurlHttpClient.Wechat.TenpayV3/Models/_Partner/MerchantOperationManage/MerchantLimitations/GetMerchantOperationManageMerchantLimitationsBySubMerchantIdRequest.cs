namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /mch-operation-manage/merchant-limitations/sub-mchid/{sub_mchid} 接口的请求。</para>
    /// </summary>
    public class GetMerchantOperationManageMerchantLimitationsBySubMerchantIdRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string SubMerchantId { get; set; } = string.Empty;
    }
}
