﻿using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedrive/file_delete 接口的请求。</para>
    /// </summary>
    public class CgibinWedriveFileDeleteRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置文件 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fileid")]
        [System.Text.Json.Serialization.JsonPropertyName("fileid")]
        public IList<string> FileIdList { get; set; } = new List<string>();
    }
}
