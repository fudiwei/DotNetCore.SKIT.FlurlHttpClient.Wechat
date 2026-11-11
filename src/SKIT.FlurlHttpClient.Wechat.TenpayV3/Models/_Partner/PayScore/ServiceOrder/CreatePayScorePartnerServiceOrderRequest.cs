namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /payscore/partner/serviceorder 接口的请求。</para>
    /// </summary>
    public class CreatePayScorePartnerServiceOrderRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class PostPayment : CreatePayScoreServiceOrderRequest.Types.PostPayment
            {
            }

            public class PostDiscount : CreatePayScoreServiceOrderRequest.Types.PostDiscount
            {
            }

            public class TimeRange : CreatePayScoreServiceOrderRequest.Types.TimeRange
            {
            }

            public class Location : CreatePayScoreServiceOrderRequest.Types.Location
            {
            }

            public class RiskFund : CreatePayScoreServiceOrderRequest.Types.RiskFund
            {
            }

            public class Device : CreatePayScoreServiceOrderRequest.Types.Device
            {
            }
        }

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置子商户微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
        public string? SubAppId { get; set; }

        /// <summary>
        /// 获取或设置商户服务单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_order_no")]
        public string? OutOrderNumber { get; set; }

        /// <summary>
        /// 获取或设置服务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_id")]
        [System.Text.Json.Serialization.JsonPropertyName("service_id")]
        public string? ServiceId { get; set; }

        /// <summary>
        /// 获取或设置服务信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_introduction")]
        [System.Text.Json.Serialization.JsonPropertyName("service_introduction")]
        public string? ServiceInstruction { get; set; }

        /// <summary>
        /// 获取或设置附加数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attach")]
        [System.Text.Json.Serialization.JsonPropertyName("attach")]
        public string? Attachment { get; set; }

        /// <summary>
        /// 获取或设置回调通知地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public string? NotifyUrl { get; set; }

        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置子商户用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_openid")]
        public string? SubOpenId { get; set; }

        /// <summary>
        /// 获取或设置是否需要用户确认。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_user_confirm")]
        [System.Text.Json.Serialization.JsonPropertyName("need_user_confirm")]
        public bool? RequireUserConfirm { get; set; }

        /// <summary>
        /// 获取或设置付费项目列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("post_payments")]
        [System.Text.Json.Serialization.JsonPropertyName("post_payments")]
        public List<Types.PostPayment>? PostPaymentList { get; set; }

        /// <summary>
        /// 获取或设置商户优惠列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("post_discounts")]
        [System.Text.Json.Serialization.JsonPropertyName("post_discounts")]
        public List<Types.PostDiscount>? PostDiscountList { get; set; }

        /// <summary>
        /// 获取或设置服务时间段信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time_range")]
        [System.Text.Json.Serialization.JsonPropertyName("time_range")]
        public Types.TimeRange? TimeRange { get; set; }

        /// <summary>
        /// 获取或设置服务位置信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location")]
        [System.Text.Json.Serialization.JsonPropertyName("location")]
        public Types.Location? Location { get; set; }

        /// <summary>
        /// 获取或设置设备信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device")]
        [System.Text.Json.Serialization.JsonPropertyName("device")]
        public Types.Device? Device { get; set; }

        /// <summary>
        /// 获取或设置订单风险金信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("risk_fund")]
        [System.Text.Json.Serialization.JsonPropertyName("risk_fund")]
        public Types.RiskFund? RiskFund { get; set; }
    }
}
