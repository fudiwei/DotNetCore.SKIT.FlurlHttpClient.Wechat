namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [GET] /mse-pay/profit-allocations/receiver-accounts-applications/{application_id} 接口的请求。</para>
    /// </summary>
    public class GetProfitAllocationReceiverAccountApplicationByApplicationIdRequest : WechatTenpayBusinessRequest
    {
        /// <summary>
        /// 获取或设置微企付申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ApplicationId { get; set; } = string.Empty;
    }
}
