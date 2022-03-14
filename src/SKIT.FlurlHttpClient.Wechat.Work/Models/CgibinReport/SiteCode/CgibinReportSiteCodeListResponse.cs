namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/report/sitecode/list 接口的响应。</para>
    /// </summary>
    public class CgibinReportSiteCodeListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class SiteCode
            {
                /// <summary>
                /// 获取或设置场所码 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public string Id { get; set; } = default!;

                /// <summary>
                /// 获取或设置场所码类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string Type { get; set; } = default!;

                /// <summary>
                /// 获取或设置场所码行政区域。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("area")]
                [System.Text.Json.Serialization.JsonPropertyName("area")]
                public string Area { get; set; } = default!;

                /// <summary>
                /// 获取或设置场所码详细地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address")]
                [System.Text.Json.Serialization.JsonPropertyName("address")]
                public string Address { get; set; } = default!;

                /// <summary>
                /// 获取或设置场所码名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置负责人 UserId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("admin")]
                [System.Text.Json.Serialization.JsonPropertyName("admin")]
                public string[] AdminUserIdList { get; set; } = default!;

                /// <summary>
                /// 获取或设置二维码 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qr_code_url")]
                [System.Text.Json.Serialization.JsonPropertyName("qr_code_url")]
                public string QrcodeUrl { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置场所码列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("site_code_infos")]
        [System.Text.Json.Serialization.JsonPropertyName("site_code_infos")]
        public Types.SiteCode[] SiteCodeList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
