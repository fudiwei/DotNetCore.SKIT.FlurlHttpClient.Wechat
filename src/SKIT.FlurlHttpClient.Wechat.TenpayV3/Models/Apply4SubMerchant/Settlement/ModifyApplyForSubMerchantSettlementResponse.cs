namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /apply4sub/sub_merchants/{sub_mchid}/modify-settlement 接口的响应。</para>
    /// </summary>
    public class ModifyApplyForSubMerchantSettlementResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("application_no")]
        [System.Text.Json.Serialization.JsonPropertyName("application_no")]
        public string ApplicationNumber { get; set; } = default!;
    }
}
