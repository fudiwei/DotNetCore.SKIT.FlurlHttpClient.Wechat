using System.Linq;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wxaapp/createwxaqrcode 接口的响应。</para>
    /// </summary>
    public class CgibinWxaappCreateWxaQrcodeResponse : WechatApiResponse
    {
        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && GetRawBytes().Any();
        }
    }
}
