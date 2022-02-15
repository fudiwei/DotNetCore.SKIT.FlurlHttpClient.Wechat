using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/msgaudit/check_single_agree 接口的请求。</para>
    /// </summary>
    public class CgibinMessageAuditCheckSingleAgreeRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string UserId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置外部联系人的 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("exteranalopenid")]
                [System.Text.Json.Serialization.JsonPropertyName("exteranalopenid")]
                public string ExternalOpenId { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置待查询的会话列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("info")]
        [System.Text.Json.Serialization.JsonPropertyName("info")]
        public IList<Types.Data> DataList { get; set; } = new List<Types.Data>();
    }
}
