namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/get_product_album_list 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactGetProductAlbumListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Product
            {
                public static class Types
                {
                    public class Attachment
                    {
                        public static class Types
                        {
                            public class Image
                            {
                                /// <summary>
                                /// 获取或设置图片 MediaId。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("media_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("media_id")]
                                public string MediaId { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置附件类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public string Type { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置图片附件信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("image")]
                        [System.Text.Json.Serialization.JsonPropertyName("image")]
                        public Types.Image? Image { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                public string ProductId { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string Description { get; set; } = default!;

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
                public Types.Attachment[]? AttachmentList { get; set; }
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
        public Types.Product[] ProductList { get; set; } = default!;
    }
}
