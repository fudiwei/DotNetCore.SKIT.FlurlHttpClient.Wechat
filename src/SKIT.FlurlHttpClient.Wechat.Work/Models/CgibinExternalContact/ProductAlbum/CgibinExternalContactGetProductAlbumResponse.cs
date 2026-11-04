namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/get_product_album 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactGetProductAlbumResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Product : CgibinExternalContactGetProductAlbumListResponse.Types.__zz__Product
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

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product")]
        [System.Text.Json.Serialization.JsonPropertyName("product")]
        public Types.Product? Product { get; set; }
    }
}
