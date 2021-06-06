using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/add_corp_tag 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactAddCorpTagResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class TagGroup : CgibinExternalContactGetCorpTagListResponse.Types.TagGroup
            {
            }
        }

        /// <summary>
        /// 获取或设置企业标签分组信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tag_group")]
        [System.Text.Json.Serialization.JsonPropertyName("tag_group")]
        public Types.TagGroup TagGroup { get; set; } = default!;
    }
}
