using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /merchant-service/complaints-v2/{complaint_id} 接口的响应。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class GetMerchantServiceComplaintByComplaintIdResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class ComplaintOrder
            {
                /// <summary>
                /// 获取或设置微信订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("transaction_id")]
                [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
                public string TransactionId { get; set; } = default!;

                /// <summary>
                /// 获取或设置商户订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_trade_no")]
                [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
                public string OutTradeNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                public int Amount { get; set; }
            }

            public class ComplaintMedia
            {
                /// <summary>
                /// 获取或设置媒体文件业务类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("media_type")]
                [System.Text.Json.Serialization.JsonPropertyName("media_type")]
                public string MediaType { get; set; } = default!;

                /// <summary>
                /// 获取或设置媒体文件 URL 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("media_url")]
                [System.Text.Json.Serialization.JsonPropertyName("media_url")]
                public string[] MediaUrl { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置投诉单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("complaint_id")]
        [System.Text.Json.Serialization.JsonPropertyName("complaint_id")]
        public string ComplaintId { get; set; } = default!;

        /// <summary>
        /// 获取或设置被诉商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("complainted_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("complainted_mchid")]
        public string ComplaintedMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置投诉详情。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("complaint_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("complaint_detail")]
        public string ComplaintDetail { get; set; } = default!;

        /// <summary>
        /// 获取或设置投诉单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("complaint_state")]
        [System.Text.Json.Serialization.JsonPropertyName("complaint_state")]
        public string ComplaintState { get; set; } = default!;

        /// <summary>
        /// 获取或设置投诉时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("complaint_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("complaint_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset ComplaintTime { get; set; }

        /// <summary>
        /// 获取或设置投诉人联系方式（需使用商户私钥解密）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payer_phone")]
        [System.Text.Json.Serialization.JsonPropertyName("payer_phone")]
        [WechatTenpaySensitiveProperty(algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
        public string? PayerPhone { get; set; }

        /// <summary>
        /// 获取或设置投诉人 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payer_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("payer_openid")]
        public string? PayerOpenId { get; set; }

        /// <summary>
        /// 获取或设置投诉单关联订单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("complaint_order_info")]
        [System.Text.Json.Serialization.JsonPropertyName("complaint_order_info")]
        public Types.ComplaintOrder[] ComplaintOrderList { get; set; } = default!;

        /// <summary>
        /// 获取或设置投诉资料列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("complaint_media_list")]
        [System.Text.Json.Serialization.JsonPropertyName("complaint_media_list")]
        public Types.ComplaintMedia[] ComplaintMediaList { get; set; } = default!;

        /// <summary>
        /// 获取或设置问题类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("problem_type")]
        [System.Text.Json.Serialization.JsonPropertyName("problem_type")]
        public string? ProblemType { get; set; }

        /// <summary>
        /// 获取或设置问题描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("problem_description")]
        [System.Text.Json.Serialization.JsonPropertyName("problem_description")]
        public string ProblemDescription { get; set; } = default!;

        /// <summary>
        /// 获取或设置申请退款金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apply_refund_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("apply_refund_amount")]
        public int? ApplyRefundAmount { get; set; }

        /// <summary>
        /// 获取或设置投诉单是否已全额退款。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("complaint_full_refunded")]
        [System.Text.Json.Serialization.JsonPropertyName("complaint_full_refunded")]
        public bool IsFullRefunded { get; set; }

        /// <summary>
        /// 获取或设置是否有待回复的用户留言。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("incoming_user_response")]
        [System.Text.Json.Serialization.JsonPropertyName("incoming_user_response")]
        public bool HasIncomingUserResponse { get; set; }

        /// <summary>
        /// 获取或设置用户投诉次数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_complaint_times")]
        [System.Text.Json.Serialization.JsonPropertyName("user_complaint_times")]
        public int UserComplaintTimes { get; set; }

        /// <summary>
        /// 获取或设置用户标签列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_tag_list")]
        [System.Text.Json.Serialization.JsonPropertyName("user_tag_list")]
        public string[]? UserTagList { get; set; }
    }
}
