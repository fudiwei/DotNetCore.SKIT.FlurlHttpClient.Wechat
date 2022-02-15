using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/img/upload 接口的请求。</para>
    /// </summary>
    public class ProductImageUploadRequest : WechatApiRequest, IMapResponse<ProductImageUploadRequest, ProductImageUploadResponse>
    {
        /// <summary>
        /// 获取或设置返回数据类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int ResponseType { get; set; }

        /// <summary>
        /// 获取或设置图片文件字节数组。与字段 <see cref="ImageUrl"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[]? ImageFileBytes { get; set; }

        /// <summary>
        /// 获取或设置图片高度（单位：像素）。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? Height { get; set; }

        /// <summary>
        /// 获取或设置图片宽度（单位：像素）。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? Width { get; set; }

        /// <summary>
        /// 获取或设置图片文件 URL。与字段 <see cref="ImageFileBytes"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("img_url")]
        [System.Text.Json.Serialization.JsonPropertyName("img_url")]
        public string? ImageUrl { get; set; }
    }
}
