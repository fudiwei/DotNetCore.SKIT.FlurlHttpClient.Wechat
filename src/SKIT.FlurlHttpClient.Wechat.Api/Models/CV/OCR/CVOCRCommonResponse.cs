namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cv/ocr/comm 接口的响应。</para>
    /// </summary>
    public class CVOCRCommonResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Result
            {
                public static class Types
                {
                    public class Position
                    {
                        public static class Types
                        {
                            public class Point : CVImageQrcodeResponse.Types.ImagePosition.Types.Point
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置左上角坐标信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("left_top")]
                        [System.Text.Json.Serialization.JsonPropertyName("left_top")]
                        public Types.Point? LeftTop { get; set; }

                        /// <summary>
                        /// 获取或设置右上角坐标信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("right_top")]
                        [System.Text.Json.Serialization.JsonPropertyName("right_top")]
                        public Types.Point? RightTop { get; set; }

                        /// <summary>
                        /// 获取或设置右下角坐标信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("right_bottom")]
                        [System.Text.Json.Serialization.JsonPropertyName("right_bottom")]
                        public Types.Point? RightBottom { get; set; }

                        /// <summary>
                        /// 获取或设置左下角坐标信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("left_bottom")]
                        [System.Text.Json.Serialization.JsonPropertyName("left_bottom")]
                        public Types.Point? LeftBottom { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置识别文本信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("text")]
                [System.Text.Json.Serialization.JsonPropertyName("text")]
                public string? Text { get; set; }

                /// <summary>
                /// 获取或设置识别坐标信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pos")]
                [System.Text.Json.Serialization.JsonPropertyName("pos")]
                public Types.Position? Position { get; set; }
            }

            public class ImageSize : CVImageQrcodeResponse.Types.ImageSize
            {
            }
        }

        /// <summary>
        /// 获取或设置识别结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("items")]
        [System.Text.Json.Serialization.JsonPropertyName("items")]
        public List<Types.Result>? ResultList { get; set; }

        /// <summary>
        /// 获取或设置图片大小信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("img_size")]
        [System.Text.Json.Serialization.JsonPropertyName("img_size")]
        public Types.ImageSize? ImageSize { get; set; }
    }
}
