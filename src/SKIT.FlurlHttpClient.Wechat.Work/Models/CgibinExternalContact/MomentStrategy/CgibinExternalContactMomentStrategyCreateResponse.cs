namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/moment_strategy/create 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactMomentStrategyCreateResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置规则组 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("strategy_id")]
        [System.Text.Json.Serialization.JsonPropertyName("strategy_id")]
        public int StrategyId { get; set; }
    }
}
