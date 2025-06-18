using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/voucher/codes/upload 接口的请求。</para>
    /// </summary>
    public class ChannelsECVoucherCodesUploadRequest : WechatApiRequest, IInferable<ChannelsECVoucherCodesUploadRequest, ChannelsECVoucherCodesUploadResponse>
    {
        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 获取或设置 SKU ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sku_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
        public long SKUId { get; set; }

        /// <summary>
        /// 获取或设置券码列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("codes")]
        [System.Text.Json.Serialization.JsonPropertyName("codes")]
        public IList<string> CodeList { get; set; } = new List<string>();
    }
}
