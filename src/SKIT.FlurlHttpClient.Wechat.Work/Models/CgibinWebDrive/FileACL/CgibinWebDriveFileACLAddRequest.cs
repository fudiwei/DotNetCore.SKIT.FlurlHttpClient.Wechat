using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedrive/file_acl_add 接口的请求。</para>
    /// </summary>
    public class CgibinWebDriveFileACLAddRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Authority : CgibinWebDriveSpaceACLAddRequest.Types.Authority
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
        /// 获取或设置文件授权信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_info")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_info")]
        public IList<Types.Authority> AuthorityList { get; set; } = new List<Types.Authority>();
    }
}
