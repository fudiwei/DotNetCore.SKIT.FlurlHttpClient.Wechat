namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/corpgroup/corp/get_chain_corpinfo 接口的响应。</para>
    /// </summary>
    public class CgibinCorpGroupCorpGetChainCorpInfoResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置企业名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("corp_name")]
        [System.Text.Json.Serialization.JsonPropertyName("corp_name")]
        public string CorpName { get; set; } = default!;

        /// <summary>
        /// 获取或设置分组 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("groupid")]
        [System.Text.Json.Serialization.JsonPropertyName("groupid")]
        public int GroupId { get; set; }

        /// <summary>
        /// 获取或设置自定义 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("custom_id")]
        [System.Text.Json.Serialization.JsonPropertyName("custom_id")]
        public string? CustomId { get; set; }

        /// <summary>
        /// 获取或设置企业验证认证状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qualification_status")]
        [System.Text.Json.Serialization.JsonPropertyName("qualification_status")]
        public int? QualificationStatus { get; set; }

        /// <summary>
        /// 获取或设置企业是否已加入。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_joined")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("is_joined")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
        public bool IsJoined { get; set; }
    }
}
