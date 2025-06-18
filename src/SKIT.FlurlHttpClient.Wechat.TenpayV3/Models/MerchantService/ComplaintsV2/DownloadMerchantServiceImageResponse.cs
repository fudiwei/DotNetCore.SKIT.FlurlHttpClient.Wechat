using System.Linq;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /{download_url} 接口的响应。</para>
    /// </summary>
    public class DownloadMerchantServiceImageResponse : WechatTenpayResponse
    {
        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && GetRawBytes().Any();
        }
    }
}
