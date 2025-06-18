namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/book/getbook 接口的响应。</para>
    /// </summary>
    public class WxaBookGetBookResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Book : WxaBookListBookResponse.Types.Book
            {
                public static new class Types
                {
                    public class Volumn
                    {
                        /// <summary>
                        /// 获取或设置分卷名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("volume_title")]
                        [System.Text.Json.Serialization.JsonPropertyName("volume_title")]
                        public string Title { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置分卷起始章节下标。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("start_index")]
                        [System.Text.Json.Serialization.JsonPropertyName("start_index")]
                        public int StartIndex { get; set; }

                        /// <summary>
                        /// 获取或设置分卷截止章节下标。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("end_index")]
                        [System.Text.Json.Serialization.JsonPropertyName("end_index")]
                        public int EndIndex { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置一级类型 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("first_category_name")]
                [System.Text.Json.Serialization.JsonPropertyName("first_category_name")]
                public string FirstCategoryName { get; set; } = default!;

                /// <summary>
                /// 获取或设置二级类型 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("second_category_name")]
                [System.Text.Json.Serialization.JsonPropertyName("second_category_name")]
                public string SecondCategoryName { get; set; } = default!;

                /// <summary>
                /// 获取或设置三级类型 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("third_category_name")]
                [System.Text.Json.Serialization.JsonPropertyName("third_category_name")]
                public string ThirdCategoryName { get; set; } = default!;

                /// <summary>
                /// 获取或设置分卷列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("volume_list")]
                [System.Text.Json.Serialization.JsonPropertyName("volume_list")]
                public Types.Volumn[] VolumnList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置作品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("book")]
        [System.Text.Json.Serialization.JsonPropertyName("book")]
        public Types.Book Book { get; set; } = default!;
    }
}
