using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedrive/file_acl_del 接口的请求。</para>
    /// </summary>
    public class CgibinWedriveFileACLDeleteRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Authority : CgibinWedriveSpaceACLDeleteRequest.Types.Authority
            {
            }
        }

        /// <summary>
        /// 获取或设置文件 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fileid")]
        [System.Text.Json.Serialization.JsonPropertyName("fileid")]
        public string FileId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置文件解除授权信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_info")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_info")]
        public IList<Types.Authority> AuthorityList { get; set; } = new List<Types.Authority>();
    }
}
