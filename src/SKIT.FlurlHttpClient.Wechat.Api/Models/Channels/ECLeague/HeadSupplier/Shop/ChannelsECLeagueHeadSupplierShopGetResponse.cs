namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/headsupplier/shop/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECLeagueHeadSupplierShopGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Shop
            {
                public static class Types
                {
                    public class BaseInfo : ChannelsECLeagueHeadSupplierShopListGetResponse.Types.Shop.Types.BaseInfo
                    {
                    }

                    public class DataInfo
                    {
                        /// <summary>
                        /// 获取或设置合作动销 GMV（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("gmv")]
                        [System.Text.Json.Serialization.JsonPropertyName("gmv")]
                        public int GMV { get; set; }

                        /// <summary>
                        /// 获取或设置历史合作商品数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_number")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_number")]
                        public int ProductCount { get; set; }

                        /// <summary>
                        /// 获取或设置今日新增合作商品数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_number_today")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_number_today")]
                        public int ProductCountToday { get; set; }

                        /// <summary>
                        /// 获取或设置今日动销商品数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_number_sold_today")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_number_sold_today")]
                        public int ProductCountSoldToday { get; set; }

                        /// <summary>
                        /// 获取或设置已结算服务费（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("settle_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("settle_amount")]
                        public int SettleAmount { get; set; }

                        /// <summary>
                        /// 获取或设置预计待结算服务费（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("unsettle_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("unsettle_amount")]
                        public int UnsettleAmount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置合作状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置开始合作时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("approved_time")]
                [System.Text.Json.Serialization.JsonPropertyName("approved_time")]
                public long ApprovedTimestamp { get; set; }

                /// <summary>
                /// 获取或设置小店基础信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("base_info")]
                [System.Text.Json.Serialization.JsonPropertyName("base_info")]
                public Types.BaseInfo BaseInfo { get; set; } = default!;

                /// <summary>
                /// 获取或设置小店数据信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("data_info")]
                [System.Text.Json.Serialization.JsonPropertyName("data_info")]
                public Types.DataInfo DataInfo { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置合作小店信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_detail")]
        public Types.Shop Shop { get; set; } = default!;
    }
}
