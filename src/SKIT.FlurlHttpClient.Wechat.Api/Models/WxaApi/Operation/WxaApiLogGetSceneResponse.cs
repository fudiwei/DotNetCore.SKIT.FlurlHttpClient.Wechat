using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxaapi/log/get_scene 接口的响应。</para>
    /// </summary>
    public class WxaApiLogGetSceneResponse : WechatApiResponse
    {
        public static class Types
        {
            public class SceneData
            {
                /// <summary>
                /// 获取或设置来源名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置来源数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("value")]
                [System.Text.Json.Serialization.JsonPropertyName("value")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumberTypedStringConverter))]
                public string Value { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置访问来源数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene")]
        [System.Text.Json.Serialization.JsonPropertyName("scene")]
        public Types.SceneData[] SceneDataList { get; set; } = default!;
    }
}
