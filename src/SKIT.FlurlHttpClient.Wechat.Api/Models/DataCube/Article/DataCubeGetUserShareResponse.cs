using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /datacube/getusershare 接口的响应。</para>
    /// </summary>
    public class DataCubeGetUserShareResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置数据的日期（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ref_date")]
                [System.Text.Json.Serialization.JsonPropertyName("ref_date")]
                public string RefDateString { get; set; } = default!;

                /// <summary>
                /// 获取或设置分享的场景。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("share_scene")]
                [System.Text.Json.Serialization.JsonPropertyName("share_scene")]
                public int ShareScene { get; set; }

                /// <summary>
                /// 获取或设置分享的人数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("share_user")]
                [System.Text.Json.Serialization.JsonPropertyName("share_user")]
                public int ShareUserCount { get; set; }

                /// <summary>
                /// 获取或设置分享的次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("share_count")]
                [System.Text.Json.Serialization.JsonPropertyName("share_count")]
                public int ShareCount { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.Data[] DataList { get; set; } = default!;
    }
}
