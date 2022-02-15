using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/service/check_auth 接口的请求。</para>
    /// </summary>
    public class ProductServiceCheckAuthRequest : WechatApiRequest, IMapResponse<ProductServiceCheckAuthRequest, ProductServiceCheckAuthResponse>
    {
        /// <summary>
        /// 获取或设置跳转码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string Code { get; set; } = string.Empty;
    }
}
