namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/local/business/order/pre_add 接口的响应。</para>
    /// </summary>
    public class CgibinExpressLocalBusinessOrderPreAddResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置运力返回的错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resultcode")]
        [System.Text.Json.Serialization.JsonPropertyName("resultcode")]
        public int ResultCode { get; set; }

        /// <summary>
        /// 获取或设置运力返回的错误描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resultmsg")]
        [System.Text.Json.Serialization.JsonPropertyName("resultmsg")]
        public string ResultMessage { get; set; } = default!;

        /// <summary>
        /// 获取或设置实际运费（单位：元）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fee")]
        [System.Text.Json.Serialization.JsonPropertyName("fee")]
        public double Fee { get; set; }

        /// <summary>
        /// 获取或设置运费（单位：元）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deliverfee")]
        [System.Text.Json.Serialization.JsonPropertyName("deliverfee")]
        public double DeliverFee { get; set; }

        /// <summary>
        /// 获取或设置优惠券费用（单位：元）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("couponfee")]
        [System.Text.Json.Serialization.JsonPropertyName("couponfee")]
        public double CouponFee { get; set; }

        /// <summary>
        /// 获取或设置小费（单位：元）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tips")]
        [System.Text.Json.Serialization.JsonPropertyName("tips")]
        public double TipFee { get; set; }

        /// <summary>
        /// 获取或设置保价费（单位：元）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("insurancefee")]
        [System.Text.Json.Serialization.JsonPropertyName("insurancefee")]
        public double InsuranceFee { get; set; }

        /// <summary>
        /// 获取或设置配送距离（单位：米）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("distance")]
        [System.Text.Json.Serialization.JsonPropertyName("distance")]
        public int Distance { get; set; }

        /// <summary>
        /// 获取或设置配送单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waybill_id")]
        [System.Text.Json.Serialization.JsonPropertyName("waybill_id")]
        public string WaybillId { get; set; } = default!;

        /// <summary>
        /// 获取或设置配送状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_status")]
        [System.Text.Json.Serialization.JsonPropertyName("order_status")]
        public int OrderStatus { get; set; }

        /// <summary>
        /// 获取或设置收货码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finish_code")]
        [System.Text.Json.Serialization.JsonPropertyName("finish_code")]
        public int FinishCode { get; set; }

        /// <summary>
        /// 获取或设置取货码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pickup_code")]
        [System.Text.Json.Serialization.JsonPropertyName("pickup_code")]
        public int PickupCode { get; set; }

        /// <summary>
        /// 获取或设置预计骑手接单时间（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dispatch_duration")]
        [System.Text.Json.Serialization.JsonPropertyName("dispatch_duration")]
        public int ExpectedDispatchTime { get; set; }

        /// <summary>
        /// 获取或设置配送公司返回的参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_token")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_token")]
        public string? DeliveryToken { get; set; }

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && ResultCode == 0;
        }
    }
}
