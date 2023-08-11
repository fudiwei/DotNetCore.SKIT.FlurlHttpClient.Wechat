using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /bank-transfer/batches 接口的请求。</para>
    /// </summary>
    public class CreateBankTransferBatchRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class TransferDetail : CreateTransferBatchRequest.Types.TransferDetail
            {
            }
        }

        /// <summary>
        /// 获取或设置服务平台商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("platform_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("platform_mchid")]
        public string PlatformMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置付款企业商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("specialized_payment_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("specialized_payment_mchid")]
        public string SpecializedPaymentMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置实际出资商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sponsor_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sponsor_mchid")]
        public string SponsorMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户授权商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_authorized_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("user_authorized_mchid")]
        public string UserAuthorizedMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户授权 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_authorized_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("user_authorized_appid")]
        public string UserAuthorizedAppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置银行批次单号。
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
        /// 获取或设置附加信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attach_remark")]
        [System.Text.Json.Serialization.JsonPropertyName("attach_remark")]
        public string? Attachment { get; set; }

        /// <summary>
        /// 获取或设置转账总金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("total_amount")]
        public int TotalAmount { get; set; }

        /// <summary>
        /// 获取或设置转账总笔数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; }

        /// <summary>
        /// 获取或设置转账明细列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_detail_list")]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_detail_list")]
        public IList<Types.TransferDetail> TransferDetailList { get; set; } = new List<Types.TransferDetail>();

        /// <summary>
        /// 获取或设置转账场景。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_scene")]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_scene")]
        public string? TransferScene { get; set; }

        /// <summary>
        /// 获取或设置转账用途。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_purpose")]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_purpose")]
        public string? TransferPurpose { get; set; }
    }
}
