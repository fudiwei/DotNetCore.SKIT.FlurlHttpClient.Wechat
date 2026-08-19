namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/aftersale/getexchangeableskulist 接口的响应。</para>
    /// </summary>
    public class ChannelsECAftersaleGetExchangeableSKUListResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置 SKU ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sku_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("sku_id_list")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public long[] SKUIdList { get; set; } = default!;
    }
}
