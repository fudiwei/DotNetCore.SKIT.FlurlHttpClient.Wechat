using System.Linq;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/material/get_material 接口的响应。</para>
    /// </summary>
    public class CgibinMaterialGetMaterialResponse : WechatApiResponse
    {
        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && GetRawBytes().Any();
        }
    }
}
