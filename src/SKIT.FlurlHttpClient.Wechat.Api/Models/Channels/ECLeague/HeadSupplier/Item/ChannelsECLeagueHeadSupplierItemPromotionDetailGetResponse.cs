namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/headsupplier/item/promotiondetail/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECLeagueHeadSupplierItemPromotionDetailGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Product
            {
                public static class Types
                {
                    public class CommissionInfo
                    {
                        public static class Types
                        {
                            public class NormalCommissionInfo
                            {
                                /// <summary>
                                /// 获取或设置佣金费率（单位：十万分数）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ratio")]
                                [System.Text.Json.Serialization.JsonPropertyName("ratio")]
                                public int Ratio { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置计划类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("plan_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("plan_type")]
                        public int PlanType { get; set; }

                        /// <summary>
                        /// 获取或设置佣金分配类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("commission_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("commission_type")]
                        public int CommissionType { get; set; }

                        /// <summary>
                        /// 获取或设置佣金费率（单位：十万分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ratio")]
                        [System.Text.Json.Serialization.JsonPropertyName("ratio")]
                        public int CommissionRatio { get; set; }

                        /// <summary>
                        /// 获取或设置服务费费率（单位：十万分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("service_ratio")]
                        [System.Text.Json.Serialization.JsonPropertyName("service_ratio")]
                        public int ServiceFeeRatio { get; set; }

                        /// <summary>
                        /// 获取或设置计划开始时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("start_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                        public long StartTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置计划结束时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("end_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                        public long EndTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置该商品普通推广下的佣金信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("normal_commission_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("normal_commission_info")]
                        public Types.NormalCommissionInfo? NormalCommissionInfo { get; set; }
                    }

                    public class HeadSupplierInfo
                    {
                        /// <summary>
                        /// 获取或设置团长 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("appid")]
                        [System.Text.Json.Serialization.JsonPropertyName("appid")]
                        public string AppId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置团长名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;
                    }

                    public class CooperativeInfo
                    {
                        /// <summary>
                        /// 获取或设置合作状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cooperative_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("cooperative_status")]
                        public int CooperativeStatus { get; set; }

                        /// <summary>
                        /// 获取或设置是否隐藏。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_hidden")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_hidden")]
                        public bool IsHidden { get; set; }

                        /// <summary>
                        /// 获取或设置带货链接。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("link")]
                        [System.Text.Json.Serialization.JsonPropertyName("link")]
                        public string? Link { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置小店 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shop_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("shop_appid")]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long ProductId { get; set; }

                /// <summary>
                /// 获取或设置商品来源。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spu_source")]
                [System.Text.Json.Serialization.JsonPropertyName("spu_source")]
                public int SPUSource { get; set; }

                /// <summary>
                /// 获取或设置佣金信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("commission_info")]
                [System.Text.Json.Serialization.JsonPropertyName("commission_info")]
                public Types.CommissionInfo CommissionInfo { get; set; } = default!;

                /// <summary>
                /// 获取或设置供货机构信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("head_supplier_info")]
                [System.Text.Json.Serialization.JsonPropertyName("head_supplier_info")]
                public Types.HeadSupplierInfo HeadSupplierInfo { get; set; } = default!;

                /// <summary>
                /// 获取或设置合作信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cooperative_info")]
                [System.Text.Json.Serialization.JsonPropertyName("cooperative_info")]
                public Types.CooperativeInfo CooperativeInfo { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item")]
        [System.Text.Json.Serialization.JsonPropertyName("item")]
        public Types.Product Product { get; set; } = default!;
    }
}
