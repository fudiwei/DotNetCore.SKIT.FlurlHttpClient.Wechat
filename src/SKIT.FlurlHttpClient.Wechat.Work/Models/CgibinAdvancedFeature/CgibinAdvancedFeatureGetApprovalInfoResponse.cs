namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/advanced_feature/get_approval_info 接口的响应。</para>
    /// </summary>
    public class CgibinAdvancedFeatureGetApprovalInfoResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Approval
            {
                /// <summary>
                /// 获取或设置申请的高级账号类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("business_type")]
                [System.Text.Json.Serialization.JsonPropertyName("business_type")]
                public int BusinessType { get; set; }

                /// <summary>
                /// 获取或设置申请 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("apply_id")]
                [System.Text.Json.Serialization.JsonPropertyName("apply_id")]
                public string ApplyId { get; set; } = default!;

                /// <summary>
                /// 获取或设置审批 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("approval_id")]
                [System.Text.Json.Serialization.JsonPropertyName("approval_id")]
                public string ApprovalId { get; set; } = default!;

                /// <summary>
                /// 获取或设置审批类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("approval_type")]
                [System.Text.Json.Serialization.JsonPropertyName("approval_type")]
                public int ApprovalType { get; set; }

                /// <summary>
                /// 获取或设置审批单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("approval_status")]
                [System.Text.Json.Serialization.JsonPropertyName("approval_status")]
                public int ApprovalStatus { get; set; }

                /// <summary>
                /// 获取或设置审批跳转链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("approval_url")]
                [System.Text.Json.Serialization.JsonPropertyName("approval_url")]
                public string ApprovalUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置申请人成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("applicant")]
                [System.Text.Json.Serialization.JsonPropertyName("applicant")]
                public string ApplicantUserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置申请原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("request_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("request_reason")]
                public string ApplyReason { get; set; } = default!;

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置审批信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("approval_info")]
        [System.Text.Json.Serialization.JsonPropertyName("approval_info")]
        public Types.Approval Approval { get; set; } = default!;
    }
}
