namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /nontax/vehicle/payapply 接口的请求。</para>
    /// </summary>
    public class NontaxVehiclePayApplyRequest : WechatApiRequest, IMapResponse<NontaxVehiclePayApplyRequest, NontaxVehiclePayApplyResponse>
    {
        public static class Types
        {
            public class Scene
            {
                /// <summary>
                /// 获取或设置用户进入停车时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_time")]
                [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                public long StartTimestamp { get; set; }

                /// <summary>
                /// 获取或设置用户离开停车时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                public long? EndTimestamp { get; set; }

                /// <summary>
                /// 获取或设置计费时长（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("charging_time")]
                [System.Text.Json.Serialization.JsonPropertyName("charging_time")]
                public int? ChargingTime { get; set; }

                /// <summary>
                /// 获取或设置车牌号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("plate_number")]
                [System.Text.Json.Serialization.JsonPropertyName("plate_number")]
                public string PlateNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置车辆类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("car_type")]
                [System.Text.Json.Serialization.JsonPropertyName("car_type")]
                public string? CarType { get; set; }

                /// <summary>
                /// 获取或设置停车场名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("parking_name")]
                [System.Text.Json.Serialization.JsonPropertyName("parking_name")]
                public string? ParkingName { get; set; }

                /// <summary>
                /// 获取或设置停车位编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("space_number")]
                [System.Text.Json.Serialization.JsonPropertyName("space_number")]
                public string? ParkingSpaceNumber { get; set; }

                /// <summary>
                /// 获取或设置用户 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string? OpenId { get; set; }

                /// <summary>
                /// 获取或设置入口收费站的名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("entrance_name")]
                [System.Text.Json.Serialization.JsonPropertyName("entrance_name")]
                public string? EntranceName { get; set; }

                /// <summary>
                /// 获取或设置出口收费站的名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("exit_name")]
                [System.Text.Json.Serialization.JsonPropertyName("exit_name")]
                public string? ExitName { get; set; }

                /// <summary>
                /// 获取或设置核载人数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("carrying_capacity")]
                [System.Text.Json.Serialization.JsonPropertyName("carrying_capacity")]
                public string? CarryingCapacity { get; set; }

                /// <summary>
                /// 获取或设置核载人数区间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("carrying_range")]
                [System.Text.Json.Serialization.JsonPropertyName("carrying_range")]
                public string? CarryingRange { get; set; }

                /// <summary>
                /// 获取或设置高速通道类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("channel_type")]
                [System.Text.Json.Serialization.JsonPropertyName("channel_type")]
                public string? ChannelType { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置微信 AppId。如果不指定将使用构造 <see cref="WechatApiClient"/> 时的 <see cref="WechatApiClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置银行 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_id")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_id")]
        public string? BankId { get; set; }

        /// <summary>
        /// 获取或设置清分银行账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_account")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_account")]
        public string? BankAccount { get; set; }

        /// <summary>
        /// 获取或设置结算商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_id")]
        public string? MerchantId { get; set; }

        /// <summary>
        /// 获取或设置订单描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc")]
        [System.Text.Json.Serialization.JsonPropertyName("desc")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fee")]
        [System.Text.Json.Serialization.JsonPropertyName("fee")]
        public int Fee { get; set; }

        /// <summary>
        /// 获取或设置订单外部编号。与字段 <see cref="PaymentNoticeNumber"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("order_no")]
        public string? OrderOutId { get; set; }

        /// <summary>
        /// 获取或设置缴费通知书类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payment_notice_type")]
        [System.Text.Json.Serialization.JsonPropertyName("payment_notice_type")]
        public int? PaymentNoticeType { get; set; }

        /// <summary>
        /// 获取或设置缴费通知书编号。与字段 <see cref="OrderOutId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payment_notice_no")]
        [System.Text.Json.Serialization.JsonPropertyName("payment_notice_no")]
        public string? PaymentNoticeNumber { get; set; }

        /// <summary>
        /// 获取或设置执收单位编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("department_code")]
        [System.Text.Json.Serialization.JsonPropertyName("department_code")]
        public string DepartmentCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置执收单位名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("department_name")]
        [System.Text.Json.Serialization.JsonPropertyName("department_name")]
        public string DepartmentName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置行政区划代码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("region_code")]
        [System.Text.Json.Serialization.JsonPropertyName("region_code")]
        public string? RegionCode { get; set; }

        /// <summary>
        /// 获取或设置商品标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_tag")]
        [System.Text.Json.Serialization.JsonPropertyName("goods_tag")]
        public string? GoodsTag { get; set; }

        /// <summary>
        /// 获取或设置委托代扣的交易场景值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_scene")]
        [System.Text.Json.Serialization.JsonPropertyName("trade_scene")]
        public string TradeScene { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置场景信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_info")]
        [System.Text.Json.Serialization.JsonPropertyName("scene_info")]
        public Types.Scene Scene { get; set; } = new Types.Scene();
    }
}
