using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /transfer/batches 接口的请求。</para>
    /// </summary>
    public class CreateTransferBatchRequest : WechatTenpayRequest
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
                /// 获取或设置收款用户姓名（需使用平台公钥/证书加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_name")]
                [System.Text.Json.Serialization.JsonPropertyName("user_name")]
                [WechatTenpaySensitiveProperty(algorithm: Constants.EncryptionAlgorithms.RSA_2048_PKCS8_ECB)]
                public string UserName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置收款用户身份证号（需使用平台公钥/证书加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_id_card")]
                [System.Text.Json.Serialization.JsonPropertyName("user_id_card")]
                [WechatTenpaySensitiveProperty(algorithm: Constants.EncryptionAlgorithms.RSA_2048_PKCS8_ECB)]
                public string UserIdCardNumber { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = string.Empty;

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
    }
}
