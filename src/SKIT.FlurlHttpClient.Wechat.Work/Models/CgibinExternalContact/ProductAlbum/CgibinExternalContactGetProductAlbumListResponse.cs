namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/get_product_album_list 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactGetProductAlbumListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public abstract class __zz__Product
            {
                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                public string? ProductId { get; set; }

                /// <summary>
                /// 获取或设置商品描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string? Description { get; set; }

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
            }

            public class Product : __zz__Product
            {
                public static class Types
                {
                    public class Attachment : CgibinExternalContactAddProductAlbumRequest.Types.__zz__Attachment
                    {
                        public static class Types
                        {
                            public class Image : CgibinExternalContactAddProductAlbumRequest.Types.Attachment.Types.Image
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置图片附件信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("image")]
                        [System.Text.Json.Serialization.JsonPropertyName("image")]
                        public Types.Image? Image { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商品附件列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("attachments")]
                [System.Text.Json.Serialization.JsonPropertyName("attachments")]
                public List<Types.Attachment>? AttachmentList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// 获取或设置商品列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_list")]
        [System.Text.Json.Serialization.JsonPropertyName("product_list")]
        public List<Types.Product>? ProductList { get; set; }
    }
}
