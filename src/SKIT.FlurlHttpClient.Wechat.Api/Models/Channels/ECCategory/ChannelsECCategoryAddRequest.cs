﻿using System.Collections.Generic;

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
                /// <summary>
                /// 获取或设置一级类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("level1")]
                [System.Text.Json.Serialization.JsonPropertyName("level1")]
                public int FirstCategoryId { get; set; }

                /// <summary>
                /// 获取或设置二级类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("level2")]
                [System.Text.Json.Serialization.JsonPropertyName("level2")]
                public int SecondCategoryId { get; set; }

                /// <summary>
                /// 获取或设置三级类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("level3")]
                [System.Text.Json.Serialization.JsonPropertyName("level3")]
                public int ThirdCategoryId { get; set; }

                /// <summary>
                /// 获取或设置资质材料图片 MediaId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("certificate")]
                [System.Text.Json.Serialization.JsonPropertyName("certificate")]
                public IList<string>? CertificateMediaIdList { get; set; }
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
