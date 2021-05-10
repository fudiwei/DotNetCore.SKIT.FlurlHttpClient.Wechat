using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /pay/partner/transactions/jsapi 接口的请求。</para>
    /// </summary>
    public class CreatePayPartnerTransactionJsapiRequest : CreatePayTransactionJsapiRequest
    {
        public new static class Types
        {
            public class Payer
            {
                /// <summary>
                /// 获取或设置用户在服务商下唯一标识。与字段 <see cref="SubOpenId"/> 二选一。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sp_openid")]
                [System.Text.Json.Serialization.JsonPropertyName("sp_openid")]
                public string? OpenId { get; set; }

                /// <summary>
                /// 获取或设置用户在子商户下唯一标识。与字段 <see cref="OpenId"/> 二选一。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_openid")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_openid")]
                public string? SubOpenId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置服务商商户号。如果不指定将使用构造 <see cref="WechatTenpayClient"/> 时的 <see cref="WechatTenpayClientOptions.MerchantId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_mchid")]
        public override string? MerchantId { get; set; }

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置服务商 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_appid")]
        public override string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置子商户 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
        public string? SubAppId { get; set; }

        /// <summary>
        /// 获取或设置支付者信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payer")]
        [System.Text.Json.Serialization.JsonPropertyName("payer")]
        public new Types.Payer? Payer { get; set; }
    }
}
