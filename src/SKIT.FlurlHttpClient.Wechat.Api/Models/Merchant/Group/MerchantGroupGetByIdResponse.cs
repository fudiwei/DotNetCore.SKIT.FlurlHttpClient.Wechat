using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant/group/getbyid 接口的响应。</para>
    /// </summary>
    public class MerchantGroupGetByIdResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Group
            {
                /// <summary>
                /// 获取或设置分组 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("group_id")]
                [System.Text.Json.Serialization.JsonPropertyName("group_id")]
                public int GroupId { get; set; }

                /// <summary>
                /// 获取或设置分组名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("group_name")]
                [System.Text.Json.Serialization.JsonPropertyName("group_name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_list")]
                [System.Text.Json.Serialization.JsonPropertyName("product_list")]
                public string[] ProductIdList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置分组信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("group_detail")]
        public Types.Group Group { get; set; } = default!;
    }
}
