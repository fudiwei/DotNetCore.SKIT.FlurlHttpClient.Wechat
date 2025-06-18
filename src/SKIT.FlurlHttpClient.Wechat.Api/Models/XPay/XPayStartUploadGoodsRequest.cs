using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/start_upload_goods 接口的请求。</para>
    /// </summary>
    public class XPayStartUploadGoodsRequest : XPayRequestBase, IInferable<XPayStartUploadGoodsRequest, XPayStartUploadGoodsResponse>
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
                public string Id { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置道具名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = string.Empty;

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
            }
        }

        /// <summary>
        /// 获取或设置道具列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("upload_item")]
        [System.Text.Json.Serialization.JsonPropertyName("upload_item")]
        public IList<Types.UploadItem> UploadItemList { get; set; } = new List<Types.UploadItem>();

        protected internal override string GetRequestPath()
        {
            return "/xpay/start_upload_goods";
        }
    }
}
