namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/intracity/queryorder 接口的响应。</para>
    /// </summary>
    public class CgibinExpressIntracityQueryOrderResponse : WechatApiResponse
    {
        public static class Types
        {
            public class CargoInfo : CgibinExpressIntracityPreAddOrderRequest.Types.CargoInfo
            {
                public static class Types
                {
                    public class Item
                    {
                        /// <summary>
                        /// 获取或设置物品名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_name")]
                        public string ItemName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置物品图片 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_pic_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_pic_url")]
                        public string ItemPictureUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置物品数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_num")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_num")]
                        public int ItemCount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置物品列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item_list")]
                [System.Text.Json.Serialization.JsonPropertyName("item_list")]
                public Types.Item[] ItemList { get; set; } = default!;
            }

            public class ReceiverInfo
            {
                /// <summary>
                /// 获取或设置收件人姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receiver_name")]
                [System.Text.Json.Serialization.JsonPropertyName("receiver_name")]
                public string ReceiverName { get; set; } = default!;

                /// <summary>
                /// 获取或设置收件地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address")]
                [System.Text.Json.Serialization.JsonPropertyName("address")]
                public string Address { get; set; } = default!;

                /// <summary>
                /// 获取或设置收件地址经度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("lng")]
                [System.Text.Json.Serialization.JsonPropertyName("lng")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public double Longitude { get; set; }

                /// <summary>
                /// 获取或设置收件地址纬度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("lat")]
                [System.Text.Json.Serialization.JsonPropertyName("lat")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public double Latitude { get; set; }

                /// <summary>
                /// 获取或设置收件人联系电话。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("phone_num")]
                [System.Text.Json.Serialization.JsonPropertyName("phone_num")]
                public string PhoneNumber { get; set; } = default!;
            }

            public class StoreInfo
            {
                /// <summary>
                /// 获取或设置微信门店编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wx_store_id")]
                [System.Text.Json.Serialization.JsonPropertyName("wx_store_id")]
                public string StoreId { get; set; } = default!;

                /// <summary>
                /// 获取或设置门店名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("store_name")]
                [System.Text.Json.Serialization.JsonPropertyName("store_name")]
                public string StoreName { get; set; } = default!;

                /// <summary>
                /// 获取或设置门店详细地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address")]
                [System.Text.Json.Serialization.JsonPropertyName("address")]
                public string Address { get; set; } = default!;

                /// <summary>
                /// 获取或设置门店经度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("lng")]
                [System.Text.Json.Serialization.JsonPropertyName("lng")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public double Longitude { get; set; }

                /// <summary>
                /// 获取或设置门店纬度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("lat")]
                [System.Text.Json.Serialization.JsonPropertyName("lat")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public double Latitude { get; set; }

                /// <summary>
                /// 获取或设置门店联系电话。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("phone_num")]
                [System.Text.Json.Serialization.JsonPropertyName("phone_num")]
                public string PhoneNumber { get; set; } = default!;
            }

            public class TransporterInfo
            {
                /// <summary>
                /// 获取或设置配送员姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("transporter_name")]
                [System.Text.Json.Serialization.JsonPropertyName("transporter_name")]
                public string TransporterName { get; set; } = default!;

                /// <summary>
                /// 获取或设置配送员电话号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("transporter_phone")]
                [System.Text.Json.Serialization.JsonPropertyName("transporter_phone")]
                public string TransporterPhoneNumber { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置微信门店编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wx_store_id")]
        [System.Text.Json.Serialization.JsonPropertyName("wx_store_id")]
        public string StoreId { get; set; } = default!;

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wx_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("wx_order_id")]
        public string OrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置门店订单编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("store_order_id")]
        public string StoreOrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置订单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_status")]
        [System.Text.Json.Serialization.JsonPropertyName("order_status")]
        public int OrderStatus { get; set; }

        /// <summary>
        /// 获取或设置收件人 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("user_openid")]
        public string UserOpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置运力 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_trans_id")]
        [System.Text.Json.Serialization.JsonPropertyName("service_trans_id")]
        public string ServiceTransId { get; set; } = default!;

        /// <summary>
        /// 获取或设置运力订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_no")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_no")]
        public string TransOrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置配送距离（单位：米）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("distance")]
        [System.Text.Json.Serialization.JsonPropertyName("distance")]
        public int Distance { get; set; }

        /// <summary>
        /// 获取或设置实际支付费用（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("actualfee")]
        [System.Text.Json.Serialization.JsonPropertyName("actualfee")]
        public int ActualFee { get; set; }

        /// <summary>
        /// 获取或设置违约金（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deductfee")]
        [System.Text.Json.Serialization.JsonPropertyName("deductfee")]
        public int DeductFee { get; set; }

        /// <summary>
        /// 获取或设置发单时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        public long CreateTimestamp { get; set; }

        /// <summary>
        /// 获取或设置配送员接单时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("accept_time")]
        [System.Text.Json.Serialization.JsonPropertyName("accept_time")]
        public long? AcceptTimestamp { get; set; }

        /// <summary>
        /// 获取或设置配送员取货时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fetch_time")]
        [System.Text.Json.Serialization.JsonPropertyName("fetch_time")]
        public long? FetchTimestamp { get; set; }

        /// <summary>
        /// 获取或设置配送员送达时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finish_time")]
        [System.Text.Json.Serialization.JsonPropertyName("finish_time")]
        public long? FinishTimestamp { get; set; }

        /// <summary>
        /// 获取或设置取消时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cancel_time")]
        [System.Text.Json.Serialization.JsonPropertyName("cancel_time")]
        public long? CancelTimestamp { get; set; }

        /// <summary>
        /// 获取或设置预期送达时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expected_finish_time")]
        [System.Text.Json.Serialization.JsonPropertyName("expected_finish_time")]
        public long? ExpectedFinishTimestamp { get; set; }

        /// <summary>
        /// 获取或设置取货码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fetch_code")]
        [System.Text.Json.Serialization.JsonPropertyName("fetch_code")]
        public string? FetchCode { get; set; }

        /// <summary>
        /// 获取或设置收货码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("recv_code")]
        [System.Text.Json.Serialization.JsonPropertyName("recv_code")]
        public string? ReceiveCode { get; set; }

        /// <summary>
        /// 获取或设置订单序号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_seq")]
        [System.Text.Json.Serialization.JsonPropertyName("order_seq")]
        public string? OrderSequence { get; set; }

        /// <summary>
        /// 获取或设置商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cargo_info")]
        [System.Text.Json.Serialization.JsonPropertyName("cargo_info")]
        public Types.CargoInfo CargoInfo { get; set; } = default!;

        /// <summary>
        /// 获取或设置收件人信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("receiver_info")]
        [System.Text.Json.Serialization.JsonPropertyName("receiver_info")]
        public Types.ReceiverInfo ReceiverInfo { get; set; } = default!;

        /// <summary>
        /// 获取或设置门店信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_info")]
        [System.Text.Json.Serialization.JsonPropertyName("store_info")]
        public Types.StoreInfo StoreInfo { get; set; } = default!;

        /// <summary>
        /// 获取或设置配送员信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transporter_info")]
        [System.Text.Json.Serialization.JsonPropertyName("transporter_info")]
        public Types.TransporterInfo? TransporterInfo { get; set; }
    }
}
