namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/corpgroup/corp/get_chain_list 接口的响应。</para>
    /// </summary>
    public class CgibinCorpGroupCropGetChainListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Chain
            {
                /// <summary>
                /// 获取或设置上下游 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("chain_id")]
                [System.Text.Json.Serialization.JsonPropertyName("chain_id")]
                public string ChainId { get; set; } = default!;

                /// <summary>
                /// 获取或设置上下游名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("chain_name")]
                [System.Text.Json.Serialization.JsonPropertyName("chain_name")]
                public string ChainName { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置企业上下游列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chains")]
        [System.Text.Json.Serialization.JsonPropertyName("chains")]
        public Types.Chain[] ChainList { get; set; } = default!;
    }
}
