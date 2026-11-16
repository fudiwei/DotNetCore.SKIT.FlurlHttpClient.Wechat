namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/begintimingsale 接口的请求。</para>
    /// </summary>
    public class ChannelsECProductCategoryBeginTimingSaleRequest : WechatApiRequest, IInferable<ChannelsECProductCategoryBeginTimingSaleRequest, ChannelsECProductCategoryBeginTimingSaleResponse>
    {
        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberConverter))]
        public long ProductId { get; set; }

        /// <summary>
        /// 获取或设置定时开售任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_id")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.NumericStringConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("task_id")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericStringConverter))]
        public string? TaskId { get; set; }
    }
}
