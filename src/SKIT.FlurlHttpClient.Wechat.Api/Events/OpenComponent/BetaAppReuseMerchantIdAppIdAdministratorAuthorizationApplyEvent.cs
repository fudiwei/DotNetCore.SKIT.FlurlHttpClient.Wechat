namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.betaapp_reuse_merchant_ID_appid_administrator_authorization_apply_event 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/beta_Mini_Programs/fastverifyV2.html </para>
    /// </summary>
    public class BetaAppReuseMerchantIdAppIdAdministratorAuthorizationApplyEvent : WechatApiEvent, WechatApiEvent.Serialization.IXmlSerializable
    {
        public static class Types
        {
            public class EventData
            {
                /// <summary>
                /// 获取或设置小程序的 AppId。
                /// </summary>
                [System.Xml.Serialization.XmlElement("appid")]
                public string MiniProgramAppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置状态。
                /// </summary>
                [System.Xml.Serialization.XmlElement("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置操作时间戳。
                /// </summary>
                [System.Xml.Serialization.XmlElement("operation_time")]
                public long OperateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置错误信息。
                /// </summary>
                [System.Xml.Serialization.XmlElement("msg", IsNullable = true)]
                public string? ErrorMessage { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置事件数据。
        /// </summary>
        [System.Xml.Serialization.XmlElement("ApplyPersonalAuthorizationInfoNotify")]
        public Types.EventData EventData { get; set; } = default!;
    }
}
