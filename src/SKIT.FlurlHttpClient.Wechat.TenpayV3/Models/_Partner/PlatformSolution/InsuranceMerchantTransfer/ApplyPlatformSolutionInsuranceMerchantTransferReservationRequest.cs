using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /platsolution/insurance/mch-transfer/reservation/apply 接口的请求。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class ApplyPlatformSolutionInsuranceMerchantTransferReservationRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class SceneReportData
            {
                public static class Types
                {
                    public class InsurancePolicy
                    {
                        /// <summary>
                        /// 获取或设置保险产品备案编号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_registration_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_registration_no")]
                        public string? ProductRegistrationNumber { get; set; }

                        /// <summary>
                        /// 获取或设置保险单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("policy_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("policy_no")]
                        public string PolicyNumber { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置保险名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置取现单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("withdrawal_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("withdrawal_no")]
                        public string? WithdrawalNumber { get; set; }

                        /// <summary>
                        /// 获取或设置理赔单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("claim_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("claim_no")]
                        public string? ClaimNumber { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置保险保单报备信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("insurance_policy")]
                [System.Text.Json.Serialization.JsonPropertyName("insurance_policy")]
                public Types.InsurancePolicy? InsurancePolicy { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置二级商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置服务商 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置二级商户 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
        public string? SubAppId { get; set; }

        /// <summary>
        /// 获取或设置商户预约单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_reservation_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_reservation_no")]
        public string OutReservationNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置转账场景 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_scene_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_scene_id")]
        public string TransferSceneId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置预计最晚转账日期。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("estimated_date")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("estimated_date")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? EstimatedDate { get; set; }

        /// <summary>
        /// 获取或设置预计最大转账金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("estimated_max_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("estimated_max_amount")]
        public int? EstimatedMaxAmount { get; set; }

        /// <summary>
        /// 获取或设置准确转账金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("exact_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("exact_amount")]
        public int? ExactAmount { get; set; }

        /// <summary>
        /// 获取或设置收款用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置收款用户姓名（需使用平台公钥/证书加密）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_real_name")]
        [System.Text.Json.Serialization.JsonPropertyName("user_real_name")]
        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
        public string? UserName { get; set; }

        /// <summary>
        /// 获取或设置预约备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reserve_remark")]
        [System.Text.Json.Serialization.JsonPropertyName("reserve_remark")]
        public string ReserveRemark { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置回调通知地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public string? NotifyUrl { get; set; }

        /// <summary>
        /// 获取或设置场景报备信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_report_data")]
        [System.Text.Json.Serialization.JsonPropertyName("scene_report_data")]
        public Types.SceneReportData? SceneReportData { get; set; }
    }
}
