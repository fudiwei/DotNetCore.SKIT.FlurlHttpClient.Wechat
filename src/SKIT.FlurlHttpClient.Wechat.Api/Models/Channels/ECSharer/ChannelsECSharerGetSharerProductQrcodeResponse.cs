using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/sharer/get_sharer_product_qrcode 接口的响应。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2025-03-07 下线。")]
    public class ChannelsECSharerGetSharerProductQrcodeResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置商品二维码链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_qrcode")]
        [System.Text.Json.Serialization.JsonPropertyName("product_qrcode")]
        public string ProductQrcode { get; set; } = default!;
    }
}
