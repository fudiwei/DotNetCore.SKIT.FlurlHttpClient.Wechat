namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /hire-power-bank/user-qualifications/{openid} 接口的响应。</para>
    /// </summary>
    public class GetHirePowerBankUserQualificationByOpenIdResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置是否具有领取资格。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qualified_user")]
        [System.Text.Json.Serialization.JsonPropertyName("qualified_user")]
        public bool IsQualifiedUser { get; set; }
    }
}
