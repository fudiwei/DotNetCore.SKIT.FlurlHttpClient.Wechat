using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /merchant/shelf/getall 接口的响应。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2020-10-01 下线。")]
    public class MerchantShelfGetAllResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Shelf
            {
                public static class Types
                {
                    public class ShelfData : MerchantShelfGetByIdResponse.Types.ShelfData
                    {
                    }
                }

                /// <summary>
                /// 获取或设置货架 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shelf_id")]
                [System.Text.Json.Serialization.JsonPropertyName("shelf_id")]
                public long ShelfId { get; set; }

                /// <summary>
                /// 获取或设置货架数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shelf_info")]
                [System.Text.Json.Serialization.JsonPropertyName("shelf_info")]
                public Types.ShelfData ShelfData { get; set; } = default!;

                /// <summary>
                /// 获取或设置货架 Banner URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shelf_banner")]
                [System.Text.Json.Serialization.JsonPropertyName("shelf_banner")]
                public string ShelfBannerUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置货架名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shelf_name")]
                [System.Text.Json.Serialization.JsonPropertyName("shelf_name")]
                public string ShelfName { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置货架列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shelves")]
        [System.Text.Json.Serialization.JsonPropertyName("shelves")]
        public Types.Shelf[] ShelfList { get; set; } = default!;
    }
}
