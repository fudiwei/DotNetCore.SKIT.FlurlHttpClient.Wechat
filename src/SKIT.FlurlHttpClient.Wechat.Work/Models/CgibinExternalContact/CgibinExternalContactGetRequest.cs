﻿namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/externalcontact/get 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactGetRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置外部联系人账号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ExternalUserId { get; set; } = string.Empty;
    }
}
