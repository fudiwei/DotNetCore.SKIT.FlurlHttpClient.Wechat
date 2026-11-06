namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/uploadfile 接口的请求。</para>
    /// </summary>
    public class ComponentTCBUploadFileRequest : TCBUploadFileRequest, IInferable<ComponentTCBUploadFileRequest, ComponentTCBUploadFileResponse>
    {
        /// <summary>
        /// 获取或设置第三方平台 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? ComponentAccessToken { get; set; }
    }
}
