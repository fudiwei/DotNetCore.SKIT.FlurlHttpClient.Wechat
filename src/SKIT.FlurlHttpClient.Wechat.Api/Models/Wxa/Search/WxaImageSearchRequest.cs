namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/imagesearch 接口的请求。</para>
    /// </summary>
    public class WxaImageSearchRequest : WechatApiRequest, IInferable<WxaImageSearchRequest, WxaImageSearchResponse>
    {
        /// <summary>
        /// 获取或设置图片字节数组。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[] ImageFileBytes { get; set; } = new byte[0];
    }
}
