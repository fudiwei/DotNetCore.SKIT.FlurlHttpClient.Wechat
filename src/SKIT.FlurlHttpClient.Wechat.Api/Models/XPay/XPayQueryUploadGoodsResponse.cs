namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/query_upload_goods 接口的响应。</para>
    /// </summary>
    public class XPayQueryUploadGoodsResponse : WechatApiResponse
    {
        public static class Types
        {
            public class UploadItem
            {
                /// <summary>
                /// 获取或设置道具 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public string Id { get; set; } = default!;

                /// <summary>
                /// 获取或设置道具名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置道具单价（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("price")]
                [System.Text.Json.Serialization.JsonPropertyName("price")]
                public int Price { get; set; }

                /// <summary>
                /// 获取或设置备注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remark")]
                [System.Text.Json.Serialization.JsonPropertyName("remark")]
                public string? Remark { get; set; }

                /// <summary>
                /// 获取或设置图片 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item_url")]
                [System.Text.Json.Serialization.JsonPropertyName("item_url")]
                public string? PictureUrl { get; set; }

                /// <summary>
                /// 获取或设置上传状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("upload_status")]
                [System.Text.Json.Serialization.JsonPropertyName("upload_status")]
                public int UploadStatus { get; set; }

                /// <summary>
                /// 获取或设置上传失败原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errmsg")]
                [System.Text.Json.Serialization.JsonPropertyName("errmsg")]
                public string? FailReason { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置道具列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("upload_item")]
        [System.Text.Json.Serialization.JsonPropertyName("upload_item")]
        public Types.UploadItem[] UploadItemList { get; set; } = default!;

        /// <summary>
        /// 获取或设置上传状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }
    }
}
