namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/supplier/relation/get_supplier_list 接口的响应。</para>
    /// </summary>
    public class ChannelsECSupplierRelationGetSupplierListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Supplier
            {
                /// <summary>
                /// 获取或设置供货商 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置供货商名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置绑定审核名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bind_audit_status")]
                [System.Text.Json.Serialization.JsonPropertyName("bind_audit_status")]
                public int BindAuditStatus { get; set; }

                /// <summary>
                /// 获取或设置更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                public long UpdateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置供货商列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.Supplier[] SupplierList { get; set; } = default!;

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; }
    }
}
