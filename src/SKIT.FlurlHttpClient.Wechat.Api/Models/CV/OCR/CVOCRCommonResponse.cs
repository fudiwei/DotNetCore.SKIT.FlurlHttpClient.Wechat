using System;
using System.Collections.Generic;

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
                    public class Position : CVImageQrcodeResponse.Types.CodeResult.Types.Position
                    {
                    }
                }

                /// <summary>
                /// 获取或设置识别文本信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("text")]
                [System.Text.Json.Serialization.JsonPropertyName("text")]
                public string Text { get; set; } = default!;

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
        /// 获取或设置识别结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("items")]
        [System.Text.Json.Serialization.JsonPropertyName("items")]
        public Types.Result[] ResultList { get; set; } = default!;

        /// <summary>
        /// 获取或设置图片大小信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("img_size")]
        [System.Text.Json.Serialization.JsonPropertyName("img_size")]
        public Types.ImageSize ImageSize { get; set; } = default!;
    }
}
