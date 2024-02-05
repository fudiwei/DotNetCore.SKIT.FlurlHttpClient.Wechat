using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Events
{
    /// <summary>
    /// <para>表示 MALL_TRANSACTION.SUCCESS 通知的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/smart-business-circle/on-site-payment.html ]]> <br/>
    /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/smart-business-circle/on-site-payment.html ]]>
    /// </para>
    /// </summary>
    public class MallTransactionResource : WechatTenpayEvent.Types.IDecryptedResource
    {
        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("mchid")]
        public string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商圈商户名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_name")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_name")]
        public string? MerchantName { get; set; }

        /// <summary>
        /// 获取或设置门店名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_name")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_name")]
        public string? ShopName { get; set; }

        /// <summary>
        /// 获取或设置门店编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_number")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_number")]
        public string? ShopNumber { get; set; }

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信支付订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public string? TransactionId { get; set; }

        /// <summary>
        /// 获取或设置金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public int? Amount { get; set; }

        /// <summary>
        /// 获取或设置交易完成时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time_end")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("time_end")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? SuccessTime { get; set; }

        /// <summary>
        /// 获取或设置手动提交积分标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("commit_tag")]
        [System.Text.Json.Serialization.JsonPropertyName("commit_tag")]
        public string? CommitTag { get; set; }

        /// <summary>
        /// 获取或设置授权类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_type")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_type")]
        public string? AuthType { get; set; }

        /// <summary>
        /// 获取或设置会员卡 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? CardCode { get; set; }
    }
}
