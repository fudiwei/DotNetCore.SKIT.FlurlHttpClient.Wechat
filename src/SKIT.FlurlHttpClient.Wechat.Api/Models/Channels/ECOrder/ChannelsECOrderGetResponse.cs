using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECOrderGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Order
            {
                public static class Types
                {
                    public class OrderDetail
                    {
                        public static class Types
                        {
                            public class Product
                            {
                                public static class Types
                                {
                                    public class Attribute : ChannelsECProductGetResponse.Types.Product.Types.Attribute
                                    {
                                    }

                                    public class ExtraService
                                    {
                                        /// <summary>
                                        /// 获取或设置是否支持七天无理由退货。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("seven_day_return")]
                                        [System.Text.Json.Serialization.JsonPropertyName("seven_day_return")]
                                        public int SevenDayReturn { get; set; }

                                        /// <summary>
                                        /// 获取或设置是否支持运费险。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("freight_insurance")]
                                        [System.Text.Json.Serialization.JsonPropertyName("freight_insurance")]
                                        public int FreightInsurance { get; set; }
                                    }

                                    public class SKUDeliver
                                    {
                                        /// <summary>
                                        /// 获取或设置商品发货类型。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("stock_type")]
                                        [System.Text.Json.Serialization.JsonPropertyName("stock_type")]
                                        public int StockType { get; set; }

                                        /// <summary>
                                        /// 获取或设置预计发货时间戳。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("predict_delivery_time")]
                                        [System.Text.Json.Serialization.JsonPropertyName("predict_delivery_time")]
                                        public long? PredictDeliveryTimestamp { get; set; }

                                        /// <summary>
                                        /// 获取或设置预售类型。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("full_payment_presale_delivery_type")]
                                        [System.Text.Json.Serialization.JsonPropertyName("full_payment_presale_delivery_type")]
                                        public int? FullPaymentPresaleDeliveryType { get; set; }
                                    }

                                    public class OrderProductCoupon
                                    {
                                        /// <summary>
                                        /// 获取或设置优惠券类型。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("coupon_type")]
                                        [System.Text.Json.Serialization.JsonPropertyName("coupon_type")]
                                        public int CouponType { get; set; }

                                        /// <summary>
                                        /// 获取或设置用户优惠券 ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("user_coupon_id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("user_coupon_id")]
                                        public string? UserCouponId { get; set; }

                                        /// <summary>
                                        /// 获取或设置优惠券 ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("coupon_id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("coupon_id")]
                                        public string? CouponId { get; set; }

                                        /// <summary>
                                        /// 获取或设置优惠金额（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("discounted_price")]
                                        [System.Text.Json.Serialization.JsonPropertyName("discounted_price")]
                                        public int? DiscountedPrice { get; set; }
                                    }

                                    public class Voucher
                                    {
                                        /// <summary>
                                        /// 获取或设置团购优惠券码。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("voucher_code")]
                                        [System.Text.Json.Serialization.JsonPropertyName("voucher_code")]
                                        public string VoucherCode { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置团购优惠券类型。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("voucher_type")]
                                        [System.Text.Json.Serialization.JsonPropertyName("voucher_type")]
                                        public int VoucherType { get; set; }

                                        /// <summary>
                                        /// 获取或设置团购优惠券价格（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("voucher_buy_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("voucher_buy_amount")]
                                        public int VoucherBuyAmount { get; set; }

                                        /// <summary>
                                        /// 获取或设置次卡序号标识。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("time_index")]
                                        [System.Text.Json.Serialization.JsonPropertyName("time_index")]
                                        public int? TimeIndex { get; set; }
                                    }

                                    public class ChangeSKUInfo
                                    {
                                        /// <summary>
                                        /// 获取或设置发货前更换 SKU 是否成功。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("preshipment_change_sku_success")]
                                        [System.Text.Json.Serialization.JsonPropertyName("preshipment_change_sku_success")]
                                        public bool IsPreshipmentChangeSKUSuccessful { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置商品 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public long ProductId { get; set; }

                                /// <summary>
                                /// 获取或设置 SKU ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public long SKUId { get; set; }

                                /// <summary>
                                /// 获取或设置商品数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_cnt")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_cnt")]
                                public int Count { get; set; }

                                /// <summary>
                                /// 获取或设置商品编码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_code")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_code")]
                                public string? SKUCode { get; set; }

                                /// <summary>
                                /// 获取或设置正在售后流程中的商品数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("on_aftersale_sku_cnt")]
                                [System.Text.Json.Serialization.JsonPropertyName("on_aftersale_sku_cnt")]
                                public int OnAftersaleCount { get; set; }

                                /// <summary>
                                /// 获取或设置已完成售后流程的商品数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("finish_aftersale_sku_cnt")]
                                [System.Text.Json.Serialization.JsonPropertyName("finish_aftersale_sku_cnt")]
                                public int FinishAftersaleCount { get; set; }

                                /// <summary>
                                /// 获取或设置商品标题。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("title")]
                                [System.Text.Json.Serialization.JsonPropertyName("title")]
                                public string Title { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品缩略图 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("thumb_img")]
                                [System.Text.Json.Serialization.JsonPropertyName("thumb_img")]
                                public string ThumbnailImageUrl { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品常量编号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_unique_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_unique_id")]
                                public string? ProductUniqueId { get; set; }

                                /// <summary>
                                /// 获取或设置商品原价（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("market_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("market_price")]
                                public int MarketPrice { get; set; }

                                /// <summary>
                                /// 获取或设置商品售价（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sale_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("sale_price")]
                                public int SalePrice { get; set; }

                                /// <summary>
                                /// 获取或设置商品实付价（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("real_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("real_price")]
                                public int? RealPrice { get; set; }

                                /// <summary>
                                /// 获取或设置优惠后 SKU 总价（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("estimate_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("estimate_price")]
                                public int? EstimatePrice { get; set; }

                                /// <summary>
                                /// 获取或设置商家优惠金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("merchant_discounted_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("merchant_discounted_price")]
                                public int? MerchantDiscountedPrice { get; set; }

                                /// <summary>
                                /// 获取或设置达人优惠金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("finder_discounted_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("finder_discounted_price")]
                                public int? FinderDiscountedPrice { get; set; }

                                /// <summary>
                                /// 获取或设置是否修改过价格。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("is_change_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("is_change_price")]
                                public bool? IsPriceChanged { get; set; }

                                /// <summary>
                                /// 获取或设置改价后 SKU 总价（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("change_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("change_price")]
                                public int? ChangePrice { get; set; }

                                /// <summary>
                                /// 获取或设置是否使用了会员积分抵扣。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("use_deduction")]
                                [System.Text.Json.Serialization.JsonPropertyName("use_deduction")]
                                public bool? IsUseDeduction { get; set; }

                                /// <summary>
                                /// 获取或设置会员积分抵扣金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("deduction_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("deduction_price")]
                                public int? DeductionPrice { get; set; }

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
                                /// 获取或设置外部仓库 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("out_warehouse_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("out_warehouse_id")]
                                public string? OutWarehouseId { get; set; }

                                /// <summary>
                                /// 获取或设置商品属性列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_attrs")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_attrs")]
                                public Types.Attribute[]? AttributeList { get; set; }

                                /// <summary>
                                /// 获取或设置商品发货信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_deliver_info")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_deliver_info")]
                                public Types.SKUDeliver? SKUDeliver { get; set; }

                                /// <summary>
                                /// 获取或设置额外的服务信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("extra_service")]
                                [System.Text.Json.Serialization.JsonPropertyName("extra_service")]
                                public Types.ExtraService? ExtraService { get; set; }

                                /// <summary>
                                /// 获取或设置商品优惠券信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("order_product_coupon_info_list")]
                                [System.Text.Json.Serialization.JsonPropertyName("order_product_coupon_info_list")]
                                public Types.OrderProductCoupon[]? OrderProductCouponList { get; set; }

                                /// <summary>
                                /// 获取或设置商品发货截止日期时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("delivery_deadline")]
                                [System.Text.Json.Serialization.JsonPropertyName("delivery_deadline")]
                                public long? DeliveryDeadlineTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置团购优惠列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("voucher_list")]
                                [System.Text.Json.Serialization.JsonPropertyName("voucher_list")]
                                public Types.Voucher[]? VoucherList { get; set; }

                                /// <summary>
                                /// 获取或设置是否为赠品。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("is_free_gift")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("is_free_gift")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                                public bool? IsFreeGift { get; set; }

                                /// <summary>
                                /// 获取或设置额外的服务信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("change_sku_info")]
                                [System.Text.Json.Serialization.JsonPropertyName("change_sku_info")]
                                public Types.ChangeSKUInfo? ChangeSKUInfo { get; set; }
                            }

                            public class Payment
                            {
                                /// <summary>
                                /// 获取或设置预支付单号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("prepay_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("prepay_id")]
                                public string PrepayId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置预支付时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("prepay_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("prepay_time")]
                                public long PrepayTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置微信支付交易单号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("transaction_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
                                public string? TransactionId { get; set; }

                                /// <summary>
                                /// 获取或设置付款时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("pay_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("pay_time")]
                                public long? PayTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置支付方式。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("payment_method")]
                                [System.Text.Json.Serialization.JsonPropertyName("payment_method")]
                                public int? PaymentMethod { get; set; }
                            }

                            public class Amount
                            {
                                /// <summary>
                                /// 获取或设置商品金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_price")]
                                public int ProductPrice { get; set; }

                                /// <summary>
                                /// 获取或设置订单金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("order_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("order_price")]
                                public int OrderPrice { get; set; }

                                /// <summary>
                                /// 获取或设置运费（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("freight")]
                                [System.Text.Json.Serialization.JsonPropertyName("freight")]
                                public int FreightPrice { get; set; }

                                /// <summary>
                                /// 获取或设置优惠金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("discounted_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("discounted_price")]
                                public int DiscountedPrice { get; set; }

                                /// <summary>
                                /// 获取或设置是否有优惠。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("is_discounted")]
                                [System.Text.Json.Serialization.JsonPropertyName("is_discounted")]
                                public bool IsDiscounted { get; set; }

                                /// <summary>
                                /// 获取或设置订单原始价格（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("original_order_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("original_order_price")]
                                public int? OriginalOrderPrice { get; set; }

                                /// <summary>
                                /// 获取或设置商品预估价格（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("estimate_product_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("estimate_product_price")]
                                public int? EstimatedProductPrice { get; set; }

                                /// <summary>
                                /// 获取或设置改价后降低金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("change_down_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("change_down_price")]
                                public int? ChangedDownPrice { get; set; }

                                /// <summary>
                                /// 获取或设置改价后运费（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("change_freight")]
                                [System.Text.Json.Serialization.JsonPropertyName("change_freight")]
                                public int? ChangedFreightPrice { get; set; }

                                /// <summary>
                                /// 获取或设置是否修改运费。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("is_change_freight")]
                                [System.Text.Json.Serialization.JsonPropertyName("is_change_freight")]
                                public bool? IsFreightChanged { get; set; }

                                /// <summary>
                                /// 获取或设置是否使用了会员积分抵扣。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("use_deduction")]
                                [System.Text.Json.Serialization.JsonPropertyName("use_deduction")]
                                public bool? IsUseDeduction { get; set; }

                                /// <summary>
                                /// 获取或设置会员积分抵扣金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("deduction_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("deduction_price")]
                                public int? DeductionPrice { get; set; }

                                /// <summary>
                                /// 获取或设置商家实收金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("merchant_receieve_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("merchant_receieve_price")]
                                public int MerchantReceievePrice { get; set; }

                                /// <summary>
                                /// 获取或设置商家优惠金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("merchant_discounted_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("merchant_discounted_price")]
                                public int MerchantDiscountedPrice { get; set; }

                                /// <summary>
                                /// 获取或设置达人优惠金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("finder_discounted_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("finder_discounted_price")]
                                public int FinderDiscountedPrice { get; set; }
                            }

                            public class Delivery
                            {
                                public static class Types
                                {
                                    public class DeliveryProduct
                                    {
                                        public static class Types
                                        {
                                            public class Product
                                            {
                                                /// <summary>
                                                /// 获取或设置商品 ID。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("product_id")]
                                                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                                public long ProductId { get; set; }

                                                /// <summary>
                                                /// 获取或设置 SKU ID。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("sku_id")]
                                                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                                public long SKUId { get; set; }

                                                /// <summary>
                                                /// 获取或设置商品数量。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("product_cnt")]
                                                [System.Text.Json.Serialization.JsonPropertyName("product_cnt")]
                                                public int Count { get; set; }
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置快递方式。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("deliver_type")]
                                        [System.Text.Json.Serialization.JsonPropertyName("deliver_type")]
                                        public int DeliverType { get; set; }

                                        /// <summary>
                                        /// 获取或设置快递公司 ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("delivery_id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
                                        public string DeliveryId { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置快递公司名称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("delivery_name")]
                                        [System.Text.Json.Serialization.JsonPropertyName("delivery_name")]
                                        public string DeliveryName { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置快递单号。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("waybill_id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("waybill_id")]
                                        public string WaybillId { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置发货时间戳。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("delivery_time")]
                                        [System.Text.Json.Serialization.JsonPropertyName("delivery_time")]
                                        public long DeliveryTimestamp { get; set; }

                                        /// <summary>
                                        /// 获取或设置商品列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("product_infos")]
                                        [System.Text.Json.Serialization.JsonPropertyName("product_infos")]
                                        public Types.Product[] ProductList { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置发货地址信息。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("delivery_address")]
                                        [System.Text.Json.Serialization.JsonPropertyName("delivery_address")]
                                        public Address? DeliveryAddress { get; set; }
                                    }

                                    public class Address : ChannelsECMerchantAddressGetResponse.Types.AddressDetail.Types.Address
                                    {
                                        public static class Types
                                        {
                                            public class TelNumberExtendedInfo
                                            {
                                                /// <summary>
                                                /// 获取或设置脱敏手机号。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("real_tel_number")]
                                                [System.Text.Json.Serialization.JsonPropertyName("real_tel_number")]
                                                public string? RealTelNumber { get; set; }

                                                /// <summary>
                                                /// 获取或设置虚拟号码。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("virtual_tel_number")]
                                                [System.Text.Json.Serialization.JsonPropertyName("virtual_tel_number")]
                                                public string? VirtualTelNumber { get; set; }

                                                /// <summary>
                                                /// 获取或设置主动兑换的虚拟号码过期时间戳。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("virtual_tel_expire_time")]
                                                [System.Text.Json.Serialization.JsonPropertyName("virtual_tel_expire_time")]
                                                public long? VirtualTelNumberExpireTimestamp { get; set; }

                                                /// <summary>
                                                /// 获取或设置主动兑换虚拟号码次数。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("get_virtual_tel_cnt")]
                                                [System.Text.Json.Serialization.JsonPropertyName("get_virtual_tel_cnt")]
                                                public int? GetVirtualTelNumberCount { get; set; }
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置当前店铺下一个唯一的用户收货地址标识。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("hash_code")]
                                        [System.Text.Json.Serialization.JsonPropertyName("hash_code")]
                                        public string? HashCode { get; set; }

                                        /// <summary>
                                        /// 获取或设置虚拟号码。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("virtual_order_tel_number")]
                                        [System.Text.Json.Serialization.JsonPropertyName("virtual_order_tel_number")]
                                        public string? VirtualTelNumber { get; set; }

                                        /// <summary>
                                        /// 获取或设置是否使用虚拟号码。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("use_tel_number")]
                                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                                        [System.Text.Json.Serialization.JsonPropertyName("use_tel_number")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                                        public bool? IsVirtualTelNumber { get; set; }

                                        /// <summary>
                                        /// 获取或设置额外的联系方式信息。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("tel_number_ext_info")]
                                        [System.Text.Json.Serialization.JsonPropertyName("tel_number_ext_info")]
                                        public Types.TelNumberExtendedInfo? TelNumberExtendedInfo { get; set; }
                                    }

                                    public class QualityInspection
                                    {
                                        /// <summary>
                                        /// 获取或设置质检状态。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("inspect_status")]
                                        [System.Text.Json.Serialization.JsonPropertyName("inspect_status")]
                                        public int InspectStatus { get; set; }
                                    }

                                    public class Recharge
                                    {
                                        /// <summary>
                                        /// 获取或设置账号充值类型。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("account_type")]
                                        [System.Text.Json.Serialization.JsonPropertyName("account_type")]
                                        public string? AccountType { get; set; }

                                        /// <summary>
                                        /// 获取或设置虚拟商品充值账号。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("account_no")]
                                        [System.Text.Json.Serialization.JsonPropertyName("account_no")]
                                        public string? AccountNumber { get; set; }

                                        /// <summary>
                                        /// 获取或设置用户的微信 OpenId。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("wx_openid")]
                                        [System.Text.Json.Serialization.JsonPropertyName("wx_openid")]
                                        public string? WxOpenId { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置发货方式。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("deliver_method")]
                                [System.Text.Json.Serialization.JsonPropertyName("deliver_method")]
                                public int DeliverMethod { get; set; }

                                /// <summary>
                                /// 获取或设置地址信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("address_info")]
                                [System.Text.Json.Serialization.JsonPropertyName("address_info")]
                                public Types.Address? Address { get; set; }

                                /// <summary>
                                /// 获取或设置用户下单后申请修改的地址信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("address_under_review")]
                                [System.Text.Json.Serialization.JsonPropertyName("address_under_review")]
                                public Types.Address? AddressUnderReview { get; set; }

                                /// <summary>
                                /// 获取或设置发货商品信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("delivery_product_info")]
                                [System.Text.Json.Serialization.JsonPropertyName("delivery_product_info")]
                                public Types.DeliveryProduct[] DeliveryProductList { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置配送完成时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ship_done_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("ship_done_time")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public long? ShippingDoneTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置修改地址申请时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("address_apply_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("address_apply_time")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public long? AddressApplyTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置电子面单代发订单密文。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ewaybill_order_code")]
                                [System.Text.Json.Serialization.JsonPropertyName("ewaybill_order_code")]
                                public string? EWaybillOrderCode { get; set; }

                                /// <summary>
                                /// 获取或设置订单质检类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("quality_inspect_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("quality_inspect_type")]
                                public int? QualityInspectType { get; set; }

                                /// <summary>
                                /// 获取或设置订单质检信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("quality_inspect_info")]
                                [System.Text.Json.Serialization.JsonPropertyName("quality_inspect_info")]
                                public Types.QualityInspection? QualityInspection { get; set; }

                                /// <summary>
                                /// 获取或设置虚拟商品充值账户信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("recharge_info")]
                                [System.Text.Json.Serialization.JsonPropertyName("recharge_info")]
                                public Types.Recharge? Recharge { get; set; }
                            }

                            public class Coupon
                            {
                                /// <summary>
                                /// 获取或设置用户优惠券 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("user_coupon_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("user_coupon_id")]
                                public string? UserCouponId { get; set; }
                            }

                            public class Extra
                            {
                                /// <summary>
                                /// 获取或设置用户备注。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("customer_notes")]
                                [System.Text.Json.Serialization.JsonPropertyName("customer_notes")]
                                public string? CustomerNotes { get; set; }

                                /// <summary>
                                /// 获取或设置商家备注。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("merchant_notes")]
                                [System.Text.Json.Serialization.JsonPropertyName("merchant_notes")]
                                public string? MerchantNotes { get; set; }

                                /// <summary>
                                /// 获取或设置确认收货时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("confirm_receipt_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("confirm_receipt_time")]
                                public long? ConfirmReceiptTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置视频号 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("finder_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("finder_id")]
                                public string? FinderId { get; set; }

                                /// <summary>
                                /// 获取或设置直播 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("live_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("live_id")]
                                public string? LiveId { get; set; }

                                /// <summary>
                                /// 获取或设置单场景。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("order_scene")]
                                [System.Text.Json.Serialization.JsonPropertyName("order_scene")]
                                public int? OrderScene { get; set; }
                            }

                            public class Commission
                            {
                                /// <summary>
                                /// 获取或设置 SKU ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public long SKUId { get; set; }

                                /// <summary>
                                /// 获取或设置分账方昵称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("nickname")]
                                [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                                public string Nickname { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置分账方类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("type")]
                                [System.Text.Json.Serialization.JsonPropertyName("type")]
                                public int Type { get; set; }

                                /// <summary>
                                /// 获取或设置分账状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("status")]
                                [System.Text.Json.Serialization.JsonPropertyName("status")]
                                public int Status { get; set; }

                                /// <summary>
                                /// 获取或设置分账金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                                public int Amount { get; set; }

                                /// <summary>
                                /// 获取或设置达人视频号 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("finder_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("finder_id")]
                                public string? FinderId { get; set; }

                                /// <summary>
                                /// 获取或设置达人 OpenFinderId。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("openfinderid")]
                                [System.Text.Json.Serialization.JsonPropertyName("openfinderid")]
                                public string? OpenFinderId { get; set; }

                                /// <summary>
                                /// 获取或设置新带货平台 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("talent_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("talent_id")]
                                public string? TalentId { get; set; }
                            }

                            public class Settlement
                            {
                                /// <summary>
                                /// 获取或设置预计技术服务费（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("predict_commission_fee")]
                                [System.Text.Json.Serialization.JsonPropertyName("predict_commission_fee")]
                                public int PredictCommissionFee { get; set; }

                                /// <summary>
                                /// 获取或设置实际技术服务费（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("commission_fee")]
                                [System.Text.Json.Serialization.JsonPropertyName("commission_fee")]
                                public int? CommissionFee { get; set; }

                                /// <summary>
                                /// 获取或设置预计人气卡返佣金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("predict_wecoin_commission")]
                                [System.Text.Json.Serialization.JsonPropertyName("predict_wecoin_commission")]
                                public int? PredictWecoinCommission { get; set; }

                                /// <summary>
                                /// 获取或设置实际人气卡返佣金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("wecoin_commission")]
                                [System.Text.Json.Serialization.JsonPropertyName("wecoin_commission")]
                                public int? WecoinCommission { get; set; }

                                /// <summary>
                                /// 获取或设置结算时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("settle_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("settle_time")]
                                public long? SettleTimestamp { get; set; }
                            }

                            public class Sharer
                            {
                                /// <summary>
                                /// 获取或设置分享员的 OpenId。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sharer_openid")]
                                [System.Text.Json.Serialization.JsonPropertyName("sharer_openid")]
                                public string SharerOpenId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置分享员的 UnionId。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sharer_unionid")]
                                [System.Text.Json.Serialization.JsonPropertyName("sharer_unionid")]
                                public string? SharerUnionId { get; set; }

                                /// <summary>
                                /// 获取或设置分享员类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sharer_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("sharer_type")]
                                public int SharerType { get; set; }

                                /// <summary>
                                /// 获取或设置分享场景。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("share_scene")]
                                [System.Text.Json.Serialization.JsonPropertyName("share_scene")]
                                public int ShareScene { get; set; }

                                /// <summary>
                                /// 获取或设置解析完成度。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("handling_progress")]
                                [System.Text.Json.Serialization.JsonPropertyName("handling_progress")]
                                public int HandlingProgress { get; set; }
                            }

                            public class SKUSharer : Sharer
                            {
                                /// <summary>
                                /// 获取或设置 SKU ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public long SKUId { get; set; }

                                /// <summary>
                                /// 获取或设置是否来自企微分享。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("from_wecom")]
                                [System.Text.Json.Serialization.JsonPropertyName("from_wecom")]
                                public bool IsFromWecom { get; set; }
                            }

                            public class AgentFinder
                            {
                                /// <summary>
                                /// 获取或设置授权视频号 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("agent_finder_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("agent_finder_id")]
                                public string AgentFinderId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置授权视频号昵称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("agent_finder_nickname")]
                                [System.Text.Json.Serialization.JsonPropertyName("agent_finder_nickname")]
                                public string AgentFinderNickname { get; set; } = default!;
                            }

                            public class Source
                            {
                                /// <summary>
                                /// 获取或设置 SKU ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public long SKUId { get; set; }

                                /// <summary>
                                /// 获取或设置账号关联类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sale_channel")]
                                [System.Text.Json.Serialization.JsonPropertyName("sale_channel")]
                                public int SaleChannel { get; set; }

                                /// <summary>
                                /// 获取或设置带货账号类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("account_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("account_type")]
                                public int AccountType { get; set; }

                                /// <summary>
                                /// 获取或设置带货账号 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("account_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("account_id")]
                                public string? AccountId { get; set; }

                                /// <summary>
                                /// 获取或设置带货账号昵称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("account_nickname")]
                                [System.Text.Json.Serialization.JsonPropertyName("account_nickname")]
                                public string? AccountNickname { get; set; }

                                /// <summary>
                                /// 获取或设置带货内容类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("content_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("content_type")]
                                public int ContentType { get; set; }

                                /// <summary>
                                /// 获取或设置带货内容 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("content_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("content_id")]
                                public string? ContentId { get; set; }
                            }

                            public class Refund
                            {
                                /// <summary>
                                /// 获取或设置退还运费金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("refund_freight")]
                                [System.Text.Json.Serialization.JsonPropertyName("refund_freight")]
                                public int? RefundFreight { get; set; }
                            }

                            public class GreetingCard
                            {
                                /// <summary>
                                /// 获取或设置贺卡落款。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("giver_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("giver_name")]
                                public string? GiverName { get; set; }

                                /// <summary>
                                /// 获取或设置贺卡称谓。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("receiver_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("receiver_name")]
                                public string? ReceiverName { get; set; }

                                /// <summary>
                                /// 获取或设置贺卡内容。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("greeting_message")]
                                [System.Text.Json.Serialization.JsonPropertyName("greeting_message")]
                                public string? GreetingMessage { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置商品列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_infos")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_infos")]
                        public Types.Product[] ProductList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置支付信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_info")]
                        public Types.Payment Payment { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置金额信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("price_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("price_info")]
                        public Types.Amount Amount { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置快递信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_info")]
                        public Types.Delivery? Delivery { get; set; }

                        /// <summary>
                        /// 获取或设置优惠券信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("coupon_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("coupon_info")]
                        public Types.Coupon? Coupon { get; set; }

                        /// <summary>
                        /// 获取或设置扩展信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ext_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("ext_info")]
                        public Types.Extra? Extra { get; set; }

                        /// <summary>
                        /// 获取或设置分佣信息列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("commission_infos")]
                        [System.Text.Json.Serialization.JsonPropertyName("commission_infos")]
                        public Types.Commission[]? CommissionList { get; set; }

                        /// <summary>
                        /// 获取或设置结算信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("settle_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("settle_info")]
                        public Types.Settlement? Settlement { get; set; }

                        /// <summary>
                        /// 获取或设置分享员信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sharer_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("sharer_info")]
                        public Types.Sharer? Sharer { get; set; }

                        /// <summary>
                        /// 获取或设置 SKU 分享员信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_sharer_infos")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_sharer_infos")]
                        public Types.SKUSharer[]? SKUSharerList { get; set; }

                        /// <summary>
                        /// 获取或设置授权账号信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("agent_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("agent_info")]
                        public Types.AgentFinder? AgentFinder { get; set; }

                        /// <summary>
                        /// 获取或设置订单来源列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("source_infos")]
                        [System.Text.Json.Serialization.JsonPropertyName("source_infos")]
                        public Types.Source[]? SourceList { get; set; }

                        /// <summary>
                        /// 获取或设置退款信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_info")]
                        public Types.Refund? Refund { get; set; }

                        /// <summary>
                        /// 获取或设置需代写的商品贺卡信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("greeting_card_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("greeting_card_info")]
                        public Types.GreetingCard? GreetingCard { get; set; }
                    }

                    public class AftersaleDetail
                    {
                        public static class Types
                        {
                            public class AftersaleOrder
                            {
                                /// <summary>
                                /// 获取或设置售后单 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("aftersale_order_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("aftersale_order_id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                                public string AftersaleOrderId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置售后单状态。
                                /// </summary>
                                [Obsolete("相关接口或字段于 2025-02-07 下线。")]
                                [Newtonsoft.Json.JsonProperty("status")]
                                [System.Text.Json.Serialization.JsonPropertyName("status")]
                                public int Status { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置售后单列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("aftersale_order_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("aftersale_order_list")]
                        public Types.AftersaleOrder[] AftersaleOrderList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置正在售后流程中的售后单数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("on_aftersale_order_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("on_aftersale_order_cnt")]
                        public int OnAftersaleOrderCount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string OrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置订单详细信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("order_detail")]
                public Types.OrderDetail OrderDetail { get; set; } = default!;

                /// <summary>
                /// 获取或设置售后详细信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("aftersale_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("aftersale_detail")]
                public Types.AftersaleDetail? AftersaleDetail { get; set; }

                /// <summary>
                /// 获取或设置下单用户 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置下单用户 UnionId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("unionid")]
                [System.Text.Json.Serialization.JsonPropertyName("unionid")]
                public string? UnionId { get; set; }

                /// <summary>
                /// 获取或设置更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                public long UpdateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置是否礼物订单。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_present")]
                [System.Text.Json.Serialization.JsonPropertyName("is_present")]
                public bool IsPresent { get; set; }

                /// <summary>
                /// 获取或设置礼物订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("present_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("present_order_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string? PresentOrderId { get; set; }

                /// <summary>
                /// 获取或设置礼物订单留言。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("present_note")]
                [System.Text.Json.Serialization.JsonPropertyName("present_note")]
                public string? PresentNote { get; set; }

                /// <summary>
                /// 获取或设置礼物订单赠送者 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("present_giver_openid")]
                [System.Text.Json.Serialization.JsonPropertyName("present_giver_openid")]
                public string? PresentGiverOpenId { get; set; }

                /// <summary>
                /// 获取或设置礼物订单赠送者 UnionId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("present_giver_unionid")]
                [System.Text.Json.Serialization.JsonPropertyName("present_giver_unionid")]
                public string? PresentGiverUnionId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置订单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order")]
        [System.Text.Json.Serialization.JsonPropertyName("order")]
        public Types.Order Order { get; set; } = default!;
    }
}
