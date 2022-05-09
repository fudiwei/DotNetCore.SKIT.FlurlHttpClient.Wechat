using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [POST] /mse-pay/redirects 接口的响应。</para>
    /// </summary>
    public class CreateMSEPayRedirectLinkResponse : WechatTenpayBusinessResponse
    {
        public static class Types
        {
            public class PCWebData
            {
                /// <summary>
                /// 获取或设置 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url")]
                [System.Text.Json.Serialization.JsonPropertyName("url")]
                public string Url { get; set; } = default!;

                /// <summary>
                /// 获取或设置过期时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expire_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
                public DateTimeOffset ExpireTime { get; set; }
            }

            public class PCPluginData
            {
                /// <summary>
                /// 获取或设置 Key。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("key")]
                [System.Text.Json.Serialization.JsonPropertyName("key")]
                public string Key { get; set; } = default!;

                /// <summary>
                /// 获取或设置过期时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expire_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
                public DateTimeOffset ExpireTime { get; set; }
            }

            public class WxaQrcodeData
            {
                /// <summary>
                /// 获取或设置 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url")]
                [System.Text.Json.Serialization.JsonPropertyName("url")]
                public string Url { get; set; } = default!;
            }

            public class MiniProgramData
            {
                /// <summary>
                /// 获取或设置小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mp_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("mp_appid")]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置小程序页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mp_path")]
                [System.Text.Json.Serialization.JsonPropertyName("mp_path")]
                public string PagePath { get; set; } = default!;

                /// <summary>
                /// 获取或设置小程序原始 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mp_username")]
                [System.Text.Json.Serialization.JsonPropertyName("mp_username")]
                public string Username { get; set; } = default!;

                /// <summary>
                /// 获取或设置过期时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expire_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
                public DateTimeOffset ExpireTime { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置 PC Web 跳转链接信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pc_web")]
        [System.Text.Json.Serialization.JsonPropertyName("pc_web")]
        public Types.PCWebData PCWebData { get; set; } = default!;

        /// <summary>
        /// 获取或设置 PC 弹窗组件参数信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pc_plugin")]
        [System.Text.Json.Serialization.JsonPropertyName("pc_plugin")]
        public Types.PCPluginData? PCPluginData { get; set; }

        /// <summary>
        /// 获取或设置小程序二维码参数信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wx_qrcode")]
        [System.Text.Json.Serialization.JsonPropertyName("wx_qrcode")]
        public Types.WxaQrcodeData? WxaQrcodeData { get; set; }

        /// <summary>
        /// 获取或设置小程序参数信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("miniprogram")]
        [System.Text.Json.Serialization.JsonPropertyName("miniprogram")]
        public Types.MiniProgramData? MiniProgramData { get; set; }
    }
}
