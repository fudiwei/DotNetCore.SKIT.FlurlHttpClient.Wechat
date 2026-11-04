namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/add_corp_tag 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactAddCorpTagResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class TagGroup : CgibinExternalContactGetCorpTagListResponse.Types.__zz__TagGroup
            {
                public static class Types
                {
                    public class Tag : CgibinExternalContactGetCorpTagListResponse.Types.TagGroup.Types.Tag
                    {
                    }
                }

                /// <summary>
                /// 获取或设置企业标签列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tag")]
                [System.Text.Json.Serialization.JsonPropertyName("tag")]
                public List<Types.Tag>? TagList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置企业标签分组信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tag_group")]
        [System.Text.Json.Serialization.JsonPropertyName("tag_group")]
        public Types.TagGroup? TagGroup { get; set; }
    }
}
