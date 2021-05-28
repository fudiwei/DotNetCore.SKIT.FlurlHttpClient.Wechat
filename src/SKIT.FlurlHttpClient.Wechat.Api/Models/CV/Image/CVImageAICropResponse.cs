using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cv/img/aicrop 接口的响应。</para>
    /// </summary>
    public class CVImageAICropResponse : WechatApiResponse
    {
        public static class Types
        {
            public class ImageResult
            {
                /// <summary>
                /// 获取或设置智能裁剪左边距（单位：像素）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("crop_left")]
                [System.Text.Json.Serialization.JsonPropertyName("crop_left")]
                public int CropLeft { get; set; }

                /// <summary>
                /// 获取或设置智能裁剪上边距（单位：像素）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("crop_top")]
                [System.Text.Json.Serialization.JsonPropertyName("crop_top")]
                public int CropTop { get; set; }

                /// <summary>
                /// 获取或设置智能裁剪右边距（单位：像素）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("crop_right")]
                [System.Text.Json.Serialization.JsonPropertyName("crop_right")]
                public int CropRight { get; set; }

                /// <summary>
                /// 获取或设置智能裁剪左边距（单位：像素）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("crop_bottom")]
                [System.Text.Json.Serialization.JsonPropertyName("crop_bottom")]
                public int CropBottom { get; set; }
            }

            public class ImageSize : CVImageQrcodeResponse.Types.ImageSize
            {
            }
        }

        /// <summary>
        /// 获取或设置裁剪结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("results")]
        [System.Text.Json.Serialization.JsonPropertyName("results")]
        public Types.ImageResult[] ResultList { get; set; } = default!;

        /// <summary>
        /// 获取或设置图片大小信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("img_size")]
        [System.Text.Json.Serialization.JsonPropertyName("img_size")]
        public Types.ImageSize ImageSize { get; set; } = default!;
    }
}
