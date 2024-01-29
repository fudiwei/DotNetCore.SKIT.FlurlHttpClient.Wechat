using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/goods-subsidy-activity/retail-store-act/{activity_id}/representative 接口的响应。</para>
    /// </summary>
    public class AddMarketingGoodsSubsidyActivityRetailStoreRepresentativeResponse : WechatTenpayResponse
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
        public string ActivityId { get; set; } = default!;

        /// <summary>
        /// 获取或设置添加失败的业务代理列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("failed_representative_info_list")]
        [System.Text.Json.Serialization.JsonPropertyName("failed_representative_info_list")]
        public Types.Representative[]? FailedRepresentativeList { get; set; }

        /// <summary>
        /// 获取或设置添加时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("add_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("add_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset AddTime { get; set; }
    }
}
