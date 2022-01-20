using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedrive/file_move 接口的请求。</para>
    /// </summary>
    public class CgibinWebDriveFileMoveRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置操作者成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置上级文件 ID 或空间 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fatherid")]
        [System.Text.Json.Serialization.JsonPropertyName("fatherid")]
        public string ParentFileOrSpaceId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置文件 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fileid")]
        [System.Text.Json.Serialization.JsonPropertyName("fileid")]
        public IList<string> FileIdList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置是否覆盖同名文件。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("replace")]
        [System.Text.Json.Serialization.JsonPropertyName("replace")]
        public bool? RequireReplace { get; set; }
    }
}
