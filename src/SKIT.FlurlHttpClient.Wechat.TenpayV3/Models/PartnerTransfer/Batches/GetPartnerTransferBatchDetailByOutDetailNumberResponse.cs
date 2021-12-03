using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /partner-transfer/batches/out-batch-no/{out_batch_no}/details/out-detail-no/{out_detail_no} 接口的响应。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class GetPartnerTransferBatchDetailByOutDetailNumberResponse : GetTransferBatchDetailByOutDetailNumberResponse
    {
        /// <summary>
        /// 获取或设置服务商商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_mchid")]
        public string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置收款用户姓名（需使用商户私钥解密）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("username")]
        [System.Text.Json.Serialization.JsonPropertyName("username")]
        [WechatTenpaySensitiveProperty(algorithm: Constants.EncryptionAlgorithms.RSA_2048_PKCS8_ECB)]
        public override string UserName { get; set; } = default!;
    }
}
