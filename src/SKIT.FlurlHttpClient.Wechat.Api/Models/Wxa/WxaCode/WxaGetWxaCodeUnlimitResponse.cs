using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/getwxacodeunlimit 接口的响应。</para>
    /// </summary>
    public class WxaGetWxaCodeUnlimitResponse : WxaGetWxaCodeResponse
    {
        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && RawBytes?.Length > 0;
        }
    }
}
