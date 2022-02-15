using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/img/upload 接口的请求。</para>
    /// </summary>
    public class ShopImageUploadRequest : WechatApiRequest, IMapResponse<ShopImageUploadRequest, ShopImageUploadResponse>
    {
        /// <summary>
        /// 获取或设置图片文件字节数组。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[] ImageFileBytes { get; set; } = new byte[0];
    }
}
