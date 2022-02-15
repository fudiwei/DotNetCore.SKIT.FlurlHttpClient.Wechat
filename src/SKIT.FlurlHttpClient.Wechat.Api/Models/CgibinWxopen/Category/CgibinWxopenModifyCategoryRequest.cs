using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wxopen/modifycategory 接口的请求。</para>
    /// </summary>
    public class CgibinWxopenModifyCategoryRequest : WechatApiRequest, IMapResponse<CgibinWxopenModifyCategoryRequest, CgibinWxopenModifyCategoryResponse>
    {
        public static class Types
        {
            public class Qualification : CgibinWxopenAddCategoryRequest.Types.Category.Types.Qualification
            {
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
        public IList<Types.Qualification> QualificationList { get; set; } = new List<Types.Qualification>();
    }
}
