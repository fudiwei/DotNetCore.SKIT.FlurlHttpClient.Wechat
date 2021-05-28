using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant/group/add 接口的请求。</para>
    /// </summary>
    public class MerchantGroupAddRequest : WechatApiRequest
    {
        public static class Types
        {
            public class Group
            {
                /// <summary>
                /// 获取或设置分组名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("group_name")]
                [System.Text.Json.Serialization.JsonPropertyName("group_name")]
                public string Name { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置商品 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_list")]
                [System.Text.Json.Serialization.JsonPropertyName("product_list")]
                public IList<string> ProductIdList { get; set; } = new List<string>();
            }
        }

        /// <summary>
        /// 获取或设置分组信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("group_detail")]
        public Types.Group Group { get; set; } = new Types.Group();
    }
}
