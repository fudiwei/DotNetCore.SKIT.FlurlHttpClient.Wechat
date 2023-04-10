namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [POST] /mse-pay/redirects 接口的响应。</para>
    /// </summary>
    public class CreatePaymentRedirectLinkResponse : WechatTenpayBusinessResponse
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
            }

            public class QrcodeData
            {
                /// <summary>
                /// 获取或设置二维码 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("static_qrcode")]
                [System.Text.Json.Serialization.JsonPropertyName("static_qrcode")]
                public string QrcodeUrl { get; set; } = default!;
            }

            public class H5Data
            {
                /// <summary>
                /// 获取或设置 H5 收银台链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wx_h5")]
                [System.Text.Json.Serialization.JsonPropertyName("wx_h5")]
                public string Url { get; set; } = default!;
            }

            public class AppData
            {
                /// <summary>
                /// 获取或设置 H5 收银台链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_h5")]
                [System.Text.Json.Serialization.JsonPropertyName("app_h5")]
                public string Url { get; set; } = default!;
            }

            public class WecomData
            {
                /// <summary>
                /// 获取或设置 H5 收银台链接。
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
                /// 获取或设置小程序版本。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mp_version")]
                [System.Text.Json.Serialization.JsonPropertyName("mp_version")]
                public string? Version { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置 PC Web 跳转链接信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pc_web")]
        [System.Text.Json.Serialization.JsonPropertyName("pc_web")]
        public Types.PCWebData? PCWebData { get; set; }

        /// <summary>
        /// 获取或设置小程序二维码参数信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("static_qrcode")]
        [System.Text.Json.Serialization.JsonPropertyName("static_qrcode")]
        public Types.QrcodeData? QrcodeData { get; set; }

        /// <summary>
        /// 获取或设置 H5 跳转链接信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wx_h5")]
        [System.Text.Json.Serialization.JsonPropertyName("wx_h5")]
        public Types.H5Data? H5Data { get; set; }

        /// <summary>
        /// 获取或设置 App 跳转链接信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_h5")]
        [System.Text.Json.Serialization.JsonPropertyName("app_h5")]
        public Types.AppData? AppData { get; set; }

        /// <summary>
        /// 获取或设置企业微信跳转链接信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wecom_h5")]
        [System.Text.Json.Serialization.JsonPropertyName("wecom_h5")]
        public Types.WecomData? WeComData { get; set; }

        /// <summary>
        /// 获取或设置小程序跳转参数信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mini_program")]
        [System.Text.Json.Serialization.JsonPropertyName("mini_program")]
        public Types.MiniProgramData? MiniProgramData { get; set; }
    }
}
