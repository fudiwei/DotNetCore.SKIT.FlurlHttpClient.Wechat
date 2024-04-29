namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/stock/getflow 接口的响应。</para>
    /// </summary>
    public class ChannelsECProductStockGetFlowResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class StockFlow
                    {
                        public static class Types
                        {
                            public class ExtendedInfo
                            {
                                /// <summary>
                                /// 获取或设置归还的源库存子类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("unmove_from_stock_sub_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("unmove_from_stock_sub_type")]
                                public int? UnmoveFromStockSubType { get; set; }

                                /// <summary>
                                /// 获取或设置分配的目标库存子类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("move_to_stock_sub_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("move_to_stock_sub_type")]
                                public int? MoveToStockSubType { get; set; }

                                /// <summary>
                                /// 获取或设置操作来源。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("upload_source")]
                                [System.Text.Json.Serialization.JsonPropertyName("upload_source")]
                                public int? UploadSource { get; set; }

                                /// <summary>
                                /// 获取或设置订单 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("order_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                                public string? OrderId { get; set; }

                                /// <summary>
                                /// 获取或设置区域仓库 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("out_warehouse_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("out_warehouse_id")]
                                public string? OutWarehouseId { get; set; }

                                /// <summary>
                                /// 获取或设置限时抢购任务 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("limited_discount_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("limited_discount_id")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public long? LimitedDiscountTaskId { get; set; }

                                /// <summary>
                                /// 获取或设置达人的视频号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("finder_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("finder_id")]
                                public string? FinderId { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置操作数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("amount")]
                        public int Amount { get; set; }

                        /// <summary>
                        /// 获取或设置开始数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("beginning_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("beginning_amount")]
                        public int BeginningAmount { get; set; }

                        /// <summary>
                        /// 获取或设置结束数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ending_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("ending_amount")]
                        public int EndingAmount { get; set; }

                        /// <summary>
                        /// 获取或设置库存子类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("stock_sub_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("stock_sub_type")]
                        public int StockSubType { get; set; }

                        /// <summary>
                        /// 获取或设置库存事件类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("op_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("op_type")]
                        public int OperateType { get; set; }

                        /// <summary>
                        /// 获取或设置流水发生时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("update_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                        public long UpdateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置额外信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ext_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("ext_info")]
                        public Types.ExtendedInfo? ExtendedInfo { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置库存流水列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock_flow_info_list")]
                [System.Text.Json.Serialization.JsonPropertyName("stock_flow_info_list")]
                public Types.StockFlow[] StockFlowList { get; set; } = default!;

                /// <summary>
                /// 获取或设置下一页分页游标。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("next_key")]
                [System.Text.Json.Serialization.JsonPropertyName("next_key")]
                public string? NextCursor { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
