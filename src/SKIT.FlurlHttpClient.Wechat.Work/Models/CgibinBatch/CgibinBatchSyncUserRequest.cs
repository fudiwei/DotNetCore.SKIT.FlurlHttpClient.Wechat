using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/batch/syncuser 接口的请求。</para>
    /// </summary>
    public class CgibinBatchSyncUserRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Callback
            {
                /// <summary>
                /// 获取或设置回调通知地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url")]
                [System.Text.Json.Serialization.JsonPropertyName("url")]
                public string NotifyUrl { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置用于生成签名的 Token。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("token")]
                [System.Text.Json.Serialization.JsonPropertyName("token")]
                public string Token { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置经过 Base64 编码的 AES 密钥。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("encodingaeskey")]
                [System.Text.Json.Serialization.JsonPropertyName("encodingaeskey")]
                public string EncodingAesKey { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置 CSV 文件 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_id")]
        [System.Text.Json.Serialization.JsonPropertyName("media_id")]
        public string MediaId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否邀请成员。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("to_invite")]
        [System.Text.Json.Serialization.JsonPropertyName("to_invite")]
        public bool? RequireInvite { get; set; }

        /// <summary>
        /// 获取或设置回调信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("callback")]
        [System.Text.Json.Serialization.JsonPropertyName("callback")]
        public Types.Callback? Callback { get; set; }
    }
}
