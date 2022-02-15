namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/service/media/upload 接口的请求。</para>
    /// </summary>
    public class CgibinServiceMediaUploadRequest : CgibinMediaUploadRequest
    {
        /// <summary>
        /// 获取或设置服务商 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ProviderAccessToken { get; set; } = string.Empty;
    }
}
