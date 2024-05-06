namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global.Models
{
    /// <summary>
    /// <para>表示 [POST] /papay/contracts/{contract_id}/terminate 接口的请求。</para>
    /// </summary>
    public class TerminatePAPayContractRequest : WechatTenpayGlobalRequest
    {
        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public virtual string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置委托代扣协议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ContractId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置解约备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termination_note")]
        [System.Text.Json.Serialization.JsonPropertyName("termination_note")]
        public string? TerminationRemark { get; set; }
    }
}
