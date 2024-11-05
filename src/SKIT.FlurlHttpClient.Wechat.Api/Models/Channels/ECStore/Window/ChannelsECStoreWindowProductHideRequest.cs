namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/store/window/product/hide 接口的请求。</para>
    /// </summary>
    public class ChannelsECStoreWindowProductHideRequest : WechatApiRequest, IInferable<ChannelsECStoreWindowProductHideRequest, ChannelsECStoreWindowProductHideResponse>
    {
        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 获取或设置是否隐藏。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_set_hide")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("is_set_hide")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool IsSetHide { get; set; }
    }
}
