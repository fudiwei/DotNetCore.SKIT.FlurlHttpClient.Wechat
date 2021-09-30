using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/update_product_album 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactUpdateProductAlbumRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Attachment : CgibinExternalContactAddProductAlbumRequest.Types.Attachment
            {
            }
        }

        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public string ProductId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商品描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商品价格（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("price")]
        [System.Text.Json.Serialization.JsonPropertyName("price")]
        public int Price { get; set; }

        /// <summary>
        /// 获取或设置商品编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_sn")]
        [System.Text.Json.Serialization.JsonPropertyName("product_sn")]
        public string? SerialNumber { get; set; }

        /// <summary>
        /// 获取或设置商品附件列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attachments")]
        [System.Text.Json.Serialization.JsonPropertyName("attachments")]
        public IList<Types.Attachment>? AttachmentList { get; set; }
    }
}
