using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/order/batchgetaftersaleorder 接口的响应。</para>
    /// </summary>
    public class ProductOrderBatchGetAftersaleOrderResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Aftersale
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
                        public long ProductId { get; set; }

                        /// <summary>
                        /// 获取或设置 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                        public long SKUId { get; set; }

                        /// <summary>
                        /// 获取或设置商品数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("count")]
                        [System.Text.Json.Serialization.JsonPropertyName("count")]
                        public int Count { get; set; }
                    }

                    public class Refund
                    {
                        /// <summary>
                        /// 获取或设置退款金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("amount")]
                        public int Amount { get; set; }
                    }

                    public class RefundResponse
                    {
                        /// <summary>
                        /// 获取或设置返回码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ret")]
                        [System.Text.Json.Serialization.JsonPropertyName("ret")]
                        public int ReturnCode { get; set; }

                        /// <summary>
                        /// 获取或设置错误码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("code")]
                        [System.Text.Json.Serialization.JsonPropertyName("code")]
                        public string? ErrorCode { get; set; }

                        /// <summary>
                        /// 获取或设置错误描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("message")]
                        [System.Text.Json.Serialization.JsonPropertyName("message")]
                        public string? ErrorMessage { get; set; }
                    }

                    public class Return
                    {
                        /// <summary>
                        /// 获取或设置退货快递单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("waybill_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("waybill_id")]
                        public string WaybillId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置退货物流公司 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
                        public string DeliveryId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置退货物流公司名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_name")]
                        public string DeliveryName { get; set; } = default!;
                    }

                    public class Detail
                    {
                        /// <summary>
                        /// 获取或设置描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("desc")]
                        public string Description { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置退款的数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("num")]
                        [System.Text.Json.Serialization.JsonPropertyName("num")]
                        public int Count { get; set; }

                        /// <summary>
                        /// 获取或设置取消时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cancel_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("cancel_time")]
                        public long? CancelTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置用户电话号码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tel_number")]
                        [System.Text.Json.Serialization.JsonPropertyName("tel_number")]
                        public string? PhoneNumber { get; set; }

                        /// <summary>
                        /// 获取或设置退款凭证图片 URL 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("prove_imgs")]
                        [System.Text.Json.Serialization.JsonPropertyName("prove_imgs")]
                        public string[]? ProofImageUrlList { get; set; }
                    }

                    public class MerchantUploadInformation
                    {
                        /// <summary>
                        /// 获取或设置退款凭证图片 URL 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_certificates")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_certificates")]
                        public string[]? RefundCertificateUrlList { get; set; }

                        /// <summary>
                        /// 获取或设置拒绝原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reject_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("reject_reason")]
                        public string? RejectReason { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置售后单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public long AftersaleOrderId { get; set; }

                /// <summary>
                /// 获取或设置售后单对应的订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("original_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("original_order_id")]
                public long OriginalOrderId { get; set; }

                /// <summary>
                /// 获取或设置售后单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置退款原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reason")]
                [System.Text.Json.Serialization.JsonPropertyName("reason")]
                public string Reason { get; set; } = default!;

                /// <summary>
                /// 获取或设置退款方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string Type { get; set; } = default!;

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
                public Types.Detail Detail { get; set; } = default!;

                /// <summary>
                /// 获取或设置退款信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_info")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_info")]
                public Types.Refund? Refund { get; set; }

                /// <summary>
                /// 获取或设置退款响应信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_resp")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_resp")]
                public Types.RefundResponse? RefundResponse { get; set; }

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
                public Types.MerchantUploadInformation? MerchantUploadInformation { get; set; }

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
            }
        }

        /// <summary>
        /// 获取或设置售后单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("after_sale_order_list")]
        [System.Text.Json.Serialization.JsonPropertyName("after_sale_order_list")]
        public Types.Aftersale[] AftersaleOrderList { get; set; } = default!;
    }
}
