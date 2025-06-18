using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedrive/file_upload_init 接口的请求。</para>
    /// </summary>
    public class CgibinWedriveFileUploadInitializeRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置 JSAPI 返回的 SelectedTicket。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("selected_ticket")]
        [System.Text.Json.Serialization.JsonPropertyName("selected_ticket")]
        public string? SelectedTicket { get; set; }

        /// <summary>
        /// 获取或设置空间 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spaceid")]
        [System.Text.Json.Serialization.JsonPropertyName("spaceid")]
        public string? SpaceId { get; set; }

        /// <summary>
        /// 获取或设置上级文件 ID 或空间 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fatherid")]
        [System.Text.Json.Serialization.JsonPropertyName("fatherid")]
        public string? ParentFileOrSpaceId { get; set; }

        /// <summary>
        /// 获取或设置文件名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_name")]
        [System.Text.Json.Serialization.JsonPropertyName("file_name")]
        public string FileName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置文件大小（单位：字节）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("size")]
        [System.Text.Json.Serialization.JsonPropertyName("size")]
        public int FileSize { get; set; }

        /// <summary>
        /// 获取或设置文件分块 SHA 哈希值列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("block_sha")]
        [System.Text.Json.Serialization.JsonPropertyName("block_sha")]
        public IList<string> BlockSHAList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置是否跳过推送。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("skip_push_card")]
        [System.Text.Json.Serialization.JsonPropertyName("skip_push_card")]
        public bool? IsSkipPushCard { get; set; }
    }
}
