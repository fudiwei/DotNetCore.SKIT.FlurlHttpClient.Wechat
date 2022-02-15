using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cv/ocr/comm 接口的请求。</para>
    /// </summary>
    public class CVOCRCommonRequest : WechatApiRequest, IMapResponse<CVOCRCommonRequest, CVOCRCommonResponse>
    {
        /// <summary>
        /// 获取或设置要识别的图片 URL。与字段 <see cref="ImageFileBytes"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// 获取或设置要识别的图片文件字节数组。与字段 <see cref="ImageUrl"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[]? ImageFileBytes { get; set; }
    }
}
