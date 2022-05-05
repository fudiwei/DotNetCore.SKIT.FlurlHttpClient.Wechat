namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/getwxacode 接口的请求。</para>
    /// </summary>
    public class WxaGetWxaCodeRequest : WechatApiRequest, IInferable<WxaGetWxaCodeRequest, WxaGetWxaCodeResponse>
    {
        public static class Types
        {
            public class Color
            {
                /// <summary>
                /// 获取或设置红色色值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("r")]
                [System.Text.Json.Serialization.JsonPropertyName("r")]
                public byte Red { get; set; }

                /// <summary>
                /// 获取或设置绿色色值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("g")]
                [System.Text.Json.Serialization.JsonPropertyName("g")]
                public byte Green { get; set; }

                /// <summary>
                /// 获取或设置蓝色色值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("b")]
                [System.Text.Json.Serialization.JsonPropertyName("b")]
                public byte Blue { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置扫码进入的小程序页面路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("path")]
        [System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? PagePath { get; set; }

        /// <summary>
        /// 获取或设置二维码的宽度（单位：像素）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("width")]
        [System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// 获取或设置是否自动配置线条颜色。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auto_color")]
        [System.Text.Json.Serialization.JsonPropertyName("auto_color")]
        public bool? IsAutoColor { get; set; }

        /// <summary>
        /// 获取或设置线条颜色信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("line_color")]
        [System.Text.Json.Serialization.JsonPropertyName("line_color")]
        public Types.Color? LineColor { get; set; }

        /// <summary>
        /// 获取或设置是否需要透明底色。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_hyaline")]
        [System.Text.Json.Serialization.JsonPropertyName("is_hyaline")]
        public bool? IsHyaline { get; set; }

        /// <summary>
        /// 获取或设置要打开的小程序版本。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("env_version")]
        [System.Text.Json.Serialization.JsonPropertyName("env_version")]
        public string? EnvironmentVersion { get; set; }
    }
}