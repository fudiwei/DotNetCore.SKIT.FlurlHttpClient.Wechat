namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /pay/acquiring-bank/transactions/exposure 接口的请求。</para>
    /// </summary>
    public class CreatePayAcquiringBankTransactionExposureRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Payer
            {
                /// <summary>
                /// 获取或设置用户唯一标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("acquiring_bank_openid")]
                [System.Text.Json.Serialization.JsonPropertyName("acquiring_bank_openid")]
                public string? OpenId { get; set; }

                /// <summary>
                /// 获取或设置用户在特约商户下的唯一标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_openid")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_openid")]
                public string? SubOpenId { get; set; }

                /// <summary>
                /// 获取或设置手机号哈希值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("phone_number_hash")]
                [System.Text.Json.Serialization.JsonPropertyName("phone_number_hash")]
                public string? PhoneNumberHash { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置从业机构号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acquiring_bank_id")]
        [System.Text.Json.Serialization.JsonPropertyName("acquiring_bank_id")]
        public string AquiringBankId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置从业机构 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acquiring_bank_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("acquiring_bank_appid")]
        public string? AquiringBankAppId { get; set; }

        /// <summary>
        /// 获取或设置特约商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_id")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_id")]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置特约商户 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_appid")]
        public string? SubAppId { get; set; }

        /// <summary>
        /// 获取或设置渠道商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel_id")]
        [System.Text.Json.Serialization.JsonPropertyName("channel_id")]
        public string ChannelId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
        public string OutTradeNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置支付者信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payer")]
        [System.Text.Json.Serialization.JsonPropertyName("payer")]
        public Types.Payer? Payer { get; set; }
    }
}
