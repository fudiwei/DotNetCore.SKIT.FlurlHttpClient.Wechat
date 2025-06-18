using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/complaint/upload_material 接口的请求。</para>
    /// </summary>
    public class ShopComplaintUploadMaterialRequest : WechatApiRequest, IInferable<ShopComplaintUploadMaterialRequest, ShopComplaintUploadMaterialResponse>
    {
        public static class Types
        {
            public class Material
            {
                /// <summary>
                /// 获取或设置文本信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public string Content { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置图片 URL 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("media_url_list")]
                [System.Text.Json.Serialization.JsonPropertyName("media_url_list")]
                public IList<string> MediaUrlList { get; set; } = new List<string>();
            }
        }

        /// <summary>
        /// 获取或设置纠纷单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("complaint_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("complaint_order_id")]
        public long ComplaintOrderId { get; set; }

        /// <summary>
        /// 获取或设置凭证信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("material_info")]
        [System.Text.Json.Serialization.JsonPropertyName("material_info")]
        public Types.Material Material { get; set; } = new Types.Material();
    }
}
