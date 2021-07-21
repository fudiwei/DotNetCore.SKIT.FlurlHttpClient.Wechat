using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/getuserencryptkey 接口的响应。</para>
    /// </summary>
    public class WxaBusinessGetUserEncryptKeyResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Key
            {
                /// <summary>
                /// 获取或设置加密 Key。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("encrypt_key")]
                [System.Text.Json.Serialization.JsonPropertyName("encrypt_key")]
                public string EncryptKey { get; set; } = default!;

                /// <summary>
                /// 获取或设置加密 IV。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("iv")]
                [System.Text.Json.Serialization.JsonPropertyName("iv")]
                public string IV { get; set; } = default!;

                /// <summary>
                /// 获取或设置版本号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("version")]
                [System.Text.Json.Serialization.JsonPropertyName("version")]
                public int Version { get; set; }

                /// <summary>
                /// 获取或设置剩余有效时间（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expire_in")]
                [System.Text.Json.Serialization.JsonPropertyName("expire_in")]
                public int ExpiresIn { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置用户最近的加密 Key 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("key_info_list")]
        [System.Text.Json.Serialization.JsonPropertyName("key_info_list")]
        public Types.Key[] KeyList { get; set; } = default!;
    }
}
