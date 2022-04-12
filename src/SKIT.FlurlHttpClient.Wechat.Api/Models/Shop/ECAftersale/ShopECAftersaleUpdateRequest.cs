using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/ecaftersale/update 接口的请求。</para>
    /// </summary>
    public class ShopECAftersaleUpdateRequest : WechatApiRequest, IInferable<ShopECAftersaleUpdateRequest, ShopECAftersaleUpdateResponse>
    {
        public static class Types
        {
            public class Media : ShopECAftersaleAddRequest.Types.Media
            {
            }
        }

        /// <summary>
        /// 获取或设置售后单号。与字段 <see cref="OutAftersaleOrderId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aftersale_id")]
        [System.Text.Json.Serialization.JsonPropertyName("aftersale_id")]
        public long? AftersaleOrderId { get; set; }

        /// <summary>
        /// 获取或设置商家自定义售后单号。与字段 <see cref="AftersaleOrderId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_aftersale_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_aftersale_id")]
        public string? OutAftersaleOrderId { get; set; }

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置售后类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int Type { get; set; }

        /// <summary>
        /// 获取或设置退款金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orderamt")]
        [System.Text.Json.Serialization.JsonPropertyName("orderamt")]
        public int RefundAmount { get; set; }

        /// <summary>
        /// 获取或设置退款原因类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_reason_type")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_reason_type")]
        public int RefundReasonType { get; set; }

        /// <summary>
        /// 获取或设置退款原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_reason")]
        public string RefundReason { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置附件列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_list")]
        [System.Text.Json.Serialization.JsonPropertyName("media_list")]
        public IList<Types.Media>? MediaList { get; set; }
    }
}
