namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [DELETE] /marketing/goods-subsidy-activity/retail-store-act/{activity_id}/representative 接口的响应。</para>
    /// </summary>
    public class DeleteMarketingGoodsSubsidyActivityRetailStoreRepresentativeResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Representative : QueryMarketingGoodsSubsidyActivityRetailStoreRepresentativesResponse.Types.Representative
            {
            }
        }

        /// <summary>
        /// 获取或设置零售小店活动 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_id")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_id")]
        public string? ActivityId { get; set; }

        /// <summary>
        /// 获取或设置删除失败的业务代理列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("failed_representative_info_list")]
        [System.Text.Json.Serialization.JsonPropertyName("failed_representative_info_list")]
        public List<Types.Representative>? FailedRepresentativeList { get; set; }

        /// <summary>
        /// 获取或设置删除时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delete_time")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("delete_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset DeleteTime { get; set; }
    }
}
