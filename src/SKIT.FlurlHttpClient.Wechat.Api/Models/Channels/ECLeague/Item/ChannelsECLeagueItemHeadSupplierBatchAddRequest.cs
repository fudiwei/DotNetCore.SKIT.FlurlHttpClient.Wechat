using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/item/headsupplier/batchadd 接口的请求。</para>
    /// </summary>
    public class ChannelsECLeagueItemHeadSupplierBatchAddRequest : WechatApiRequest, IInferable<ChannelsECLeagueItemHeadSupplierBatchAddRequest, ChannelsECLeagueItemHeadSupplierBatchAddResponse>
    {
        public static class Types
        {
            public class Item
            {
                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                public long ProductId { get; set; }

                /// <summary>
                /// 获取或设置分佣率（范围：0～100）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ratio")]
                [System.Text.Json.Serialization.JsonPropertyName("ratio")]
                public int? Ratio { get; set; }

                /// <summary>
                /// 获取或设置推广服务费率（范围：0～100）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_ratio")]
                [System.Text.Json.Serialization.JsonPropertyName("service_ratio")]
                public int? ServiceRatio { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置供货机构 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("headsupplier_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("headsupplier_appid")]
        public string HeadSupplierAppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置联盟商品列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public IList<Types.Item> List { get; set; } = new List<Types.Item>();

        /// <summary>
        /// 获取或设置推广开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("begin_time")]
        [System.Text.Json.Serialization.JsonPropertyName("begin_time")]
        public long? BeginTimestamp { get; set; }

        /// <summary>
        /// 获取或设置推广开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置是否永久推广。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_forerver")]
        [System.Text.Json.Serialization.JsonPropertyName("is_forerver")]
        public bool? IsForerver { get; set; }
    }
}
