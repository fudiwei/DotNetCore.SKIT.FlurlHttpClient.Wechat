using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/draft/switch 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2022-02-25 下线。")]
    public class CgibinDraftSwitchRequest : WechatApiRequest, IMapResponse<CgibinDraftSwitchRequest, CgibinDraftSwitchResponse>
    {
        /// <summary>
        /// 获取或设置是否只检查状态。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public bool? OnlyCheck { get; set; }
    }
}
