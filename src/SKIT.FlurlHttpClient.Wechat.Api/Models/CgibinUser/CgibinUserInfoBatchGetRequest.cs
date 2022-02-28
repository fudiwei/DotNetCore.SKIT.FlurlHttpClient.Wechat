using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/user/info/batchget 接口的请求。</para>
    /// </summary>
    public class CgibinUserInfoBatchGetRequest : WechatApiRequest, IInferable<CgibinUserInfoBatchGetRequest, CgibinUserInfoBatchGetResponse>
    {
        public static class Types
        {
            public class User
            {
                /// <summary>
                /// 获取或设置用户唯一标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置返回国家地区语言版本。
                /// <para>默认值：zh_CN</para>
                /// </summary>
                [Newtonsoft.Json.JsonProperty("lang")]
                [System.Text.Json.Serialization.JsonPropertyName("lang")]
                public string Language { get; set; } = "zh_CN";
            }
        }

        /// <summary>
        /// 获取或设置批量获取的用户列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_list")]
        [System.Text.Json.Serialization.JsonPropertyName("user_list")]
        public IList<Types.User> UserList { get; set; } = new List<Types.User>();
    }
}
