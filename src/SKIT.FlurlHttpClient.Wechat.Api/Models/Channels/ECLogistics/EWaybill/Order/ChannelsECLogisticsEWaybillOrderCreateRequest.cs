using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/logistics/ewaybill/biz/order/create 接口的请求。</para>
    /// </summary>
    public class ChannelsECLogisticsEWaybillOrderCreateRequest : WechatApiRequest, IInferable<ChannelsECLogisticsEWaybillOrderCreateRequest, ChannelsECLogisticsEWaybillOrderCreateResponse>
    {
        public static class Types
        {
            public class Address : ChannelsECLogisticsEWaybillOrderPrecreateRequest.Types.Address
            {
            }

            public class Order : ChannelsECLogisticsEWaybillOrderPrecreateRequest.Types.Order
            {
                public static new class Types
                {
                    public class Goods : ChannelsECLogisticsEWaybillOrderPrecreateRequest.Types.Order.Types.Goods
                    {
                        /// <summary>
                        /// 获取或设置商家自定义商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("out_product_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("out_product_id")]
                        public string? OutProductId { get; set; }

                        /// <summary>
                        /// 获取或设置商家自定义 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("out_sku_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("out_sku_id")]
                        public string? OutSKUId { get; set; }

                        /// <summary>
                        /// 获取或设置商家自定义商品详情。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("out_goods_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("out_goods_info")]
                        public string? OutGoodsInfo { get; set; }
                    }
                }
            }

            public class OrderVas
            {
                /// <summary>
                /// 获取或设置增值服务类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("vas_type")]
                [System.Text.Json.Serialization.JsonPropertyName("vas_type")]
                public string VasType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置增值服务描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("vas_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("vas_detail")]
                public string? VasDetail { get; set; }

                /// <summary>
                /// 获取或设置增值服务值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("vas_value")]
                [System.Text.Json.Serialization.JsonPropertyName("vas_value")]
                public string? VasValue { get; set; }
            }

            public class EWaybillExtra
            {
                /// <summary>
                /// 获取或设置温层信息类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("temperature_range")]
                [System.Text.Json.Serialization.JsonPropertyName("temperature_range")]
                public int? TemperatureRangeType { get; set; }

                /// <summary>
                /// 获取或设置包裹总重量（单位：克）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("package_weight_g")]
                [System.Text.Json.Serialization.JsonPropertyName("package_weight_g")]
                public int? PackageWeight { get; set; }

                /// <summary>
                /// 获取或设置包裹长度（单位：厘米）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("package_space_x")]
                [System.Text.Json.Serialization.JsonPropertyName("package_space_x")]
                public int? PackageLength { get; set; }

                /// <summary>
                /// 获取或设置包裹宽度（单位：厘米）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("package_space_y")]
                [System.Text.Json.Serialization.JsonPropertyName("package_space_y")]
                public int? PackageWidth { get; set; }

                /// <summary>
                /// 获取或设置包裹高度（单位：厘米）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("package_space_z")]
                [System.Text.Json.Serialization.JsonPropertyName("package_space_z")]
                public int? PackageHeight { get; set; }

                /// <summary>
                /// 获取或设置包裹体积（单位：立方厘米）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("package_volume_ccm")]
                [System.Text.Json.Serialization.JsonPropertyName("package_volume_ccm")]
                public int? PackageVolume { get; set; }

                /// <summary>
                /// 获取或设置扩展字段。
                /// </summary>
                [Newtonsoft.Json.JsonExtensionData]
                [System.Text.Json.Serialization.JsonExtensionData]
                public IDictionary<string, object>? ExtensionData { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置快递公司 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_id")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
        public string DeliveryId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置电子面单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ewaybill_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("ewaybill_order_id")]
        public string EWaybillOrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置网点编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("site_code")]
        [System.Text.Json.Serialization.JsonPropertyName("site_code")]
        public string? SiteCode { get; set; }

        /// <summary>
        /// 获取或设置店铺 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_id")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_id")]
        public string ShopId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置电子面单账号 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ewaybill_acct_id")]
        [System.Text.Json.Serialization.JsonPropertyName("ewaybill_acct_id")]
        public string AccountId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置面单模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string? TemplateId { get; set; }

        /// <summary>
        /// 获取或设置寄件人信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sender")]
        [System.Text.Json.Serialization.JsonPropertyName("sender")]
        public Types.Address Sender { get; set; } = new Types.Address();

        /// <summary>
        /// 获取或设置收件人信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("receiver")]
        [System.Text.Json.Serialization.JsonPropertyName("receiver")]
        public Types.Address Receiver { get; set; } = new Types.Address();

        /// <summary>
        /// 获取或设置退货地址信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("return_address")]
        [System.Text.Json.Serialization.JsonPropertyName("return_address")]
        public Types.Address? ReturnAddress { get; set; }

        /// <summary>
        /// 获取或设置订单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ec_order_list")]
        [System.Text.Json.Serialization.JsonPropertyName("ec_order_list")]
        public IList<Types.Order> OrderList { get; set; } = new List<Types.Order>();

        /// <summary>
        /// 获取或设置备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        [System.Text.Json.Serialization.JsonPropertyName("remark")]
        public string? Remark { get; set; }

        /// <summary>
        /// 获取或设置订单类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_type")]
        [System.Text.Json.Serialization.JsonPropertyName("order_type")]
        public int? OrderType { get; set; }

        /// <summary>
        /// 获取或设置增值服务列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_vas_list")]
        [System.Text.Json.Serialization.JsonPropertyName("order_vas_list")]
        public IList<Types.OrderVas>? OrderVasList { get; set; }

        /// <summary>
        /// 获取或设置面单补充信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ext_info")]
        [System.Text.Json.Serialization.JsonPropertyName("ext_info")]
        public Types.EWaybillExtra? EWaybillExtra { get; set; }
    }
}
