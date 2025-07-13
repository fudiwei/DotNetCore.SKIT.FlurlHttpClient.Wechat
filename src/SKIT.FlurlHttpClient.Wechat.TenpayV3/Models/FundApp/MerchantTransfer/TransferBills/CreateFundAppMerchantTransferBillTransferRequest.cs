using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /fund-app/mch-transfer/transfer-bills/transfer 接口的请求。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class CreateFundAppMerchantTransferBillTransferRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class TransferSceneReportInfo : CreateFundAppMerchantTransferBillPreTransferWithAuthorizationRequest.Types.TransferSceneReportInfo
            {
            }
        }

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_bill_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_bill_no")]
        public string OutBillNumber { get; set; } = string.Empty;

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
        /// 获取或设置微信免确认收款授权单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorization_id")]
        [System.Text.Json.Serialization.JsonPropertyName("authorization_id")]
        public string AuthorizationId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置收款用户姓名（需使用平台公钥/证书加密）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_name")]
        [System.Text.Json.Serialization.JsonPropertyName("user_name")]
        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
        public string? UserName { get; set; }

        /// <summary>
        /// 获取或设置转账场景 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_scene_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_scene_id")]
        public string? TransferSceneId { get; set; }

        /// <summary>
        /// 获取或设置通知地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public string? NotifyUrl { get; set; }

        /// <summary>
        /// 获取或设置用户收款感知。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_recv_perception")]
        [System.Text.Json.Serialization.JsonPropertyName("user_recv_perception")]
        public string? UserReceivePerception { get; set; }

        /// <summary>
        /// 获取或设置转账场景报备信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_scene_report_infos")]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_scene_report_infos")]
        public IList<Types.TransferSceneReportInfo>? TransferSceneReportInfoList { get; set; }

        /// <summary>
        /// 获取或设置出资商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sponsor_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sponsor_mchid")]
        public string? SponsorMerchantId { get; set; }
    }
}
