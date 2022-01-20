using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/service/set_session_info 接口的请求。</para>
    /// </summary>
    public class CgibinServiceSetSessionInfoRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Session
            {
                /// <summary>
                /// 获取或设置允许授权的 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public IList<int>? AppIdList { get; set; }

                /// <summary>
                /// 获取或设置授权类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auth_type")]
                [System.Text.Json.Serialization.JsonPropertyName("auth_type")]
                public int? AuthType { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置预授权码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pre_auth_code")]
        [System.Text.Json.Serialization.JsonPropertyName("pre_auth_code")]
        public string PreAuthCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置本次授权过程中需要用到的会话信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("session_info")]
        [System.Text.Json.Serialization.JsonPropertyName("session_info")]
        public Types.Session Session { get; set; } = new Types.Session();
    }
}
