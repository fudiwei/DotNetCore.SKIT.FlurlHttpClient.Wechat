using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /card/getapplyprotocol 接口的响应。</para>
    /// </summary>
    public class CardGetApplyProtocolResponse : WechatApiResponse
    {
        public static class Types
        {
            public class PrimaryCategory
            {
                /// <summary>
                /// 获取或设置一级类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("primary_category_id")]
                [System.Text.Json.Serialization.JsonPropertyName("primary_category_id")]
                public int CategoryId { get; set; }

                /// <summary>
                /// 获取或设置一级类目名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category_name")]
                [System.Text.Json.Serialization.JsonPropertyName("category_name")]
                public string CategoryName { get; set; } = default!;

                /// <summary>
                /// 获取或设置二级类目列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("secondary_category")]
                [System.Text.Json.Serialization.JsonPropertyName("secondary_category")]
                public SecondaryCategory[] SubCategoryList { get; set; } = default!;
            }

            public class SecondaryCategory
            {
                /// <summary>
                /// 获取或设置二级类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("secondary_category_id")]
                [System.Text.Json.Serialization.JsonPropertyName("secondary_category_id")]
                public int CategoryId { get; set; }

                /// <summary>
                /// 获取或设置二级类目名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category_name")]
                [System.Text.Json.Serialization.JsonPropertyName("category_name")]
                public string CategoryName { get; set; } = default!;

                /// <summary>
                /// 获取或设置所需资质列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("need_qualification_stuffs")]
                [System.Text.Json.Serialization.JsonPropertyName("need_qualification_stuffs")]
                public string[]? NeedQualificationStuffList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置类目列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category")]
        [System.Text.Json.Serialization.JsonPropertyName("category")]
        public Types.PrimaryCategory[] CategoryList { get; set; } = default!;
    }
}
