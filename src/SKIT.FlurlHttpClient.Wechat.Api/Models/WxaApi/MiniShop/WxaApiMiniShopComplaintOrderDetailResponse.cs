namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxaapi/minishop/complaintOrderDetail 接口的响应。</para>
    /// </summary>
    public class WxaApiMiniShopComplaintOrderDetailResponse : WechatApiResponse
    {
        public static class Types
        {
            public class ComplaintOrder
            {
                public static class Types
                {
                    public class CustomerMaterial
                    {
                        /// <summary>
                        /// 获取或设置内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("content")]
                        [System.Text.Json.Serialization.JsonPropertyName("content")]
                        public string? Content { get; set; }

                        /// <summary>
                        /// 获取或设置图片 MediaId 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mediaIdList")]
                        [System.Text.Json.Serialization.JsonPropertyName("mediaIdList")]
                        public string[]? MediaIdList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置投诉单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("complaintOrderId")]
                [System.Text.Json.Serialization.JsonPropertyName("complaintOrderId")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long ComplaintOrderId { get; set; }

                /// <summary>
                /// 获取或设置用户 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openId")]
                [System.Text.Json.Serialization.JsonPropertyName("openId")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置投诉问题类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public int Type { get; set; }

                /// <summary>
                /// 获取或设置申诉状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appealState")]
                [System.Text.Json.Serialization.JsonPropertyName("appealState")]
                public int AppealState { get; set; }

                /// <summary>
                /// 获取或设置用户昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nickName")]
                [System.Text.Json.Serialization.JsonPropertyName("nickName")]
                public string Nickname { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("headImgUrl")]
                [System.Text.Json.Serialization.JsonPropertyName("headImgUrl")]
                public string HeadImageUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户手机号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("phoneNumber")]
                [System.Text.Json.Serialization.JsonPropertyName("phoneNumber")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringConverter))]
                public string PhoneNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置投诉材料信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("customerMaterial")]
                [System.Text.Json.Serialization.JsonPropertyName("customerMaterial")]
                public Types.CustomerMaterial? CustomerMaterial { get; set; } = default!;

                /// <summary>
                /// 获取或设置商户订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("outTradeNo")]
                [System.Text.Json.Serialization.JsonPropertyName("outTradeNo")]
                public string OutTradeNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("orderId")]
                [System.Text.Json.Serialization.JsonPropertyName("orderId")]
                public string OrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置商品名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("productName")]
                [System.Text.Json.Serialization.JsonPropertyName("productName")]
                public string ProductName { get; set; } = default!;

                /// <summary>
                /// 获取或设置支付时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("payTime")]
                [System.Text.Json.Serialization.JsonPropertyName("payTime")]
                public long PayTimestamp { get; set; }

                /// <summary>
                /// 获取或设置交易金额字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("totalCostStr")]
                [System.Text.Json.Serialization.JsonPropertyName("totalCostStr")]
                public string TotalCostString { get; set; } = default!;

                /// <summary>
                /// 获取或设置投诉发起时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("createTime")]
                [System.Text.Json.Serialization.JsonPropertyName("createTime")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置投诉状态过期时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expireTime")]
                [System.Text.Json.Serialization.JsonPropertyName("expireTime")]
                public long ExpireTimestamp { get; set; }
            }

            public class ComplaintHistory
            {
                /// <summary>
                /// 获取或设置投诉节点状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("itemType")]
                [System.Text.Json.Serialization.JsonPropertyName("itemType")]
                public int ItemType { get; set; }

                /// <summary>
                /// 获取或设置投诉节点申诉状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appealItemType")]
                [System.Text.Json.Serialization.JsonPropertyName("appealItemType")]
                public int? AppealItemType { get; set; }

                /// <summary>
                /// 获取或设置时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("time")]
                [System.Text.Json.Serialization.JsonPropertyName("time")]
                public long Timestamp { get; set; }

                /// <summary>
                /// 获取或设置用户昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nickName")]
                [System.Text.Json.Serialization.JsonPropertyName("nickName")]
                public string Nickname { get; set; } = default!;

                /// <summary>
                /// 获取或设置手机号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("phoneNumber")]
                [System.Text.Json.Serialization.JsonPropertyName("phoneNumber")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringConverter))]
                public string? PhoneNumber { get; set; }

                /// <summary>
                /// 获取或设置内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public string? Content { get; set; }

                /// <summary>
                /// 获取或设置图片 MediaId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mediaIdList")]
                [System.Text.Json.Serialization.JsonPropertyName("mediaIdList")]
                public string[]? MediaIdList { get; set; }

                /// <summary>
                /// 获取或设置判责结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("blameResult")]
                [System.Text.Json.Serialization.JsonPropertyName("blameResult")]
                public int BlameResult { get; set; }
            }

            public class ReturnBill
            {
                /// <summary>
                /// 获取或设置退货单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("returnId")]
                [System.Text.Json.Serialization.JsonPropertyName("returnId")]
                public string ReturnId { get; set; } = default!;

                /// <summary>
                /// 获取或设置快递公司。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("deliveryName")]
                [System.Text.Json.Serialization.JsonPropertyName("deliveryName")]
                public string DeliveryName { get; set; } = default!;

                /// <summary>
                /// 获取或设置运单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("waybillId")]
                [System.Text.Json.Serialization.JsonPropertyName("waybillId")]
                public string WaybillId { get; set; } = default!;

                /// <summary>
                /// 获取或设置运单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("orderStatus")]
                [System.Text.Json.Serialization.JsonPropertyName("orderStatus")]
                public int Status { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置投诉单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("complaintOrder")]
        [System.Text.Json.Serialization.JsonPropertyName("complaintOrder")]
        public Types.ComplaintOrder ComplaintOrder { get; set; } = default!;

        /// <summary>
        /// 获取或设置投诉进度列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item")]
        [System.Text.Json.Serialization.JsonPropertyName("item")]
        public Types.ComplaintHistory[] ComplaintHistoryList { get; set; } = default!;

        /// <summary>
        /// 获取或设置退货单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("returnBill")]
        [System.Text.Json.Serialization.JsonPropertyName("returnBill")]
        public Types.ReturnBill? ReturnBill { get; set; }
    }
}
