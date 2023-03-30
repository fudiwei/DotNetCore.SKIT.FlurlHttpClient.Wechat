namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /merchant/fund/withdraw/bill-type/{bill_type} 接口的请求。</para>
    /// </summary>
    public class GetMerchantFundWithdrawBillRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置账单日期字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string BillDateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置资金账户类型。
        /// <para>默认值：NO_SUCC</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string BillType { get; set; } = "NO_SUCC";

        /// <summary>
        /// 获取或设置压缩类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? TarType { get; set; }
    }
}
