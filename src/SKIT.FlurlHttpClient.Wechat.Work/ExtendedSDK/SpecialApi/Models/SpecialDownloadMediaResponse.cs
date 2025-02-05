using System;

namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.SpecialApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /spec/download_media 接口的响应。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2024-06-06 下线。")]
    public class SpecialDownloadMediaResponse : WechatWorkSpecialApiResponse
    {
        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && GetRawHeaders().ContainsKey("Content-Disposition");
        }
    }
}
