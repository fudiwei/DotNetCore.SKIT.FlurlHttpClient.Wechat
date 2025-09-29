using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/supplier/relation/set_product_distribute 接口的请求。</para>
    /// </summary>
    public class ChannelsECSupplierRelationSetProductDistributeRequest : WechatApiRequest, IInferable<ChannelsECSupplierRelationSetProductDistributeRequest, ChannelsECSupplierRelationSetProductDistributeResponse>
    {
        public static class Types
        {
            public class Distribution
            {
                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                public long ProductId { get; set; }

                /// <summary>
                /// 获取或设置供货商 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("supplier_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("supplier_appid")]
                public string SupplierAppId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置是否自动分配给该供货商。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_distribute")]
                [System.Text.Json.Serialization.JsonPropertyName("is_distribute")]
                public bool IsDistribute { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置分配列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public IList<Types.Distribution> DistributionList { get; set; } = new List<Types.Distribution>();
    }
}
