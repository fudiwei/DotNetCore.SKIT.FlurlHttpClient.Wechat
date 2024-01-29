using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/goods-subsidy-activity/retail-store-act/{brand_id}/stores 接口的请求。</para>
    /// </summary>
    public class AddMarketingGoodsSubsidyActivityRetailStoreRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Store
            {
                /// <summary>
                /// 获取或设置门店编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("store_code")]
                [System.Text.Json.Serialization.JsonPropertyName("store_code")]
                public string StoreCode { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置门店名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("store_name")]
                [System.Text.Json.Serialization.JsonPropertyName("store_name")]
                public string StoreName { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string BrandId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置请求业务单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string OutRequestNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置门店列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stores")]
        [System.Text.Json.Serialization.JsonPropertyName("stores")]
        public IList<Types.Store> StoreList { get; set; } = new List<Types.Store>();

        /// <summary>
        /// 获取或设置添加时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("add_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("add_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? AddTime { get; set; }
    }
}
