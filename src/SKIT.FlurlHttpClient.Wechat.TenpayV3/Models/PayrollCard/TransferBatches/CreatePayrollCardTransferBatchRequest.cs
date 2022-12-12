using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /payroll-card/transfer-batches 接口的请求。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class CreatePayrollCardTransferBatchRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class TransferDetail : CreateTransferBatchRequest.Types.TransferDetail
            {
            }
        }

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置子商户 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
        public string? SubAppId { get; set; }

        /// <summary>
        /// 获取或设置特约商户授权类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorization_type")]
        [System.Text.Json.Serialization.JsonPropertyName("authorization_type")]
        public string AuthorizationType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户批次单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_batch_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_batch_no")]
        public string OutBatchNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置批次名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("batch_name")]
        [System.Text.Json.Serialization.JsonPropertyName("batch_name")]
        public string BatchName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置批次备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("batch_remark")]
        [System.Text.Json.Serialization.JsonPropertyName("batch_remark")]
        public string BatchRemark { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置转账总金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("total_amount")]
        public int TotalAmount { get; set; }

        /// <summary>
        /// 获取或设置转账总笔数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int TotalNumber { get; set; }

        /// <summary>
        /// 获取或设置转账明细列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_detail_list")]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_detail_list")]
        public IList<Types.TransferDetail> TransferDetailList { get; set; } = new List<Types.TransferDetail>();

        /// <summary>
        /// 获取或设置用工类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("employment_type")]
        [System.Text.Json.Serialization.JsonPropertyName("employment_type")]
        public string EmploymentType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用工场景。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("employment_scene")]
        [System.Text.Json.Serialization.JsonPropertyName("employment_scene")]
        public string EmploymentScene { get; set; } = string.Empty;
    }
}
