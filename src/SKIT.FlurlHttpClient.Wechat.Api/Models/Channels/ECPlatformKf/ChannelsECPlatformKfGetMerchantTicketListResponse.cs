namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/platformkf/getmchticketlist 接口的响应。</para>
    /// </summary>
    public class ChannelsECPlatformKfGetMerchantTicketListResponse : WechatApiResponse
    {
        public static class Types
        {
            public abstract class __zz__Ticket
            {
                /// <summary>
                /// 获取或设置工单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ticket_id")]
                [System.Text.Json.Serialization.JsonPropertyName("ticket_id")]
                public string? TicketId { get; set; }

                /// <summary>
                /// 获取或设置工单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ticket_state")]
                [System.Text.Json.Serialization.JsonPropertyName("ticket_state")]
                public int TicketState { get; set; }

                /// <summary>
                /// 获取或设置工单类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ticket_class_type")]
                [System.Text.Json.Serialization.JsonPropertyName("ticket_class_type")]
                public int TicketClassType { get; set; }

                /// <summary>
                /// 获取或设置工单开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ticket_begin_time")]
                [System.Text.Json.Serialization.JsonPropertyName("ticket_begin_time")]
                public long TicketBeginTimestamp { get; set; }

                /// <summary>
                /// 获取或设置工单处理截止时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ticket_deal_end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("ticket_deal_end_time")]
                public long TicketDealEndTimestamp { get; set; }

                /// <summary>
                /// 获取或设置工单问题描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string? Description { get; set; }

                /// <summary>
                /// 获取或设置关联订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public string? OrderId { get; set; }

                /// <summary>
                /// 获取或设置关联售后单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("aftersale_id")]
                [System.Text.Json.Serialization.JsonPropertyName("aftersale_id")]
                public string? AftersaleOrderId { get; set; }

                /// <summary>
                /// 获取或设置商户处理时间时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_operate_time")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_operate_time")]
                public long? MerchantOperateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置平台处理时间时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("platform_operate_time")]
                [System.Text.Json.Serialization.JsonPropertyName("platform_operate_time")]
                public long? PlatformOperateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置平台审核结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("platform_review_result")]
                [System.Text.Json.Serialization.JsonPropertyName("platform_review_result")]
                public int? PlatformReviewResult { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                public long UpdateTimestamp { get; set; }
            }

            public class Ticket : __zz__Ticket
            {
                public static class Types
                {
                    public abstract class __zz__OrderInfo
                    {
                        /// <summary>
                        /// 获取或设置订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                        public string? OrderId { get; set; }

                        /// <summary>
                        /// 获取或设置实付款（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("actual_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("actual_price")]
                        public int ActualPrice { get; set; }
                    }

                    public class OrderInfo : __zz__OrderInfo
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
                                /// 获取或设置商品名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("good_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("good_name")]
                                public string? ProductName { get; set; }

                                /// <summary>
                                /// 获取或设置商品缩略图 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("thumb_img")]
                                [System.Text.Json.Serialization.JsonPropertyName("thumb_img")]
                                public string? ThumbnailUrl { get; set; }

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
                                [Newtonsoft.Json.JsonProperty("good_count")]
                                [System.Text.Json.Serialization.JsonPropertyName("good_count")]
                                public int Count { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置商品列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("goods_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("goods_list")]
                        public List<Types.Product>? ProductList { get; set; }
                    }

                    public class UserInfo
                    {
                        /// <summary>
                        /// 获取或设置用户问题描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("description")]
                        [System.Text.Json.Serialization.JsonPropertyName("description")]
                        public string? Description { get; set; }
                    }

                    public class MerchantOperatation
                    {
                        /// <summary>
                        /// 获取或设置商家回复选项 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("merchant_reply")]
                        [System.Text.Json.Serialization.JsonPropertyName("merchant_reply")]
                        public int? MerchantReplyOptionId { get; set; }

                        /// <summary>
                        /// 获取或设置商家补充说明。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("description")]
                        [System.Text.Json.Serialization.JsonPropertyName("description")]
                        public string? Description { get; set; }

                        /// <summary>
                        /// 获取或设置商家与用户协商的时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("confer_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("confer_time")]
                        public long? ConferTimestamp { get; set; }
                    }

                    public class PlatformOperatation
                    {
                        /// <summary>
                        /// 获取或设置平台审核结果。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("audit_result")]
                        [System.Text.Json.Serialization.JsonPropertyName("audit_result")]
                        public int AuditResult { get; set; }

                        /// <summary>
                        /// 获取或设置审核不通过原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("reason")]
                        public string? FailReason { get; set; }

                        /// <summary>
                        /// 获取或设置平台回复时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("platform_reply_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("platform_reply_time")]
                        public long? PlatformReplyTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置平台回复用户话术。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reply_description")]
                        [System.Text.Json.Serialization.JsonPropertyName("reply_description")]
                        public string? PlatformReplyDescription { get; set; }

                        /// <summary>
                        /// 获取或设置用户是否认可。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_agree")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_agree")]
                        public bool? IsAgree { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置订单信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_info")]
                [System.Text.Json.Serialization.JsonPropertyName("order_info")]
                public Types.OrderInfo? OrderInfo { get; set; }

                /// <summary>
                /// 获取或设置商户处理结果信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_operate")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_operate")]
                public Types.MerchantOperatation? MerchantOperatation { get; set; }

                /// <summary>
                /// 获取或设置平台处理结果信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("platform_operate")]
                [System.Text.Json.Serialization.JsonPropertyName("platform_operate")]
                public Types.PlatformOperatation? PlatformOperatation { get; set; }

                /// <summary>
                /// 获取或设置用户信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_info")]
                [System.Text.Json.Serialization.JsonPropertyName("user_info")]
                public Types.UserInfo? UserInfo { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置工单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ticket_item_list")]
        [System.Text.Json.Serialization.JsonPropertyName("ticket_item_list")]
        public List<Types.Ticket>? TicketList { get; set; }

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total")]
        [System.Text.Json.Serialization.JsonPropertyName("total")]
        public int TotalCount { get; set; }
    }
}
