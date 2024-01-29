using System.Linq;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/media/get/jssdk 接口的响应。</para>
    /// </summary>
    public class CgibinMediaGetJssdkResponse : WechatWorkResponse
    {
        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && GetRawBytes().Any();
        }
    }
}
