using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/invoice/setbizattr?action=set_contact 接口的请求。</para>
    /// </summary>
    public class CardInvoiceSetContactRequest : WechatApiRequest, IMapResponse<CardInvoiceSetContactRequest, CardInvoiceSetContactResponse>
    {
        public static class Types
        {
            public class Contact
            {
                /// <summary>
                /// 获取或设置电话号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("phone")]
                [System.Text.Json.Serialization.JsonPropertyName("phone")]
                public string PhoneNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置开票超时时间（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("time_out")]
                [System.Text.Json.Serialization.JsonPropertyName("time_out")]
                public int Timeout { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置联系信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contact")]
        [System.Text.Json.Serialization.JsonPropertyName("contact")]
        public Types.Contact Contact { get; set; } = new Types.Contact();
    }
}
