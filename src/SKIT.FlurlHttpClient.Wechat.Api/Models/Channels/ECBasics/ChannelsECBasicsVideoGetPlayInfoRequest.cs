namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /channels/ec/basics/video/getplayinfo 接口的请求。</para>
    /// </summary>
    public class ChannelsECBasicsVideoGetPlayInfoRequest : WechatApiRequest, IInferable<ChannelsECBasicsVideoGetPlayInfoRequest, ChannelsECBasicsVideoGetPlayInfoResponse>
    {
        /// <summary>
        /// 获取或设置文件上传标识。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string VideoUploadKey { get; set; } = string.Empty;
    }
}
