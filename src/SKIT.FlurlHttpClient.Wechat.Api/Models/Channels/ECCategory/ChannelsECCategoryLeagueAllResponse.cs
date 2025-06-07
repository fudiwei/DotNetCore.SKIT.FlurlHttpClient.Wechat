using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /channels/ec/category/league/all 接口的响应。</para>
    /// </summary>
    public class ChannelsECCategoryLeagueAllResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Category : ChannelsECCategoryAllResponse.Types.Category
            {
            }
        }

        /// <summary>
        /// 获取或设置类目列表。
        /// </summary>
        [Obsolete("相关接口或字段于 2024-10-28 下线。")]
        [Newtonsoft.Json.JsonProperty("cats")]
        [System.Text.Json.Serialization.JsonPropertyName("cats")]
        public Types.Category[] CategoryList { get; set; } = default!;

        /// <summary>
        /// 获取或设置新版类目列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cats_v2")]
        [System.Text.Json.Serialization.JsonPropertyName("cats_v2")]
        public Types.Category[] CategoryV2List { get; set; } = default!;
    }
}
