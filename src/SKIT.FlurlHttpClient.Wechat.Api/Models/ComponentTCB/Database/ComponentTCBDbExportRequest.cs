namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/dbexport 接口的请求。</para>
    /// </summary>
    public class ComponentTCBDbExportRequest : TCBDatabaseMigrateExportRequest, IInferable<ComponentTCBDbExportRequest, ComponentTCBDbExportResponse>
    {
        /// <summary>
        /// 获取或设置第三方平台 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? ComponentAccessToken { get; set; }
    }
}
