﻿namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/getwxagameroominfo 接口的请求。</para>
    /// </summary>
    public class WxaGetWxaGameRoomInfoRequest : WechatApiRequest, IInferable<WxaGetWxaGameRoomInfoRequest, WxaGetWxaGameRoomInfoResponse>
    {
        /// <summary>
        /// 获取或设置房间或对局访问凭证。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string AccessInformation { get; set; } = string.Empty;
    }
}
