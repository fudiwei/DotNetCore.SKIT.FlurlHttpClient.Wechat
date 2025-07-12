namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /platsolution/ecommerce/mch-transfer/transfer-bills 接口的请求。</para>
    /// </summary>
    public class CreatePlatformSolutionEcommerceMerchantTransferBillRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Receiver
            {
                public static class Types
                {
                    public class MerchantInfo
                    {
                        /// <summary>
                        /// 获取或设置转账接收方商户号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mchid")]
                        [System.Text.Json.Serialization.JsonPropertyName("mchid")]
                        public string? MerchantId { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置转账接收方类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string? Type { get; set; }

                /// <summary>
                /// 获取或设置转账接收方商户信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mch_info")]
                [System.Text.Json.Serialization.JsonPropertyName("mch_info")]
                public Types.MerchantInfo? MerchantInfo { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置二级商户号。
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
        /// 获取或设置业务类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_type")]
        [System.Text.Json.Serialization.JsonPropertyName("business_type")]
        public string BusinessType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_bill_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_bill_no")]
        public string OutBillNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置赔付用户信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("receiver")]
        [System.Text.Json.Serialization.JsonPropertyName("receiver")]
        public Types.Receiver Receiver { get; set; } = new Types.Receiver();

        /// <summary>
        /// 获取或设置赔付金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 获取或设置赔付原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_remark")]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_remark")]
        public string TransferRemark { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置收款方备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("receiver_remark")]
        [System.Text.Json.Serialization.JsonPropertyName("receiver_remark")]
        public string? ReceiverRemark { get; set; }
    }
}
