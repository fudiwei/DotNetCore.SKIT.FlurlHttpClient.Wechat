using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant/shelf/getbyid 接口的响应。</para>
    /// </summary>
    public class MerchantShelfGetByIdResponse : WechatApiResponse
    {
        public static class Types
        {
            public class ShelfData
            {
                public static class Types
                {
                    public class Module
                    {
                        public static class Types
                        {
                            public class Group
                            {
                                public static class Types
                                {
                                    public class Filter
                                    {
                                        /// <summary>
                                        /// 获取或设置展示商品个数。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("count")]
                                        [System.Text.Json.Serialization.JsonPropertyName("count")]
                                        public int? Count { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置分组 Id。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("group_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("group_id")]
                                public int GroupId { get; set; }

                                /// <summary>
                                /// 获取或设置分组图片 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("img")]
                                [System.Text.Json.Serialization.JsonPropertyName("img")]
                                public string? ImageUrl { get; set; }

                                /// <summary>
                                /// 获取或设置分组条件信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("filter")]
                                [System.Text.Json.Serialization.JsonPropertyName("filter")]
                                public Types.Filter? Filter { get; set; }
                            }

                            public class Groups
                            {
                                /// <summary>
                                /// 获取或设置分组列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("groups")]
                                [System.Text.Json.Serialization.JsonPropertyName("groups")]
                                public Group[] GroupList { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置分组背景图片 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("img_background")]
                                [System.Text.Json.Serialization.JsonPropertyName("img_background")]
                                public string? BackgroundImageUrl { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置控件 Id。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("eid")]
                        [System.Text.Json.Serialization.JsonPropertyName("eid")]
                        public int EId { get; set; }

                        /// <summary>
                        /// 获取或设置单个分组信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("group_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("group_info")]
                        public Types.Group? Group { get; set; }

                        /// <summary>
                        /// 获取或设置多个分组信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("group_infos")]
                        [System.Text.Json.Serialization.JsonPropertyName("group_infos")]
                        public Types.Groups? Groups { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置货架控件列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("module_infos")]
                [System.Text.Json.Serialization.JsonPropertyName("module_infos")]
                public Types.Module[] ModuleList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置货架 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shelf_id")]
        [System.Text.Json.Serialization.JsonPropertyName("shelf_id")]
        public int ShelfId { get; set; }

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
