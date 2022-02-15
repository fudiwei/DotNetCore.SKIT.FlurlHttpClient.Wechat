namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/order/getaftersaleorder 接口的响应。</para>
    /// </summary>
    public class ProductOrderGetAftersaleOrderResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Aftersale : ProductOrderBatchGetAftersaleOrderResponse.Types.Aftersale
            {
            }
        }

        /// <summary>
        /// 获取或设置售后单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("after_sale_order")]
        [System.Text.Json.Serialization.JsonPropertyName("after_sale_order")]
        public Types.Aftersale AftersaleOrder { get; set; } = default!;
    }
}
