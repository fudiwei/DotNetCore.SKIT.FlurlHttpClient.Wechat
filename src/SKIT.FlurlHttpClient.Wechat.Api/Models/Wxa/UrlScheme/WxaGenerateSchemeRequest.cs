﻿namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/generatescheme 接口的请求。</para>
    /// </summary>
    public class WxaGenerateSchemeRequest : WechatApiRequest, IInferable<WxaGenerateSchemeRequest, WxaGenerateSchemeResponse>
    {
        public static class Types
        {
            public class MiniProgram
            {
                /// <summary>
                /// 获取或设置小程序页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("path")]
                [System.Text.Json.Serialization.JsonPropertyName("path")]
                public string Path { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置小程序页面参数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("query")]
                [System.Text.Json.Serialization.JsonPropertyName("query")]
                public string? Query { get; set; }

                /// <summary>
                /// 获取或设置要打开的小程序版本。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("env_version")]
                [System.Text.Json.Serialization.JsonPropertyName("env_version")]
                public string? EnvironmentVersion { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置跳转到的目标小程序信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("jump_wxa")]
        [System.Text.Json.Serialization.JsonPropertyName("jump_wxa")]
        public Types.MiniProgram MiniProgram { get; set; } = new Types.MiniProgram();

        /// <summary>
        /// 获取或设置是否到期失效。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_expire")]
        [System.Text.Json.Serialization.JsonPropertyName("is_expire")]
        public bool? IsExpirable { get; set; }

        /// <summary>
        /// 获取或设置到期失效类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expire_type")]
        [System.Text.Json.Serialization.JsonPropertyName("expire_type")]
        public int ExpireType { get; set; }

        /// <summary>
        /// 获取或设置到期失效的时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expire_time")]
        [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
        public long? ExpireTimestamp { get; set; }

        /// <summary>
        /// 获取或设置到期失效的时间间隔（单位：天）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expire_interval")]
        [System.Text.Json.Serialization.JsonPropertyName("expire_interval")]
        public int? ExpireInterval { get; set; }
    }
}
