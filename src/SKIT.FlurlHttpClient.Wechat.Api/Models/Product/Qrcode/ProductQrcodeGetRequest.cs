﻿namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/qrcode/get 接口的请求。</para>
    /// </summary>
    public class ProductQrcodeGetRequest : WechatApiRequest, IInferable<ProductQrcodeGetRequest, ProductQrcodeGetResponse>
    {
        /// <summary>
        /// 获取或设置二维码 Ticket。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ticket")]
        [System.Text.Json.Serialization.JsonPropertyName("ticket")]
        public string QrcodeTicket { get; set; } = string.Empty;
    }
}
