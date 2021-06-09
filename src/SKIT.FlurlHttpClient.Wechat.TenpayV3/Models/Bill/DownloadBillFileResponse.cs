using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /{download_url} 接口的响应。</para>
    /// </summary>
    public class DownloadBillFileResponse : WechatTenpayResponse
    {
        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && RawBytes.Length > 0;
        }
    }
}
