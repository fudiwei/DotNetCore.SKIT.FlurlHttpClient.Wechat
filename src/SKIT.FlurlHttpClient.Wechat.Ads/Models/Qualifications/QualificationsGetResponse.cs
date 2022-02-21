namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [GET] /qualifications/get 接口的响应。</para>
    /// </summary>
    public class QualificationsGetResponse : WechatAdsResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Qualification
                    {
                        /// <summary>
                        /// 获取或设置资质 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("qualification_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("qualification_id")]
                        public long QualificationId { get; set; }

                        /// <summary>
                        /// 获取或设置资质类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("qualification_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("qualification_type")]
                        public string QualificationType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置资质名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("qualification_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("qualification_name")]
                        public string QualificationName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置资质证明文件图片 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("qualification_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("qualification_url")]
                        public string QualificationImageUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置资质状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("qualification_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("qualification_status")]
                        public string QualificationStatus { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置资质有效日期（格式：yyyy-MM-dd）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("valid_date")]
                        [System.Text.Json.Serialization.JsonPropertyName("valid_date")]
                        public string? ValidDateString { get; set; }

                        /// <summary>
                        /// 获取或设置审核拒绝原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reject_message")]
                        [System.Text.Json.Serialization.JsonPropertyName("reject_message")]
                        public string? RejectReason { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置资质列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Qualification[] QualificationList { get; set; } = default!;

                /// <summary>
                /// 获取或设置分页信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_info")]
                [System.Text.Json.Serialization.JsonPropertyName("page_info")]
                public CommonPagination Pagination { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
