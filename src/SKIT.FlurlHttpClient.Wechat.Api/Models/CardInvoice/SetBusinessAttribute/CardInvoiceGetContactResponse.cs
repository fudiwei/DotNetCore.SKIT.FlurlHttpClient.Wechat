using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/invoice/setbizattr?action=get_contact 接口的响应。</para>
    /// </summary>
    public class CardInvoiceGetContactResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Contact : CardInvoiceSetContactRequest.Types.Contact
            {
            }
        }

        /// <summary>
        /// 获取或设置联系信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contact")]
        [System.Text.Json.Serialization.JsonPropertyName("contact")]
        public Types.Contact? Contact { get; set; }
    }
}
