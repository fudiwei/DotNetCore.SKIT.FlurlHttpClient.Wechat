namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/servicemarket/getwxaqrcode 接口的响应。</para>
    /// </summary>
    public class WxaServiceMarketGetWxaQrcodeResponse : WechatApiResponse
    {
        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && GetRawHeaders().ContainsKey(HttpHeaders.ContentDisposition);
        }
    }
}
