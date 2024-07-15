namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /channels/ec/category/list/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECCategoryListGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class CategoryAndQualification
            {
                /// <summary>
                /// 获取或设置类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cat_id")]
                [System.Text.Json.Serialization.JsonPropertyName("cat_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long CategoryId { get; set; }

                /// <summary>
                /// 获取或设置资质 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qua_id")]
                [System.Text.Json.Serialization.JsonPropertyName("qua_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int? QualificationId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置类目和资质列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.CategoryAndQualification[] CategoryAndQualificationList { get; set; } = default!;
    }
}
