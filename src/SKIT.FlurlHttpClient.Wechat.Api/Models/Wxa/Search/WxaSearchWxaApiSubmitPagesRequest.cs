using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/search/wxaapi_submitpages 接口的请求。</para>
    /// </summary>
    public class WxaSearchWxaApiSubmitPagesRequest : WechatApiRequest
    {
        public static class Types
        {
            public class Page
            {
                /// <summary>
                /// 获取或设置页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("path")]
                [System.Text.Json.Serialization.JsonPropertyName("path")]
                public string Path { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置页面参数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("query")]
                [System.Text.Json.Serialization.JsonPropertyName("query")]
                public string Query { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置小程序页面信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pages")]
        [System.Text.Json.Serialization.JsonPropertyName("pages")]
        public IList<Types.Page> PageList { get; set; } = new List<Types.Page>();
    }
}
