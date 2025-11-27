namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/headsupplier/subitem/list/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECLeagueHeadSupplierSubItemListGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class SubItem
            {
                /// <summary>
                /// 获取或设置达人佣金计划 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_item_id")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_item_id")]
                public long SubItemId { get; set; }

                /// <summary>
                /// 获取或设置机构推广商品链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("head_supplier_item_link")]
                [System.Text.Json.Serialization.JsonPropertyName("head_supplier_item_link")]
                public string HeadSupplierItemLink { get; set; } = default!;

                /// <summary>
                /// 获取或设置计划状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置达人佣金率（范围：0～90）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ratio")]
                [System.Text.Json.Serialization.JsonPropertyName("ratio")]
                public int Ratio { get; set; }

                /// <summary>
                /// 获取或设置相对于服务费的达人佣金率（范围：0～90）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ratio_to_service_rate")]
                [System.Text.Json.Serialization.JsonPropertyName("ratio_to_service_rate")]
                public int RatioToServiceRate { get; set; }

                /// <summary>
                /// 获取或设置达人精确佣金率（单位：万分数）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ratio_ext")]
                [System.Text.Json.Serialization.JsonPropertyName("ratio_ext")]
                public int RatioExt { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置计划列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.SubItem[] SubItemList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_key")]
        [System.Text.Json.Serialization.JsonPropertyName("next_key")]
        public string? NextCursor { get; set; }
    }
}
