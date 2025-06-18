namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cv/ocr/idcard 接口的响应。</para>
    /// </summary>
    public class CVOCRIdCardResponse : WechatApiResponse
    {
        public static class Types
        {
            public class CertificationPosition
            {
                public static class Types
                {
                    public class Position : CVImageQrcodeResponse.Types.CodeResult.Types.Position
                    {
                    }
                }

                /// <summary>
                /// 获取或设置识别坐标信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pos")]
                [System.Text.Json.Serialization.JsonPropertyName("pos")]
                public Types.Position Position { get; set; } = default!;
            }

            public class ImageSize : CVImageQrcodeResponse.Types.ImageSize
            {
            }
        }

        /// <summary>
        /// 获取或设置正反面类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = default!;

        /// <summary>
        /// 获取或设置身份证号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? IdNumber { get; set; }

        /// <summary>
        /// 获取或设置姓名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 获取或设置住址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("addr")]
        [System.Text.Json.Serialization.JsonPropertyName("addr")]
        public string? Address { get; set; }

        /// <summary>
        /// 获取或设置性别。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gender")]
        [System.Text.Json.Serialization.JsonPropertyName("gender")]
        public string? Gender { get; set; }

        /// <summary>
        /// 获取或设置民族。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nationality")]
        [System.Text.Json.Serialization.JsonPropertyName("nationality")]
        public string? Nationality { get; set; }

        /// <summary>
        /// 获取或设置有效期至。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("valid_date")]
        [System.Text.Json.Serialization.JsonPropertyName("valid_date")]
        public string? ValidDate { get; set; }
    }
}
