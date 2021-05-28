using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/invoice/setbizattr?action=get_auth_field 接口的响应。</para>
    /// </summary>
    public class CardInvoiceGetAuthFieldResponse : WechatApiResponse
    {
        public static class Types
        {
            public class AuthField : CardInvoiceSetAuthFieldRequest.Types.AuthField
            {
            }
        }

        /// <summary>
        /// 获取或设置授权页信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_field")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_field")]
        public Types.AuthField? AuthField { get; set; }
    }
}
