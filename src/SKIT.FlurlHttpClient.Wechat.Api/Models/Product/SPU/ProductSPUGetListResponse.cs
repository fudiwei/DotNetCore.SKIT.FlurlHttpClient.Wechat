namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/spu/get_list 接口的响应。</para>
    /// </summary>
    public class ProductSPUGetListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class SPU : ProductSPUGetResponse.Types.SPU
            {
            }
        }

        /// <summary>
        /// 获取或设置 SPU 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spus")]
        [System.Text.Json.Serialization.JsonPropertyName("spus")]
        public Types.SPU[] SPUList { get; set; } = default!;

        /// <summary>
        /// 获取或设置 SPU 总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int Total { get; set; }
    }
}
