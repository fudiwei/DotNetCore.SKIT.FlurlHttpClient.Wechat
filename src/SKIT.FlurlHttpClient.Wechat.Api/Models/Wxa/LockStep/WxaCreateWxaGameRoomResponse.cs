using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/createwxagameroom 接口的响应。</para>
    /// </summary>
    public class WxaCreateWxaGameRoomResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置房间或对局访问凭证。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("access_info")]
                [System.Text.Json.Serialization.JsonPropertyName("access_info")]
                public string AccessInformation { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置房间或对局访问凭证数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
