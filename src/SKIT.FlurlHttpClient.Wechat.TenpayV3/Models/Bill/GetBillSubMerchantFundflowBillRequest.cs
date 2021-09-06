using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /bill/sub-merchant-fundflowbill 接口的请求。</para>
    /// </summary>
    public class GetBillSubMerchantFundflowBillRequest : GetBillFundflowBillRequest
    {
        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置加密算法。
        /// <para>默认值：<see cref="Constants.EncryptionAlgorithms.AEAD_AES_256_GCM"/></para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string Algorithm { get; set; } = Constants.EncryptionAlgorithms.AEAD_AES_256_GCM;
    }
}
