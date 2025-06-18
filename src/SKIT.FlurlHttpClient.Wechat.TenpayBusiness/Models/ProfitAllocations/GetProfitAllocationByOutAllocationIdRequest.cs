namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [GET] /mse-pay/profit-allocations/out-allocation-id/{out_allocation_id} 接口的请求。</para>
    /// </summary>
    public class GetProfitAllocationByOutAllocationIdRequest : WechatTenpayBusinessRequest
    {
        /// <summary>
        /// 获取或设置平台分账单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OutAllocationId { get; set; } = string.Empty;
    }
}
