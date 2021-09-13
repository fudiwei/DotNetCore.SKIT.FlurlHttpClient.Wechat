using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.user_info_modified 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Mobile_App/WeChat_Login/authorization_change.html </para>
    /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Website_App/WeChat_Login/authorization_change.html </para>
    /// </summary>
    public class UserInfoModifiedEvent : WechatApiEvent, WechatApiEvent.Serialization.IJsonSerializable, WechatApiEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        [System.Xml.Serialization.XmlElement("appid")]
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        [System.Xml.Serialization.XmlElement("openid")]
        public string OpenId { get; set; } = default!;
    }
}
