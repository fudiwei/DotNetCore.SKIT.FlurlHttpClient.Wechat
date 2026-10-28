namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/goods-subsidy-activity/retail-store-act/{activity_id}/representative 接口的请求。</para>
    /// </summary>
    public class AddMarketingGoodsSubsidyActivityRetailStoreRepresentativeRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Representative
            {
                /// <summary>
                /// 获取或设置业务代理的 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string? OpenId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置零售小店活动 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? ActivityId { get; set; }

        /// <summary>
        /// 获取或设置请求业务单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string? OutRequestNumber { get; set; }

        /// <summary>
        /// 获取或设置业务代理列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("representative_info_list")]
        [System.Text.Json.Serialization.JsonPropertyName("representative_info_list")]
        public List<Types.Representative>? RepresentativeList { get; set; }

        /// <summary>
        /// 获取或设置添加时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("add_time")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("add_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset? AddTime { get; set; }
    }
}
