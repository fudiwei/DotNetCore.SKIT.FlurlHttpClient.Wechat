namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/brand/valid/list/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECBrandValidListGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Brand : ChannelsECBrandGetResponse.Types.__zz__Brand
            {
                public static class Types
                {
                    public class RegisterDetail : ChannelsECBrandGetResponse.Types.Brand.Types.RegisterDetail
                    {
                    }

                    public class ApplicationDetail : ChannelsECBrandGetResponse.Types.Brand.Types.ApplicationDetail
                    {
                    }

                    public class GrantDetail : ChannelsECBrandGetResponse.Types.Brand.Types.GrantDetail
                    {
                    }

                    public class AuditResult : ChannelsECBrandGetResponse.Types.Brand.Types.AuditResult
                    {
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
        /// 获取或设置品牌列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brands")]
        [System.Text.Json.Serialization.JsonPropertyName("brands")]
        public List<Types.Brand>? BrandList { get; set; }

        /// <summary>
        /// 获取或设置品牌总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int TotalCount { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_key")]
        [System.Text.Json.Serialization.JsonPropertyName("next_key")]
        public string? NextCursor { get; set; }
    }
}
