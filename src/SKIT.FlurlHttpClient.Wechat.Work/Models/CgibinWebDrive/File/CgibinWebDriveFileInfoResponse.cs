using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedrive/file_info 接口的响应。</para>
    /// </summary>
    public class CgibinWebDriveFileInfoResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class File : CgibinWebDriveFileListResponse.Types.FileItem
            { 
            }
        }

        /// <summary>
        /// 获取或设置文件信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_info")]
        [System.Text.Json.Serialization.JsonPropertyName("file_info")]
        public Types.File File { get; set; } = default!;
    }
}
