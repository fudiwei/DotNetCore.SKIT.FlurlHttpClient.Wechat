using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/modify_merchant 接口的请求。</para>
    /// </summary>
    public class WxaModifyMerchantRequest : WechatApiRequest, IMapResponse<WxaModifyMerchantRequest, WxaModifyMerchantResponse>
    {
        /// <summary>
        /// 获取或设置门店小程序的介绍。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("intro")]
        [System.Text.Json.Serialization.JsonPropertyName("intro")]
        public string Introduction { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置门店小程序的头像媒体文件标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("headimg_mediaid")]
        [System.Text.Json.Serialization.JsonPropertyName("headimg_mediaid")]
        public string HeadImageMediaId { get; set; } = string.Empty;
    }
}
