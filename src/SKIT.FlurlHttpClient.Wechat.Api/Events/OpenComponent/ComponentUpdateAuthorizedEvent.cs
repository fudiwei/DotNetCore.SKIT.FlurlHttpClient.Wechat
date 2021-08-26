using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 INFO.unauthorized 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/ThirdParty/token/authorize_event.html </para>
    /// </summary>
    public class ComponentUpdateAuthorizedEvent : ComponentAuthorizedEvent, WechatApiEvent.Serialization.IXmlSerializable
    {
    }
}
