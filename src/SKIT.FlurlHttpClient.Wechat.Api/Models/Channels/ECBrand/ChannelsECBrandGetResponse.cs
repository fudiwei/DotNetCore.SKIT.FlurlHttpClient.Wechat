namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/brand/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECBrandGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public abstract class __zz__Brand : ShopECBrandAddRequest.Types.__zz__Brand
            {
                /// <summary>
                /// 获取或设置申请状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                public long UpdateTimestamp { get; set; }
            }

            public class Brand : __zz__Brand
            {
                public static class Types
                {
                    public class RegisterDetail : ShopECBrandAddRequest.Types.Brand.Types.RegisterDetail
                    {
                    }

                    public class ApplicationDetail : ShopECBrandAddRequest.Types.Brand.Types.ApplicationDetail
                    {
                    }

                    public class GrantDetail : ShopECBrandAddRequest.Types.Brand.Types.GrantDetail
                    {
                    }

                    public class AuditResult
                    {
                        /// <summary>
                        /// 获取或设置审核单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("audit_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("audit_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long AuditId { get; set; }

                        /// <summary>
                        /// 获取或设置审核拒绝原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reject_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("reject_reason")]
                        public string? RejectReason { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商标注册详细信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("register_details")]
                [System.Text.Json.Serialization.JsonPropertyName("register_details")]
                public Types.RegisterDetail? RegisterDetail { get; set; }

                /// <summary>
                /// 获取或设置商标申请详细信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("application_details")]
                [System.Text.Json.Serialization.JsonPropertyName("application_details")]
                public Types.ApplicationDetail? ApplicationDetail { get; set; }

                /// <summary>
                /// 获取或设置商标授权详细信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("grant_details")]
                [System.Text.Json.Serialization.JsonPropertyName("grant_details")]
                public Types.GrantDetail? GrantDetail { get; set; }

                /// <summary>
                /// 获取或设置审核结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_result")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_result")]
                public Types.AuditResult? AuditResult { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置品牌信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand")]
        [System.Text.Json.Serialization.JsonPropertyName("brand")]
        public Types.Brand? Brand { get; set; }
    }
}
