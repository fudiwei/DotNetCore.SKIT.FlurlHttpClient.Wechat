namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/platformkf/getmchticketdetail 接口的响应。</para>
    /// </summary>
    public class ChannelsECPlatformKfGetMerchantTicketDetailResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Ticket : ChannelsECPlatformKfGetMerchantTicketListResponse.Types.__zz__Ticket
            {
                public static class Types
                {
                    public class OrderInfo : ChannelsECPlatformKfGetMerchantTicketListResponse.Types.Ticket.Types.__zz__OrderInfo
                    {
                        public static class Types
                        {
                            public class Product : ChannelsECPlatformKfGetMerchantTicketListResponse.Types.Ticket.Types.OrderInfo.Types.Product
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置商品列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("goods_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("goods_list")]
                        public List<Types.Product>? ProductList { get; set; }
                    }

                    public class UserInfo : ChannelsECPlatformKfGetMerchantTicketListResponse.Types.Ticket.Types.UserInfo
                    {
                    }

                    public class MerchantOperatation : ChannelsECPlatformKfGetMerchantTicketListResponse.Types.Ticket.Types.MerchantOperatation
                    {
                    }

                    public class PlatformOperatation : ChannelsECPlatformKfGetMerchantTicketListResponse.Types.Ticket.Types.PlatformOperatation
                    {
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
        [Newtonsoft.Json.JsonProperty("merchant_ticket")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_ticket")]
        public Types.Ticket? TicketList { get; set; }
    }
}
