namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/qic/inspect/submit 接口的请求。</para>
    /// </summary>
    public class ChannelsECQICInspectSubmitRequest : WechatApiRequest, IInferable<ChannelsECQICInspectSubmitRequest, ChannelsECQICInspectSubmitResponse>
    {
        public static class Types
        {
            public class InspectInfo
            {
                public static class Types
                {
                    public class Box
                    {
                        /// <summary>
                        /// 获取或设置包装盒 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("boxId")]
                        [System.Text.Json.Serialization.JsonPropertyName("boxId")]
                        public int Id { get; set; }

                        /// <summary>
                        /// 获取或设置包装盒名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("boxName")]
                        [System.Text.Json.Serialization.JsonPropertyName("boxName")]
                        public string Name { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置包装盒数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("boxNum")]
                        [System.Text.Json.Serialization.JsonPropertyName("boxNum")]
                        public int Count { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置快递公司 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_id")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
                public string DeliveryId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置备用快递公司 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("backup_delivery_id")]
                [System.Text.Json.Serialization.JsonPropertyName("backup_delivery_id")]
                public string? BackupDeliveryId { get; set; }

                /// <summary>
                /// 获取或设置快递公司产品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_product_id")]
                public int? DeliveryProductId { get; set; }

                /// <summary>
                /// 获取或设置备用快递公司产品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("backup_delivery_product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("backup_delivery_product_id")]
                public int? BackupDeliveryProductId { get; set; }

                /// <summary>
                /// 获取或设置是否物流保价。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("express_insure")]
                [System.Text.Json.Serialization.JsonPropertyName("express_insure")]
                public bool EnableExpressInsure { get; set; }

                /// <summary>
                /// 获取或设置保价金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("express_insure_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("express_insure_amount")]
                public int? ExpressInsureAmount { get; set; }

                /// <summary>
                /// 获取或设置保价类型 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_insure_id")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_insure_id")]
                public string? DeliveryInsureId { get; set; }

                /// <summary>
                /// 获取或设置备用是否物流保价。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("backup_express_insure")]
                [System.Text.Json.Serialization.JsonPropertyName("backup_express_insure")]
                public bool BackupEnableExpressInsure { get; set; }

                /// <summary>
                /// 获取或设置备用保价金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("backup_express_insure_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("backup_express_insure_amount")]
                public int? BackupExpressInsureAmount { get; set; }

                /// <summary>
                /// 获取或设置备用保价类型 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("backup_delivery_insure_id")]
                [System.Text.Json.Serialization.JsonPropertyName("backup_delivery_insure_id")]
                public string? BackupDeliveryInsureId { get; set; }

                /// <summary>
                /// 获取或设置是否合并发货。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("express_merge")]
                [System.Text.Json.Serialization.JsonPropertyName("express_merge")]
                public bool IsExpressMerged { get; set; }

                /// <summary>
                /// 获取或设置售后拦截策略。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_intercept")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_intercept")]
                public int RefundInterceptType { get; set; }

                /// <summary>
                /// 获取或设置质检仓名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("warehouse_name")]
                [System.Text.Json.Serialization.JsonPropertyName("warehouse_name")]
                public string WarehouseName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置质检仓地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("warehouse_addr")]
                [System.Text.Json.Serialization.JsonPropertyName("warehouse_addr")]
                public string WarehouseAddress { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置质检机构 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("inspect_org_id")]
                [System.Text.Json.Serialization.JsonPropertyName("inspect_org_id")]
                public string InspectOrganizationId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置质检机构名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("inspect_org_name")]
                [System.Text.Json.Serialization.JsonPropertyName("inspect_org_name")]
                public string InspectOrganizationName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置备注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remark")]
                [System.Text.Json.Serialization.JsonPropertyName("remark")]
                public string Remark { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置质检信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inspect_info")]
        [System.Text.Json.Serialization.JsonPropertyName("inspect_info")]
        public Types.InspectInfo InspectInfo { get; set; } = new Types.InspectInfo();
    }
}
