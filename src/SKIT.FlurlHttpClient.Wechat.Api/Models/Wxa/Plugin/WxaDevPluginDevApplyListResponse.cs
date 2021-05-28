using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/devplugin?action=dev_apply_list 接口的响应。</para>
    /// </summary>
    public class WxaDevPluginDevApplyListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Applyment
            {
                public static class Types
                {
                    public class Category
                    {
                        /// <summary>
                        /// 获取或设置一级分类。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("first")]
                        [System.Text.Json.Serialization.JsonPropertyName("first")]
                        public string FirstCategory { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置二级分类。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("second")]
                        [System.Text.Json.Serialization.JsonPropertyName("second")]
                        public string? SecondCategory { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置使用者 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置申请状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置使用者昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nickname")]
                [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                public string Nickname { get; set; } = default!;

                /// <summary>
                /// 获取或设置使用者头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("headimgurl")]
                [System.Text.Json.Serialization.JsonPropertyName("headimgurl")]
                public string HeadImageUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置使用者的类目列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("categories")]
                [System.Text.Json.Serialization.JsonPropertyName("categories")]
                public Types.Category[] CategoryList { get; set; } = default!;

                /// <summary>
                /// 获取或设置使用者的小程序码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("apply_url")]
                [System.Text.Json.Serialization.JsonPropertyName("apply_url")]
                public string ApplyUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置使用者的申请说明。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reason")]
                [System.Text.Json.Serialization.JsonPropertyName("reason")]
                public string Reason { get; set; } = default!;

                /// <summary>
                /// 获取或设置使用者的申请时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long CreateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置插件使用方列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apply_list")]
        [System.Text.Json.Serialization.JsonPropertyName("apply_list")]
        public Types.Applyment[] ApplymentList { get; set; } = default!;
    }
}
