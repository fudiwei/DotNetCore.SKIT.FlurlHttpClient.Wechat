namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [GET] /mse-pay/profit-allocations/receiver-accounts-applications/out_application_id/{out_application_id} 接口的请求。</para>
    /// </summary>
    public class GetProfitAllocationReceiverAccountApplicationByOutApplicationIdRequest : WechatTenpayBusinessRequest
    {
        /// <summary>
        /// 获取或设置平台申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OutApplicationId { get; set; } = string.Empty;
    }
}
