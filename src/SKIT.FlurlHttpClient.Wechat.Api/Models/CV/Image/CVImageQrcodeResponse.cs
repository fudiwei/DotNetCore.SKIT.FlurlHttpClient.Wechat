namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cv/img/qrcode 接口的响应。</para>
    /// </summary>
    public class CVImageQrcodeResponse : WechatApiResponse
    {
        public static class Types
        {
            public class CodeResult
            {
                public static class Types
                {
                    public class Position
                    {
                        public static class Types
                        {
                            public class Point
                            {
                                /// <summary>
                                /// 获取或设置 X 轴坐标（单位：像素）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("x")]
                                [System.Text.Json.Serialization.JsonPropertyName("x")]
                                public int X { get; set; }

                                /// <summary>
                                /// 获取或设置 Y 轴桌标（单位：像素）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("y")]
                                [System.Text.Json.Serialization.JsonPropertyName("y")]
                                public int Y { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置左上角坐标信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("left_top")]
                        [System.Text.Json.Serialization.JsonPropertyName("left_top")]
                        public Types.Point LeftTop { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置右上角坐标信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("right_top")]
                        [System.Text.Json.Serialization.JsonPropertyName("right_top")]
                        public Types.Point RightTop { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置右下角坐标信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("right_bottom")]
                        [System.Text.Json.Serialization.JsonPropertyName("right_bottom")]
                        public Types.Point RightBottom { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置左下角坐标信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("left_bottom")]
                        [System.Text.Json.Serialization.JsonPropertyName("left_bottom")]
                        public Types.Point LeftBottom { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置识别类型名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type_name")]
                [System.Text.Json.Serialization.JsonPropertyName("type_name")]
                public string TypeName { get; set; } = default!;

                /// <summary>
                /// 获取或设置识别内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("data")]
                [System.Text.Json.Serialization.JsonPropertyName("data")]
                public string? Data { get; set; }

                /// <summary>
                /// 获取或设置识别坐标信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pos")]
                [System.Text.Json.Serialization.JsonPropertyName("pos")]
                public Types.Position? Position { get; set; }
            }

            public class ImageSize
            {
                /// <summary>
                /// 获取或设置智能裁剪宽度（单位：像素）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("w")]
                [System.Text.Json.Serialization.JsonPropertyName("w")]
                public int Width { get; set; }

                /// <summary>
                /// 获取或设置智能裁剪高度（单位：像素）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("h")]
                [System.Text.Json.Serialization.JsonPropertyName("h")]
                public int Height { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置识别结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code_results")]
        [System.Text.Json.Serialization.JsonPropertyName("code_results")]
        public Types.CodeResult[] ResultList { get; set; } = default!;

        /// <summary>
        /// 获取或设置图片大小信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("img_size")]
        [System.Text.Json.Serialization.JsonPropertyName("img_size")]
        public Types.ImageSize ImageSize { get; set; } = default!;
    }
}
