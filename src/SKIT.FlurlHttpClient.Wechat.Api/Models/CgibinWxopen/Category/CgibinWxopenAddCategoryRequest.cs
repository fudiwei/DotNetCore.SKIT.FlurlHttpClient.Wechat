using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wxopen/addcategory 接口的请求。</para>
    /// </summary>
    public class CgibinWxopenAddCategoryRequest : WechatApiRequest, IInferable<CgibinWxopenAddCategoryRequest, CgibinWxopenAddCategoryResponse>
    {
        public static class Types
        {
            public class Category
            {
                public static class Types
                {
                    public class Qualification
                    {
                        /// <summary>
                        /// 获取或设置资质名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("key")]
                        [System.Text.Json.Serialization.JsonPropertyName("key")]
                        public string Name { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置资质图片 MediaId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("value")]
                        [System.Text.Json.Serialization.JsonPropertyName("value")]
                        public string PictureMediaId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置资质过期时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("expire_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
                        public long? ExpireTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置资质是否永久有效。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_permanent")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("is_permanent")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                        public bool? IsPermanent { get; set; }
                    }
                }

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

                /// <summary>
                /// 获取或设置资质证明列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("certicates")]
                [System.Text.Json.Serialization.JsonPropertyName("certicates")]
                public IList<Types.Qualification>? QualificationList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置类目列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("categories")]
        [System.Text.Json.Serialization.JsonPropertyName("categories")]
        public IList<Types.Category> CategoryList { get; set; } = new List<Types.Category>();
    }
}
