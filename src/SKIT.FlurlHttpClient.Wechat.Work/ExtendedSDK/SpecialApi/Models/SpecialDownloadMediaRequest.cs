using System;

namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.SpecialApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /spec/download_media 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2024-06-06 下线。")]
    public class SpecialDownloadMediaRequest : WechatWorkSpecialApiRequest
    {
        /// <summary>
        /// 获取或设置素材 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string MediaId { get; set; } = string.Empty;
    }
}
