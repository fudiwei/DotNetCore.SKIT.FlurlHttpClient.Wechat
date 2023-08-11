using System;
using System.Collections.Generic;

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
                public string OpenId { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置零售小店活动 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ActivityId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置请求业务单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string OutRequestNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置业务代理列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("representative_info_list")]
        [System.Text.Json.Serialization.JsonPropertyName("representative_info_list")]
        public IList<Types.Representative> RepresentativeList { get; set; } = new List<Types.Representative>();

        /// <summary>
        /// 获取或设置添加时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("add_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("add_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        public DateTimeOffset? AddTime { get; set; }
    }
}
