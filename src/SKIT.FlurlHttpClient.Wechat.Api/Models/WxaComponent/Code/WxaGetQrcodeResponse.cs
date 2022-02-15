namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/get_qrcode 接口的响应。</para>
    /// </summary>
    public class WxaGetQrcodeResponse : WechatApiResponse
    {
        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && RawBytes?.Length > 0;
        }
    }
}
