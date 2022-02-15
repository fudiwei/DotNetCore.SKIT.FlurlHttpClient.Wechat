using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/getwxagameframe 接口的请求。</para>
    /// </summary>
    public class WxaGetWxaGameFrameRequest : WechatApiRequest, IMapResponse<WxaGetWxaGameFrameRequest, WxaGetWxaGameFrameResponse>
    {
        /// <summary>
        /// 获取或设置房间或对局访问凭证。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string AccessInformation { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置待获取帧的起始帧编号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int BeginFrameId { get; set; }

        /// <summary>
        /// 获取或设置待获取帧的终止帧编号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int EndFrameId { get; set; }
    }
}
