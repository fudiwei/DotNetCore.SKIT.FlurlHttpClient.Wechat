namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wxopen/deletecategory 接口的请求。</para>
    /// </summary>
    public class CgibinWxopenDeleteCategoryRequest : WechatApiRequest, IInferable<CgibinWxopenDeleteCategoryRequest, CgibinWxopenDeleteCategoryResponse>
    {
        /// <summary>
        /// 获取或设置一级类目 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("first")]
        [System.Text.Json.Serialization.JsonPropertyName("first")]
        public int FirstCategoryId { get; set; }

        /// <summary>
        /// 获取或设置二级类目 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("second")]
        [System.Text.Json.Serialization.JsonPropertyName("second")]
        public int SecondCategoryId { get; set; }
    }
}
