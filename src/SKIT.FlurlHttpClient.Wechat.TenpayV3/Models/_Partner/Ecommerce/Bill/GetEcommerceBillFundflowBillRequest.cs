namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /ecommerce/bill/fundflowbill 接口的请求。</para>
    /// </summary>
    public class GetEcommerceBillFundflowBillRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置账单日期字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string BillDateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置资金账户类型。
        /// <para>默认值："ALL"</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string AccountType { get; set; } = "ALL";

        /// <summary>
        /// 获取或设置压缩类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? TarType { get; set; }

        /// <summary>
        /// 获取或设置加密算法。
        /// <para>默认值：<see cref="Constants.EncryptionAlgorithms.AEAD_AES_256_GCM"/></para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string Algorithm { get; set; } = Constants.EncryptionAlgorithms.AEAD_AES_256_GCM;
    }
}
