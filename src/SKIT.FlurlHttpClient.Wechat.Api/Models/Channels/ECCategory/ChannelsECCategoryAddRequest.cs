using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/category/add 接口的请求。</para>
    /// </summary>
    public class ChannelsECCategoryAddRequest : WechatApiRequest, IInferable<ChannelsECCategoryAddRequest, ChannelsECCategoryAddResponse>
    {
        public static class Types
        {
            public class Category
            {
                public static class Types
                {
                    public class Brand
                    {
                        /// <summary>
                        /// 获取或设置品牌 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("brand_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
                        public long BrandId { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置一级类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("level1")]
                [System.Text.Json.Serialization.JsonPropertyName("level1")]
                public long FirstCategoryId { get; set; }

                /// <summary>
                /// 获取或设置二级类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("level2")]
                [System.Text.Json.Serialization.JsonPropertyName("level2")]
                public long SecondCategoryId { get; set; }

                /// <summary>
                /// 获取或设置三级类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("level3")]
                [System.Text.Json.Serialization.JsonPropertyName("level3")]
                public long ThirdCategoryId { get; set; }

                /// <summary>
                /// 获取或设置资质材料图片 MediaId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("certificate")]
                [System.Text.Json.Serialization.JsonPropertyName("certificate")]
                public IList<string>? CertificateMediaIdList { get; set; }

                /// <summary>
                /// 获取或设置品牌列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brand_list")]
                [System.Text.Json.Serialization.JsonPropertyName("brand_list")]
                public IList<Types.Brand>? BrandList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置类目信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_info")]
        [System.Text.Json.Serialization.JsonPropertyName("category_info")]
        public Types.Category Category { get; set; } = new Types.Category();
    }
}
