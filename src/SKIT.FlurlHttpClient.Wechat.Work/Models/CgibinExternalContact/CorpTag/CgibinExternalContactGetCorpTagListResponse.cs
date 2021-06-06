using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/get_corp_tag_list 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactGetCorpTagListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class TagGroup
            {
                public static class Types
                {
                    public class Tag
                    {
                        /// <summary>
                        /// 获取或设置企业标签 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public string TagId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置企业标签名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置次序值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order")]
                        [System.Text.Json.Serialization.JsonPropertyName("order")]
                        public int Order { get; set; }

                        /// <summary>
                        /// 获取或设置是否已经被删除。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("deleted")]
                        [System.Text.Json.Serialization.JsonPropertyName("deleted")]
                        public bool? IsDeleted { get; set; }

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        public long CreateTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置企业标签分组 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("group_id")]
                [System.Text.Json.Serialization.JsonPropertyName("group_id")]
                public string TagGroupId { get; set; } = default!;

                /// <summary>
                /// 获取或设置企业标签分组名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("group_name")]
                [System.Text.Json.Serialization.JsonPropertyName("group_name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置次序值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order")]
                [System.Text.Json.Serialization.JsonPropertyName("order")]
                public int Order { get; set; }

                /// <summary>
                /// 获取或设置企业标签列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tag")]
                [System.Text.Json.Serialization.JsonPropertyName("tag")]
                public Types.Tag[] TagList { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否已经被删除。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("deleted")]
                [System.Text.Json.Serialization.JsonPropertyName("deleted")]
                public bool? IsDeleted { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置企业标签分组列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tag_group")]
        [System.Text.Json.Serialization.JsonPropertyName("tag_group")]
        public Types.TagGroup[] TagGroupList { get; set; } = default!;
    }
}
