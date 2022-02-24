namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /bill/sub-merchant-fundflowbill 接口的响应。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class GetBillSubMerchantFundflowBillResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class DownloadBill
            {
                /// <summary>
                /// 获取或设置账单文件序号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bill_sequence")]
                [System.Text.Json.Serialization.JsonPropertyName("bill_sequence")]
                public int BillSequence { get; set; }

                /// <summary>
                /// 获取或设置哈希类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("hash_type")]
                [System.Text.Json.Serialization.JsonPropertyName("hash_type")]
                public string HashType { get; set; } = default!;

                /// <summary>
                /// 获取或设置哈希值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("hash_value")]
                [System.Text.Json.Serialization.JsonPropertyName("hash_value")]
                public string HashValue { get; set; } = default!;

                /// <summary>
                /// 获取或设置账单下载地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("download_url")]
                [System.Text.Json.Serialization.JsonPropertyName("download_url")]
                public string DownloadUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置账单加密密钥（需使用商户私钥解密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("encrypt_key")]
                [System.Text.Json.Serialization.JsonPropertyName("encrypt_key")]
                [WechatTenpaySensitiveProperty(algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                public string EncryptKey { get; set; } = default!;

                /// <summary>
                /// 获取或设置账单加密使用的随机字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nonce")]
                [System.Text.Json.Serialization.JsonPropertyName("nonce")]
                public string Nonce { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置账单文件总数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("download_bill_count")]
        [System.Text.Json.Serialization.JsonPropertyName("download_bill_count")]
        public int DownloadBillCount { get; set; }

        /// <summary>
        /// 获取或设置账单文件列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("download_bill_list")]
        [System.Text.Json.Serialization.JsonPropertyName("download_bill_list")]
        public Types.DownloadBill[] DownloadBillList { get; set; } = default!;
    }
}
