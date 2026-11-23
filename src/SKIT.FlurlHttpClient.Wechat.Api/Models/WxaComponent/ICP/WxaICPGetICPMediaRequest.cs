namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/icp/get_icp_media 接口的请求。</para>
    /// </summary>
    public class WxaICPGetICPMediaRequest : WechatApiRequest, IInferable<WxaICPGetICPMediaRequest, WxaICPGetICPMediaResponse>
    {
        /// <summary>
        /// 获取或设置文件 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]

        public string? MediaId { get; set; }
    }
}
