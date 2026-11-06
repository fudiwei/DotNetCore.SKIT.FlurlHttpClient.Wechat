namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/dbaggregate 接口的请求。</para>
    /// </summary>
    public class ComponentTCBDbAggregateRequest : TCBDatabaseAggregateRequest, IInferable<ComponentTCBDbAggregateRequest, ComponentTCBDbAggregateResponse>
    {
        /// <summary>
        /// 获取或设置第三方平台 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? ComponentAccessToken { get; set; }
    }
}
