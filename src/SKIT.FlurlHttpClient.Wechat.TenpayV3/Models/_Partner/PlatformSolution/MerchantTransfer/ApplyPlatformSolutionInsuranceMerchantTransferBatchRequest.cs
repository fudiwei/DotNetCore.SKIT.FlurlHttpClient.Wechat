using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /platsolution/insurance/mch-transfer/batches/apply 接口的请求。</para>
    /// </summary>
    public class ApplyPlatformSolutionInsuranceMerchantTransferBatchRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class TransferDetail
            {
                /// <summary>
                /// 获取或设置商户明细单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_detail_no")]
                [System.Text.Json.Serialization.JsonPropertyName("out_detail_no")]
                public string OutDetailNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置转账金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("transfer_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("transfer_amount")]
                public int TransferAmount { get; set; }

                /// <summary>
                /// 获取或设置转账备注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("transfer_remark")]
                [System.Text.Json.Serialization.JsonPropertyName("transfer_remark")]
                public string TransferRemark { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置收款用户 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置微信转账预约单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reservation_id")]
                [System.Text.Json.Serialization.JsonPropertyName("reservation_id")]
                public string ReservationId { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置特约商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置服务商 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置二级商户 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
        public string? SubAppId { get; set; }

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
        /// 获取或设置转账场景 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_scene_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_scene_id")]
        public string TransferSceneId { get; set; } = string.Empty;

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
        /// 获取或设置回调通知地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public string? NotifyUrl { get; set; }
    }
}
