namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/spu/get_list 接口的请求。</para>
    /// </summary>
    public class ProductSPUGetListRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置指定商品上线状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int ListingStatus { get; set; }

        /// <summary>
        /// 获取或设置分页页数（从 1 开始）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page")]
        [System.Text.Json.Serialization.JsonPropertyName("page")]
        public int Page { get; set; } = 1;

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int Limit { get; set; } = 10;

        /// <summary>
        /// 获取或设置是否获取草稿数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_edit_spu")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("need_edit_spu")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? RequireEdittingSPU { get; set; }
    }
}
