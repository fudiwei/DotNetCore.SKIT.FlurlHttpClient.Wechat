namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Events
{
    /// <summary>
    /// <para>表示教育续费通 ENTRUST.SIGNING 通知的数据。</para>
    /// <para>表示教育续费通 ENTRUST.RELEASE 通知的数据。</para>
    /// </summary>
    public class EducationEntrustResource : WechatTenpayEvent.Types.IDecryptedResource
    {
        public static class Types
        {
            public class Contract : Models.GetEducationPAPayContractByContractIdResponse.Types.Contract
            {
            }
        }

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plan_id")]
        [System.Text.Json.Serialization.JsonPropertyName("plan_id")]
        public string PlanId { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置签约信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_information")]
        [System.Text.Json.Serialization.JsonPropertyName("contract_information")]
        public Types.Contract Contract { get; set; } = default!;
    }
}
