namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.betaapp_reuse_merchant_ID_merchant_administrator_authorization_apply_event 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/beta_Mini_Programs/fastverifyV2.html </para>
    /// </summary>
    public class BetaAppReuseMerchantIdMerchantAdministratorAuthorizationApplyEvent : WechatApiEvent, WechatApiEvent.Serialization.IXmlSerializable
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
                /// 获取或设置任务 ID。
                /// </summary>
                [System.Xml.Serialization.XmlElement("taskid")]
                public string TaskId { get; set; } = default!;

                /// <summary>
                /// 获取或设置状态。
                /// </summary>
                [System.Xml.Serialization.XmlElement("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置小程序管理员访问的授权 URL。
                /// </summary>
                [System.Xml.Serialization.XmlElement("authorize_appid_administrator_url")]
                public string AuthorizeAppIdAdministratorUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置商户号管理员授权的状态。
                /// </summary>
                [System.Xml.Serialization.XmlElement("authorize_merchant_administrator_status")]
                public int AuthorizeMerchantAdministratorStatus { get; set; }

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
        [System.Xml.Serialization.XmlElement("ApplyMerchantAdminAuthorizationInfoNotify")]
        public Types.EventData EventData { get; set; } = default!;
    }
}
