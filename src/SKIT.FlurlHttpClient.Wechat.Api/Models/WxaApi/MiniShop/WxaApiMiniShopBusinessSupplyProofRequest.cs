using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/minishop/bussiSupplyProof 接口的请求。</para>
    /// </summary>
    public class WxaApiMiniShopBusinessSupplyProofRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置投诉单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("complaintOrderId")]
        [System.Text.Json.Serialization.JsonPropertyName("complaintOrderId")]
        public long ComplaintOrderId { get; set; }

        /// <summary>
        /// 获取或设置内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 获取或设置图片 MediaId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mediaIdList")]
        [System.Text.Json.Serialization.JsonPropertyName("mediaIdList")]
        public IList<string>? MediaIdList { get; set; }
    }
}
