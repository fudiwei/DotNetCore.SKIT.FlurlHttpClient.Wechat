namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/corpgroup/corp/get_chain_corpinfo_list 接口的请求。</para>
    /// </summary>
    public class CgibinCorpGroupCropGetChainCorpInfoListRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置上下游 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ChainId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置分组 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? GroupId { get; set; }

        /// <summary>
        /// 获取或设置是否递归获取子分组企业。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public bool? RequireFetchChild { get; set; }
    }
}
