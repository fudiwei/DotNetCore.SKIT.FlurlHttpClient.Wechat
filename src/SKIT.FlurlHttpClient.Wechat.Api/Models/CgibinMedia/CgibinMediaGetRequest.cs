namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/media/get 接口的请求。</para>
    /// </summary>
    public class CgibinMediaGetRequest : WechatApiRequest, IInferable<CgibinMediaGetRequest, CgibinMediaGetResponse>
    {
        /// <summary>
        /// 获取或设置媒体文件标识。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string MediaId { get; set; } = string.Empty;
    }
}
