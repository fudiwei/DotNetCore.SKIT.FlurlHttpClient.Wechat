/* @codestyle-disable no-jsonable-property-in-request-get */
namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /marketing/partnerships 接口的请求。</para>
    /// </summary>
    public class QueryMarketingPartnershipsRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Partner
            {
                /// <summary>
                /// 获取或设置合作方类别。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string Type { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置合作方 AppId。与字段 <see cref="MerchantId"/> 二选一。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string? AppId { get; set; }

                /// <summary>
                /// 获取或设置合作方商户号。与字段 <see cref="AppId"/> 二选一。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_id")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_id")]
                public string? MerchantId { get; set; }
            }

            public class AuthorizedData
            {
                /// <summary>
                /// 获取或设置授权业务类别。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("business_type")]
                [System.Text.Json.Serialization.JsonPropertyName("business_type")]
                public string BusinessType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置授权场景。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("scenarios")]
                [System.Text.Json.Serialization.JsonPropertyName("scenarios")]
                public string? Scenarios { get; set; }

                /// <summary>
                /// 获取或设置授权批次 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock_id")]
                [System.Text.Json.Serialization.JsonPropertyName("stock_id")]
                public string? StockId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置合作方信息。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public Types.Partner Partner { get; set; } = new Types.Partner();

        /// <summary>
        /// 获取或设置被授权数据。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public Types.AuthorizedData AuthorizedData { get; set; } = new Types.AuthorizedData();

        /// <summary>
        /// 获取或设置分页大小。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? Limit { get; set; }

        /// <summary>
        /// 获取或设置分页开始位置。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? Offset { get; set; }
    }
}
