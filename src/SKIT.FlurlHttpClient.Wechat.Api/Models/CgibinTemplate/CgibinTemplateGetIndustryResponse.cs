namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/template/get_industry 接口的响应。</para>
    /// </summary>
    public class CgibinTemplateGetIndustryResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Industry
            {
                /// <summary>
                /// 获取或设置行业一级分类。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("first_class")]
                [System.Text.Json.Serialization.JsonPropertyName("first_class")]
                public string FirstClass { get; set; } = default!;
                /// <summary>
                /// 获取或设置行业二级分类。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("second_class")]
                [System.Text.Json.Serialization.JsonPropertyName("second_class")]
                public string SecondClass { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置主行业信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("primary_industry")]
        [System.Text.Json.Serialization.JsonPropertyName("primary_industry")]
        public Types.Industry? PrimaryIndustry { get; set; }

        /// <summary>
        /// 获取或设置副行业信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("secondary_industry")]
        [System.Text.Json.Serialization.JsonPropertyName("secondary_industry")]
        public Types.Industry? SecondaryIndustry { get; set; }
    }
}
