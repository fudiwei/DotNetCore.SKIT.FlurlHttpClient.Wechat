namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/ecaftersale/get 接口的响应。</para>
    /// </summary>
    public class ShopECAftersaleGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class AftersaleOrder : ShopECAftersaleGetListResponse.Types.AftersaleOrder
            {
            }
        }

        /// <summary>
        /// 获取或设置售后单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("after_sales_order")]
        [System.Text.Json.Serialization.JsonPropertyName("after_sales_order")]
        public Types.AftersaleOrder AftersaleOrder { get; set; } = default!;
    }
}
