namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /channels/ec/basics/media/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECBasicsMediaGetRequest : WechatApiRequest, IInferable<ChannelsECBasicsMediaGetRequest, ChannelsECBasicsMediaGetResponse>
    {
        /// <summary>
        /// 获取或设置 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string MediaId { get; set; } = string.Empty;
    }
}
