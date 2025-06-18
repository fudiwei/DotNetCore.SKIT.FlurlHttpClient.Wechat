using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/advanced_feature/set_approval_detail 接口的请求。</para>
    /// </summary>
    public class CgibinAdvancedFeatureSetApprovalDetailRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Process
            {
                public static class Types
                {
                    public class Node
                    {
                        /// <summary>
                        /// 获取或设置审批节点状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("node_apv_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("node_apv_status")]
                        public int NodeApproveStatus { get; set; }

                        /// <summary>
                        /// 获取或设置多人审批方式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("node_apv_rel")]
                        [System.Text.Json.Serialization.JsonPropertyName("node_apv_rel")]
                        public int NodeApproversRelation { get; set; }

                        /// <summary>
                        /// 获取或设置待处理人成员账号列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("current_approvers")]
                        [System.Text.Json.Serialization.JsonPropertyName("current_approvers")]
                        public IList<string>? CurrentApproversUserIdList { get; set; }

                        /// <summary>
                        /// 获取或设置已处理人成员账号列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("completed_approvers")]
                        [System.Text.Json.Serialization.JsonPropertyName("completed_approvers")]
                        public IList<string>? CompletedApproversUserIdList { get; set; }

                        /// <summary>
                        /// 获取或设置更新时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("apv_update_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("apv_update_time")]
                        public long UpdateTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置节点列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("node_list")]
                [System.Text.Json.Serialization.JsonPropertyName("node_list")]
                public IList<Types.Node> NodeList { get; set; } = new List<Types.Node>();
            }
        }

        /// <summary>
        /// 获取或设置申请 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apply_id")]
        [System.Text.Json.Serialization.JsonPropertyName("apply_id")]
        public string ApplyId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置审批 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("approval_id")]
        [System.Text.Json.Serialization.JsonPropertyName("approval_id")]
        public string ApprovalId { get; set; } = string.Empty;

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
        public string ApprovalUrl { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置审批流程信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("process_list")]
        [System.Text.Json.Serialization.JsonPropertyName("process_list")]
        public Types.Process Process { get; set; } = new Types.Process();
    }
}
