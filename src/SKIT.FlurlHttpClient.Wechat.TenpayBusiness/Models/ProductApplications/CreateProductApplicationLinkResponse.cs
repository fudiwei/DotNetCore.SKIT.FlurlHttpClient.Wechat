using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [POST] /mse-pay/product-applications/{request_no}/links 接口的响应。</para>
    /// </summary>
    public class CreateProductApplicationLinkResponse : WechatTenpayBusinessResponse
    {
        public static class Types
        {
            public class PCWebData
            {
                /// <summary>
                /// 获取或设置跳转链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url")]
                [System.Text.Json.Serialization.JsonPropertyName("url")]
                public string Url { get; set; } = default!;

                /// <summary>
                /// 获取或设置链接过期时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expire_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset ExpireTime { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置 PC Web 跳转链接信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pc_web")]
        [System.Text.Json.Serialization.JsonPropertyName("pc_web")]
        public Types.PCWebData? PCWebData { get; set; }
    }
}
