using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /nontax/unifiedorder 接口的请求。</para>
    /// </summary>
    public class NontaxUnifiedOrderRequest : WechatApiRequest, IInferable<NontaxUnifiedOrderRequest, NontaxUnifiedOrderResponse>
    {
        public static class Types
        {
            public class BillItem
            {
                /// <summary>
                /// 获取或设置项目编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("no")]
                [System.Text.Json.Serialization.JsonPropertyName("no")]
                public int SerialNumber { get; set; }

                /// <summary>
                /// 获取或设置项目编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item_id")]
                [System.Text.Json.Serialization.JsonPropertyName("item_id")]
                public string ItemId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置项目名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item_name")]
                [System.Text.Json.Serialization.JsonPropertyName("item_name")]
                public string Name { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置滞纳金（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("overdue")]
                [System.Text.Json.Serialization.JsonPropertyName("overdue")]
                public int? Overdue { get; set; }

                /// <summary>
                /// 获取或设置加罚金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("penalty")]
                [System.Text.Json.Serialization.JsonPropertyName("penalty")]
                public int? Penalty { get; set; }

                /// <summary>
                /// 获取或设置总金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fee")]
                [System.Text.Json.Serialization.JsonPropertyName("fee")]
                public int Fee { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置微信 AppId。如果不指定将使用构造 <see cref="WechatApiClient"/> 时的 <see cref="WechatApiClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置服务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_id")]
        [System.Text.Json.Serialization.JsonPropertyName("service_id")]
        public int? ServiceId { get; set; }

        /// <summary>
        /// 获取或设置交易类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_type")]
        [System.Text.Json.Serialization.JsonPropertyName("trade_type")]
        public string? TradeType { get; set; }

        /// <summary>
        /// 获取或设置银行 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_id")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_id")]
        public string? BankId { get; set; }

        /// <summary>
        /// 获取或设置清分银行帐号。
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
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置 App  AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("app_appid")]
        public string? AppAppId { get; set; }

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
        /// 获取或设置支付中间页支付完成后跳转的页面 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("return_url")]
        [System.Text.Json.Serialization.JsonPropertyName("return_url")]
        public string? ReturnUrl { get; set; }

        /// <summary>
        /// 获取或设置用户端 IP。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ip")]
        [System.Text.Json.Serialization.JsonPropertyName("ip")]
        public string ClientIp { get; set; } = string.Empty;

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
        /// 获取或设置缴费通知书创建时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payment_notice_create_time")]
        [System.Text.Json.Serialization.JsonPropertyName("payment_notice_create_time")]
        public long PaymentNoticeCreateTimestamp { get; set; }

        /// <summary>
        /// 获取或设置缴费通知书限缴日期（格式：yyyyMMdd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payment_expire_date")]
        [System.Text.Json.Serialization.JsonPropertyName("payment_expire_date")]
        public string PaymentNoticeExpireDateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户姓名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_name")]
        [System.Text.Json.Serialization.JsonPropertyName("user_name")]
        public string? UserName { get; set; }

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
        public string RegionCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置场景值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene")]
        [System.Text.Json.Serialization.JsonPropertyName("scene")]
        public string Scene { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置缴费子项目列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("items")]
        [System.Text.Json.Serialization.JsonPropertyName("items")]
        public IList<Types.BillItem> BillItemList { get; set; } = new List<Types.BillItem>();

        /// <summary>
        /// 获取或设置是否自动调起支付。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auto_call_pay")]
        [System.Text.Json.Serialization.JsonPropertyName("auto_call_pay")]
        public bool? IsAutoCallPay { get; set; }
    }
}
