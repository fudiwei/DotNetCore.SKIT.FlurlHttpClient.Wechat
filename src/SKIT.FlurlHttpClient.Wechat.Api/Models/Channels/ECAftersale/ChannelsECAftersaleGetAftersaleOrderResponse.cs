using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/aftersale/getaftersaleorder 接口的响应。</para>
    /// </summary>
    public class ChannelsECAftersaleGetAftersaleOrderResponse : WechatApiResponse
    {
        public static class Types
        {
            public class AftersaleOrder
            {
                public static class Types
                {
                    public class Product
                    {
                        public static class Types
                        {
                            public class Voucher
                            {
                                public static class Types
                                {
                                    public class Time
                                    {
                                        /// <summary>
                                        /// 获取或设置次卡 ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("serial_id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("serial_id")]
                                        public string SerialId { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置退卡金额（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("amount")]
                                        public int Amount { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置团购优惠券码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("vourcher_code")]
                                [System.Text.Json.Serialization.JsonPropertyName("vourcher_code")]
                                public string VoucherCode { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置券退款金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                                public int Amount { get; set; }

                                /// <summary>
                                /// 获取或设置券退款金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("times_list")]
                                [System.Text.Json.Serialization.JsonPropertyName("times_list")]
                                public Types.Time[]? TimeList { get; set; }
                            }

                            public class GiftProduct
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
                                /// 获取或设置商品编码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_code")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_code")]
                                public string? SKUCode { get; set; }

                                /// <summary>
                                /// 获取或设置商品数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("count")]
                                [System.Text.Json.Serialization.JsonPropertyName("count")]
                                public int Count { get; set; }

                                /// <summary>
                                /// 获取或设置活动 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("task_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("task_id")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public long TaskId { get; set; }
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
                        /// 获取或设置商品编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_code")]
                        public string? SKUCode { get; set; }

                        /// <summary>
                        /// 获取或设置商品数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("count")]
                        [System.Text.Json.Serialization.JsonPropertyName("count")]
                        public int Count { get; set; }

                        /// <summary>
                        /// 获取或设置是否极速退款。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fast_refund")]
                        [System.Text.Json.Serialization.JsonPropertyName("fast_refund")]
                        public bool? IsFastRefund { get; set; }

                        /// <summary>
                        /// 获取或设置团购优惠券列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("voucher_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("voucher_list")]
                        public Types.Voucher[]? VoucherList { get; set; }

                        /// <summary>
                        /// 获取或设置赠品列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("gift_product_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("gift_product_list")]
                        public Types.GiftProduct[]? GiftProductList { get; set; }
                    }

                    public class AftersaleDetail
                    {
                        /// <summary>
                        /// 获取或设置售后描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("desc")]
                        public string? Description { get; set; }

                        /// <summary>
                        /// 获取或设置是否已经收到货。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("receive_product")]
                        [System.Text.Json.Serialization.JsonPropertyName("receive_product")]
                        public bool HasReceivedProduct { get; set; }

                        /// <summary>
                        /// 获取或设置取消售后时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cancel_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("cancel_time")]
                        public long CancelTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置举证图片 MediaId 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("media_id_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("media_id_list")]
                        public string[]? MediaIdList { get; set; }

                        /// <summary>
                        /// 获取或设置联系电话。
                        /// </summary>
                        [Obsolete("相关接口或字段于 2025-04-14 下线。")]
                        [Newtonsoft.Json.JsonProperty("tel_number")]
                        [System.Text.Json.Serialization.JsonPropertyName("tel_number")]
                        public string? TelNumber { get; set; }

                        /// <summary>
                        /// 获取或设置小程序会员已经优惠金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("wxa_vip_discounted_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("wxa_vip_discounted_price")]
                        public int? WxaVipDiscountedPrice { get; set; }
                    }

                    public class Refund
                    {
                        /// <summary>
                        /// 获取或设置退款金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("amount")]
                        public int Amount { get; set; }

                        /// <summary>
                        /// 获取或设置退款直接原因类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_reason")]
                        public int? RefundReasonType { get; set; }

                        /// <summary>
                        /// 获取或设置平台优惠退款金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("platform_discount_return_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("platform_discount_return_amount")]
                        public int? PlatformDiscountReturnAmount { get; set; }

                        /// <summary>
                        /// 获取或设置是否使用运费险小额保障退款。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_low_price_insurance_refund")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_low_price_insurance_refund")]
                        public bool? IsLowPriceInsuranceRefund { get; set; }

                        /// <summary>
                        /// 获取或设置是否最终由运费险出资。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_final_refund_by_insurance")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_final_refund_by_insurance")]
                        public bool? IsFinalRefundByInsurance { get; set; }
                    }

                    public class Return
                    {
                        public static class Types
                        {
                            public class AddressInfo
                            {
                                /// <summary>
                                /// 获取或设置收件人姓名。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("user_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("user_name")]
                                public string UserName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置国家码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("national_code")]
                                [System.Text.Json.Serialization.JsonPropertyName("national_code")]
                                public string? NationalCode { get; set; }

                                /// <summary>
                                /// 获取或设置邮政编码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("postal_code")]
                                [System.Text.Json.Serialization.JsonPropertyName("postal_code")]
                                public string? PostalCode { get; set; }

                                /// <summary>
                                /// 获取或设置省份。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("province_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("province_name")]
                                public string? ProvinceName { get; set; }

                                /// <summary>
                                /// 获取或设置城市。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("city_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("city_name")]
                                public string? CityName { get; set; }

                                /// <summary>
                                /// 获取或设置区县。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("county_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("county_name")]
                                public string? DistrictName { get; set; }

                                /// <summary>
                                /// 获取或设置详细地址。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("detail_info")]
                                [System.Text.Json.Serialization.JsonPropertyName("detail_info")]
                                public string? Detail { get; set; }

                                /// <summary>
                                /// 获取或设置电话号码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("tel_number")]
                                [System.Text.Json.Serialization.JsonPropertyName("tel_number")]
                                public string TelNumber { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置门牌号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("house_number")]
                                [System.Text.Json.Serialization.JsonPropertyName("house_number")]
                                public string? HouseNumber { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置退回方式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("return_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("return_type")]
                        public int ReturnType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置快递公司 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
                        public string DeliveryId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置快递公司名字。
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
                        /// 获取或设置退货地址信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("address_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("address_info")]
                        public Types.AddressInfo? AddressInfo { get; set; }
                    }

                    public class MerchantUploadInfo
                    {
                        /// <summary>
                        /// 获取或设置拒绝原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reject_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("reject_reason")]
                        public string? RejectReason { get; set; }

                        /// <summary>
                        /// 获取或设置退款凭证 URL 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_certificates")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_certificates")]
                        public string[]? RefundCertificateUrlList { get; set; }
                    }

                    public class MerchantUpdateDetail
                    {
                        /// <summary>
                        /// 获取或设置协商类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("merchant_update_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("merchant_update_type")]
                        public int MerchantUpdateType { get; set; }

                        /// <summary>
                        /// 获取或设置协商描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("merchant_update_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("merchant_update_desc")]
                        public string MerchantUpdateDescription { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置协商原因类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("update_reason_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("update_reason_type")]
                        public int UpdateReasonType { get; set; }

                        /// <summary>
                        /// 获取或设置协商前售后类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("old_after_sale_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("old_after_sale_type")]
                        public int OldAftersaleType { get; set; }

                        /// <summary>
                        /// 获取或设置协商后售后类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("new_after_sale_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("new_after_sale_type")]
                        public int NewAftersaleType { get; set; }

                        /// <summary>
                        /// 获取或设置协商前售后金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("old_after_sale_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("old_after_sale_amount")]
                        public int OldAftersaleAmount { get; set; }

                        /// <summary>
                        /// 获取或设置协商后售后金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("new_after_sale_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("new_after_sale_amount")]
                        public int NewAftersaleAmount { get; set; }

                        /// <summary>
                        /// 获取或设置协商图片 MediaId 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("media_ids")]
                        [System.Text.Json.Serialization.JsonPropertyName("media_ids")]
                        public string[]? MediaIdList { get; set; }
                    }

                    public class RefundResultInfo
                    {
                        /// <summary>
                        /// 获取或设置退款结果。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ret")]
                        [System.Text.Json.Serialization.JsonPropertyName("ret")]
                        public int Result { get; set; }

                        /// <summary>
                        /// 获取或设置错误代码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("code")]
                        [System.Text.Json.Serialization.JsonPropertyName("code")]
                        public string? ErrorCode { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置错误描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("message")]
                        [System.Text.Json.Serialization.JsonPropertyName("message")]
                        public string? ErrorMessage { get; set; }
                    }

                    public class ExchangeProductInfo
                    {
                        /// <summary>
                        /// 获取或设置商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long ProductId { get; set; }

                        /// <summary>
                        /// 获取或设置旧 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("old_sku_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("old_sku_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long OldSKUId { get; set; }

                        /// <summary>
                        /// 获取或设置新 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("new_sku_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("new_sku_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long NewSKUId { get; set; }

                        /// <summary>
                        /// 获取或设置旧 SKU 价格（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("old_sku_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("old_sku_price")]
                        public int OldSKUPrice { get; set; }

                        /// <summary>
                        /// 获取或设置新 SKU 价格（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("new_sku_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("new_sku_price")]
                        public int NewSKUPrice { get; set; }

                        /// <summary>
                        /// 获取或设置旧商品编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("old_sku_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("old_sku_code")]
                        public string? OldSKUCode { get; set; }

                        /// <summary>
                        /// 获取或设置新商品编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("new_sku_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("new_sku_code")]
                        public string? NewSKUCode { get; set; }

                        /// <summary>
                        /// 获取或设置商品数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_cnt")]
                        public int Count { get; set; }
                    }

                    public class ExchangeDeliveryInfo
                    {
                        public static class Types
                        {
                            public class Address : ChannelsECOrderGetResponse.Types.Order.Types.OrderDetail.Types.Delivery.Types.Address
                            {
                            }
                        }

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
                        /// 获取或设置地址信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("address_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("address_info")]
                        public Types.Address? Address { get; set; }
                    }

                    public class ExchangeInfo
                    {
                        public static class Types
                        {
                            public class FastExchagneInfo
                            {
                                public static class Types
                                {
                                    public class FastExchangeAction
                                    {
                                        /// <summary>
                                        /// 获取或设置商家确认状态。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("merchant_confirm")]
                                        [System.Text.Json.Serialization.JsonPropertyName("merchant_confirm")]
                                        public int? MerchantConfirmStatus { get; set; }

                                        /// <summary>
                                        /// 获取或设置商家确认时间戳。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("merchant_confirm_time")]
                                        [System.Text.Json.Serialization.JsonPropertyName("merchant_confirm_time")]
                                        public long? MerchantConfirmTimestamp { get; set; }

                                        /// <summary>
                                        /// 获取或设置商家拒绝状态。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("merchant_reject")]
                                        [System.Text.Json.Serialization.JsonPropertyName("merchant_reject")]
                                        public int? MerchantRejectStatus { get; set; }

                                        /// <summary>
                                        /// 获取或设置商家拒绝时间戳。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("merchant_reject_time")]
                                        [System.Text.Json.Serialization.JsonPropertyName("merchant_reject_time")]
                                        public long? MerchantRejectTimestamp { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置是否极速换货。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("fast_exchange")]
                                [System.Text.Json.Serialization.JsonPropertyName("fast_exchange")]
                                public bool IsFastExchange { get; set; }

                                /// <summary>
                                /// 获取或设置极速换货商家操作动作。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("fast_exchange_act")]
                                [System.Text.Json.Serialization.JsonPropertyName("fast_exchange_act")]
                                public Types.FastExchangeAction? FastExchangeAction { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置急速换货信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fast_exchange_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("fast_exchange_info")]
                        public Types.FastExchagneInfo? FastExchagneInfo { get; set; }
                    }

                    public class VirualTelNumberInfo
                    {
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
                    }
                }

                /// <summary>
                /// 获取或设置售后单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("after_sale_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("after_sale_order_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string AftersaleOrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string OrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置售后单类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string Type { get; set; } = default!;

                /// <summary>
                /// 获取或设置售后单子类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_type")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_type")]
                public string? SubType { get; set; }

                /// <summary>
                /// 获取或设置售后单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置买家用户 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置买家用户 UnionId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("unionid")]
                [System.Text.Json.Serialization.JsonPropertyName("unionid")]
                public string? UnionId { get; set; }

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

                /// <summary>
                /// 获取或设置售后原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reason")]
                [System.Text.Json.Serialization.JsonPropertyName("reason")]
                public string Reason { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_info")]
                [System.Text.Json.Serialization.JsonPropertyName("product_info")]
                public Types.Product Product { get; set; } = default!;

                /// <summary>
                /// 获取或设置售后详细信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("details")]
                [System.Text.Json.Serialization.JsonPropertyName("details")]
                public Types.AftersaleDetail Detail { get; set; } = default!;

                /// <summary>
                /// 获取或设置退款信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_info")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_info")]
                public Types.Refund? Refund { get; set; }

                /// <summary>
                /// 获取或设置退货信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("return_info")]
                [System.Text.Json.Serialization.JsonPropertyName("return_info")]
                public Types.Return? Return { get; set; }

                /// <summary>
                /// 获取或设置商家上传信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_upload_info")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_upload_info")]
                public Types.MerchantUploadInfo? MerchantUploadInfo { get; set; }

                /// <summary>
                /// 获取或设置商家发起协商信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_update_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_update_detail")]
                public Types.MerchantUpdateDetail? MerchantUpdateDetail { get; set; }

                /// <summary>
                /// 获取或设置退款结果信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_resp")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_resp")]
                public Types.RefundResultInfo? RefundResultInfo { get; set; }

                /// <summary>
                /// 获取或设置生成售后单场景值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("gen_scene")]
                [System.Text.Json.Serialization.JsonPropertyName("gen_scene")]
                public int? GenerateScene { get; set; }

                /// <summary>
                /// 获取或设置操作剩余时间（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("deadline")]
                [System.Text.Json.Serialization.JsonPropertyName("deadline")]
                public int Deadline { get; set; }

                /// <summary>
                /// 获取或设置换货相关商品信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("exchange_product_info")]
                [System.Text.Json.Serialization.JsonPropertyName("exchange_product_info")]
                public Types.ExchangeProductInfo? ExchangeProductInfo { get; set; }

                /// <summary>
                /// 获取或设置换货相关物流信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("exchange_delivery_info")]
                [System.Text.Json.Serialization.JsonPropertyName("exchange_delivery_info")]
                public Types.ExchangeDeliveryInfo? ExchangeDeliveryInfo { get; set; }

                /// <summary>
                /// 获取或设置换货信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("exchange_info")]
                [System.Text.Json.Serialization.JsonPropertyName("exchange_info")]
                public Types.ExchangeInfo? ExchangeInfo { get; set; }

                /// <summary>
                /// 获取或设置虚拟号码信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("virtual_tel_num_info")]
                [System.Text.Json.Serialization.JsonPropertyName("virtual_tel_num_info")]
                public Types.VirualTelNumberInfo? VirualTelNumberInfo { get; set; }

                /// <summary>
                /// 获取或设置商责额外赔付金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("compensation_liability_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("compensation_liability_amount")]
                public int? CompensationLiabilityAmount { get; set; }

                /// <summary>
                /// 获取或设置是否需要线下退款。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("need_offline_refund")]
                [System.Text.Json.Serialization.JsonPropertyName("need_offline_refund")]
                public bool? RequireOfflineRefund { get; set; }

                /// <summary>
                /// 获取或设置售后单本地生活类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("aftersale_voucher_type")]
                [System.Text.Json.Serialization.JsonPropertyName("aftersale_voucher_type")]
                public int? AftersaleVoucherType { get; set; }

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
                /// 获取或设置售后完结时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("complete_time")]
                [System.Text.Json.Serialization.JsonPropertyName("complete_time")]
                public long? CompleteTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置售后单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("after_sale_order")]
        [System.Text.Json.Serialization.JsonPropertyName("after_sale_order")]
        public Types.AftersaleOrder AftersaleOrder { get; set; } = default!;
    }
}
