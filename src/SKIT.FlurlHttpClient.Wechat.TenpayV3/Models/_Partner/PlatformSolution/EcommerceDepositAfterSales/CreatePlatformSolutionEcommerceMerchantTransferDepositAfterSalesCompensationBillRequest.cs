namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /platsolution/ecommerce/mch-transfer/deposit-after-sales-compensation-bills 接口的请求。</para>
    /// </summary>
    public class CreatePlatformSolutionEcommerceMerchantTransferDepositAfterSalesCompensationBillRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Receiver
            {
                public static class Types
                {
                    public class TransactionInfo
                    {
                        /// <summary>
                        /// 获取或设置转账接收方订单类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public string? Type { get; set; }

                        /// <summary>
                        /// 获取或设置微信交易订单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("transaction_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
                        public string TransactionId { get; set; } = string.Empty;
                    }

                    public class UserInfo
                    {
                        /// <summary>
                        /// 获取或设置转账接收方用户 OpenId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sp_openid")]
                        [System.Text.Json.Serialization.JsonPropertyName("sp_openid")]
                        public string OpenId { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// 获取或设置转账接收方类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string? Type { get; set; }

                /// <summary>
                /// 获取或设置转账接收方订单信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("transaction_info")]
                [System.Text.Json.Serialization.JsonPropertyName("transaction_info")]
                public Types.TransactionInfo? TransactionInfo { get; set; }

                /// <summary>
                /// 获取或设置转账接收方用户信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_info")]
                [System.Text.Json.Serialization.JsonPropertyName("user_info")]
                public Types.UserInfo? UserInfo { get; set; }
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
        /// 获取或设置转账场景 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_scene_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_scene_id")]
        public string? TransferSceneId { get; set; }

        /// <summary>
        /// 获取或设置用户收款感知。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_recv_perception")]
        [System.Text.Json.Serialization.JsonPropertyName("user_recv_perception")]
        public string? UserReceivePerception { get; set; }
    }
}
