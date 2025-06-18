namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/license/getpkglist 接口的响应。</para>
    /// </summary>
    public class WxaBusinessLicenseGetPackageListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Package
            {
                /// <summary>
                /// 获取或设置资源包 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pkg_id")]
                [System.Text.Json.Serialization.JsonPropertyName("pkg_id")]
                public string PackageId { get; set; } = default!;

                /// <summary>
                /// 获取或设置资源包类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pkg_type")]
                [System.Text.Json.Serialization.JsonPropertyName("pkg_type")]
                public int PackageType { get; set; }

                /// <summary>
                /// 获取或设置资源包状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pkg_status")]
                [System.Text.Json.Serialization.JsonPropertyName("pkg_status")]
                public int PackageStatus { get; set; }

                /// <summary>
                /// 获取或设置下单时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_time")]
                [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                public long StartTimestamp { get; set; }

                /// <summary>
                /// 获取或设置过期时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                public long EndTimestamp { get; set; }

                /// <summary>
                /// 获取或设置已使用额度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("used")]
                [System.Text.Json.Serialization.JsonPropertyName("used")]
                public int UsedQuota { get; set; }

                /// <summary>
                /// 获取或设置资源包总量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("all")]
                [System.Text.Json.Serialization.JsonPropertyName("all")]
                public int TotalQuota { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置资源包列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pkg_list")]
        [System.Text.Json.Serialization.JsonPropertyName("pkg_list")]
        public Types.Package[] PackageList { get; set; } = default!;

        /// <summary>
        /// 获取或设置最大激活码序号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("max_active_number")]
        [System.Text.Json.Serialization.JsonPropertyName("max_active_number")]
        public int? MaxActiveNumber { get; set; }
    }
}
