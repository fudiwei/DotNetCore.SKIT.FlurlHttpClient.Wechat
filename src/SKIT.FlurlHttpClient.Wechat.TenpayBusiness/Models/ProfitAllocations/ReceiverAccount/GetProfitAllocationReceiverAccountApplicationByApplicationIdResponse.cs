namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [GET] /mse-pay/profit-allocations/receiver-accounts-applications/{application_id} 接口的响应。</para>
    /// </summary>
    public class GetProfitAllocationReceiverAccountApplicationByApplicationIdResponse : WechatTenpayBusinessResponse
    {
        public static class Types
        {
            public class Receiver
            {
                /// <summary>
                /// 获取或设置接收方账户 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receiver_acct_id")]
                [System.Text.Json.Serialization.JsonPropertyName("receiver_acct_id")]
                public string? ReceiverAccountId { get; set; }

                /// <summary>
                /// 获取或设置接收方类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receiver_type")]
                [System.Text.Json.Serialization.JsonPropertyName("receiver_type")]
                public string ReceiverType { get; set; } = default!;

                /// <summary>
                /// 获取或设置平台接收方名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_receiver_name")]
                [System.Text.Json.Serialization.JsonPropertyName("out_receiver_name")]
                public string OutReceiverName { get; set; } = default!;

                /// <summary>
                /// 获取或设置商户名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_name")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_name")]
                public string MerchantName { get; set; } = default!;

                /// <summary>
                /// 获取或设置个人身份证号掩码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_card_num_mask")]
                [System.Text.Json.Serialization.JsonPropertyName("id_card_num_mask")]
                public string? IdCardNumberMask { get; set; }

                /// <summary>
                /// 获取或设置个人身份证号 MD5 值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_card_num_md5")]
                [System.Text.Json.Serialization.JsonPropertyName("id_card_num_md5")]
                public string? IdCardNumberMd5 { get; set; }
            }

            public class Failure
            {
                /// <summary>
                /// 获取或设置失败类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("failed_type")]
                [System.Text.Json.Serialization.JsonPropertyName("failed_type")]
                public string FailedType { get; set; } = default!;

                /// <summary>
                /// 获取或设置失败原因详情。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("failed_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("failed_detail")]
                public string? FailedDetail { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置平台申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_application_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_application_id")]
        public string OutApplicationId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微企付申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("application_id")]
        [System.Text.Json.Serialization.JsonPropertyName("application_id")]
        public string ApplicationId { get; set; } = default!;

        /// <summary>
        /// 获取或设置申请状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = default!;

        /// <summary>
        /// 获取或设置企业商户 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ent_id")]
        [System.Text.Json.Serialization.JsonPropertyName("ent_id")]
        public string EnterpriseId { get; set; } = default!;

        /// <summary>
        /// 获取或设置接收方信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("receiver_info")]
        [System.Text.Json.Serialization.JsonPropertyName("receiver_info")]
        public Types.Receiver Receiver { get; set; } = default!;

        /// <summary>
        /// 获取或设置失败信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("failed_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("failed_reason")]
        public Types.Failure? Failure { get; set; }
    }
}
