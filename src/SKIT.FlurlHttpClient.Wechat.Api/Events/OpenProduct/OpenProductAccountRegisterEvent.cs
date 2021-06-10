using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.open_product_account_register 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent2/callback/account_register.html </para>
    /// </summary>
    public class OpenProductAccountRegisterEvent : WechatApiEvent, WechatApiEvent.Types.IJsonSerializable, WechatApiEvent.Types.IXmlSerializable
    {
        public new static class Types
        {
            public class EventData
            {
                /// <summary>
                /// 获取或设置开通状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                [System.Xml.Serialization.XmlElement("status")]
                public int Status { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置事件数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("OpenProductAccountRegister")]
        [System.Text.Json.Serialization.JsonPropertyName("OpenProductAccountRegister")]
        [System.Xml.Serialization.XmlElement("OpenProductAccountRegister")]
        public Types.EventData EventData { get; set; } = default!;
    }
}
