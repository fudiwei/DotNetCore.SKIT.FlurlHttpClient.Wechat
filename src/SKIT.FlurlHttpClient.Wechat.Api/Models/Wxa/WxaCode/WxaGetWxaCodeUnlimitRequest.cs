namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/getwxacodeunlimit 接口的请求。</para>
    /// </summary>
    public class WxaGetWxaCodeUnlimitRequest : WechatApiRequest
    {
        public static class Types
        {
            public class Color : WxaGetWxaCodeRequest.Types.Color
            {
            }
        }

        /// <summary>
        /// 获取或设置扫码场景值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene")]
        [System.Text.Json.Serialization.JsonPropertyName("scene")]
        public string Scene { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置扫码进入的小程序页面路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page")]
        [System.Text.Json.Serialization.JsonPropertyName("page")]
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
        /// 检查page 是否存在，为 true 时 page 必须是已经发布的小程序存在的页面（否则报错）；为 false 时允许小程序未发布或者 page 不存在， 但page 有数量上限（60000个）请勿滥用
        /// </summary>
        [Newtonsoft.Json.JsonProperty("check_path")]
        [System.Text.Json.Serialization.JsonPropertyName("check_path")]
        public bool? IsCheckPath { get; set; }

        /// <summary>
        /// 要打开的小程序版本。正式版为 "release"，体验版为 "trial"，开发版为 "develop"
        /// </summary>
        [Newtonsoft.Json.JsonProperty("env_version")]
        [System.Text.Json.Serialization.JsonPropertyName("env_version")]
        public string? EnvVersion { get; set; }
    }
}
