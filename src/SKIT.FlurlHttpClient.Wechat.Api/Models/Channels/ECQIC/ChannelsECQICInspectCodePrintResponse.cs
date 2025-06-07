namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/qic/inspect/code/print 接口的响应。</para>
    /// </summary>
    public class ChannelsECQICInspectCodePrintResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
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
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置包装盒数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("boxNum")]
                        [System.Text.Json.Serialization.JsonPropertyName("boxNum")]
                        public int Count { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置小店 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("channelAppId")]
                [System.Text.Json.Serialization.JsonPropertyName("channelAppId")]
                public string ChannelAppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置商家名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchantName")]
                [System.Text.Json.Serialization.JsonPropertyName("merchantName")]
                public string MerchantName { get; set; } = default!;

                /// <summary>
                /// 获取或设置快递公司 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("deliveryId")]
                [System.Text.Json.Serialization.JsonPropertyName("deliveryId")]
                public string DeliveryId { get; set; } = default!;

                /// <summary>
                /// 获取或设置快递公司名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("deliveryName")]
                [System.Text.Json.Serialization.JsonPropertyName("deliveryName")]
                public string DeliveryName { get; set; } = default!;

                /// <summary>
                /// 获取或设置备用快递公司 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("backupDeliveryId")]
                [System.Text.Json.Serialization.JsonPropertyName("backupDeliveryId")]
                public string? BackupDeliveryId { get; set; }

                /// <summary>
                /// 获取或设置备用快递公司名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("backupDeliveryName")]
                [System.Text.Json.Serialization.JsonPropertyName("backupDeliveryName")]
                public string? BackupDeliveryName { get; set; }

                /// <summary>
                /// 获取或设置商品镶嵌材质。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("embedGoodsMaterial")]
                [System.Text.Json.Serialization.JsonPropertyName("embedGoodsMaterial")]
                public string? EmbedGoodsMaterial { get; set; }

                /// <summary>
                /// 获取或设置是否合并发货。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expressMerge")]
                [System.Text.Json.Serialization.JsonPropertyName("expressMerge")]
                public bool IsExpressMerged { get; set; }

                /// <summary>
                /// 获取或设置商品描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goodsDesc")]
                [System.Text.Json.Serialization.JsonPropertyName("goodsDesc")]
                public string GoodsDescription { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品主材质。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goodsMainMaterial")]
                [System.Text.Json.Serialization.JsonPropertyName("goodsMainMaterial")]
                public string GoodsMainMaterial { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品配件材质。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goodsPartsMaterial")]
                [System.Text.Json.Serialization.JsonPropertyName("goodsPartsMaterial")]
                public string? GoodsPartsMaterial { get; set; }

                /// <summary>
                /// 获取或设置商品名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goodsName")]
                [System.Text.Json.Serialization.JsonPropertyName("goodsName")]
                public string GoodsName { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goodsNum")]
                [System.Text.Json.Serialization.JsonPropertyName("goodsNum")]
                public int GoodsCount { get; set; }

                /// <summary>
                /// 获取或设置质检仓 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("inspectBaseId")]
                [System.Text.Json.Serialization.JsonPropertyName("inspectBaseId")]
                public string WarehouseId { get; set; } = default!;

                /// <summary>
                /// 获取或设置质检仓名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("inspectBaseName")]
                [System.Text.Json.Serialization.JsonPropertyName("inspectBaseName")]
                public string WarehouseName { get; set; } = default!;

                /// <summary>
                /// 获取或设置质检码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("inspectCode")]
                [System.Text.Json.Serialization.JsonPropertyName("inspectCode")]
                public string InspectCode { get; set; } = default!;

                /// <summary>
                /// 获取或设置质检机构 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("inspectOrgId")]
                [System.Text.Json.Serialization.JsonPropertyName("inspectOrgId")]
                public string InspectOrganizationId { get; set; } = default!;

                /// <summary>
                /// 获取或设置质检机构名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("inspectOrgName")]
                [System.Text.Json.Serialization.JsonPropertyName("inspectOrgName")]
                public string InspectOrganizationName { get; set; } = default!;

                /// <summary>
                /// 获取或设置质检机构简称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("inspectOrgShortName")]
                [System.Text.Json.Serialization.JsonPropertyName("inspectOrgShortName")]
                public string InspectOrganizationShortName { get; set; } = default!;

                /// <summary>
                /// 获取或设置包装盒列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("boxDTOList")]
                [System.Text.Json.Serialization.JsonPropertyName("boxDTOList")]
                public Types.Box[]? BoxList { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("orderId")]
                [System.Text.Json.Serialization.JsonPropertyName("orderId")]
                public string OrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否加急订单。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("urgentOrder")]
                [System.Text.Json.Serialization.JsonPropertyName("urgentOrder")]
                public bool IsUrgentOrder { get; set; }

                /// <summary>
                /// 获取或设置经过 Base64 编码的打印模板数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("printInfo")]
                [System.Text.Json.Serialization.JsonPropertyName("printInfo")]
                public string EncodingPrintData { get; set; } = default!;
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
