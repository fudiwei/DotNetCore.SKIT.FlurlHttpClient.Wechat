﻿namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/groupchat/del_join_way 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactGroupChatDeleteJoinWayRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置配置 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("config_id")]
        [System.Text.Json.Serialization.JsonPropertyName("config_id")]
        public string ConfigId { get; set; } = string.Empty;
    }
}
