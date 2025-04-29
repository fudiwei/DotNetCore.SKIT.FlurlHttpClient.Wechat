using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/book/addbookauth 接口的请求。</para>
    /// </summary>
    public class WxaBookAddBookAuthRequest : WechatApiRequest, IInferable<WxaBookAddBookAuthRequest, WxaBookAddBookAuthResponse>
    {
        public static class Types
        {
            public class Book
            {
                /// <summary>
                /// 获取或设置作品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("book_id")]
                [System.Text.Json.Serialization.JsonPropertyName("book_id")]
                public string BookId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置被授权账号 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("grantee_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("grantee_appid")]
                public string GranteeAppId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置授权到期时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expire_time")]
                [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
                public long? ExpireTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置作品列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("books")]
        [System.Text.Json.Serialization.JsonPropertyName("books")]
        public IList<Types.Book> BookList { get; set; } = new List<Types.Book>();
    }
}
