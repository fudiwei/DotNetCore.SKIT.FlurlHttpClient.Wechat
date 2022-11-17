using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/service/contact/sort 接口的请求。</para>
    /// </summary>
    public class CgibinServiceContactSortRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class SortField
            {
                /// <summary>
                /// 获取或设置排序字段类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sort_field")]
                [System.Text.Json.Serialization.JsonPropertyName("sort_field")]
                public int FieldType { get; set; }

                /// <summary>
                /// 获取或设置排序方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sort_type")]
                [System.Text.Json.Serialization.JsonPropertyName("sort_type")]
                public int SortType { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置服务商 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ProviderAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置授权方 CorpId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_corpid")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_corpid")]
        public string AuthorizerCorpId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置排序字段列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sort_options")]
        [System.Text.Json.Serialization.JsonPropertyName("sort_options")]
        public IList<Types.SortField>? SortFieldList { get; set; }

        /// <summary>
        /// 获取或设置要排序的成员账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("useridlist")]
        [System.Text.Json.Serialization.JsonPropertyName("useridlist")]
        public IList<string> UserIdList { get; set; } = new List<string>();
    }
}
